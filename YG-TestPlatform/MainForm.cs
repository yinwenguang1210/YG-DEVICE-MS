/*
    SZ-DEVICE-MS is an open source project 
    Licensed under the GNU GPLv3
    Author : Wenguang Yin
 
*/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace YG_TestPlatform
{
    public partial class MainForm : Form
    {
        #region 变量定义
        
        private string data;
        private int graph_scaler = 500;
        private int send_repeat_counter = 0;
        private bool send_data_flag = false;
        private bool plotter_flag = true;
        private bool file_send_flag = false;
        private string cmdButtonName = "";
        private Thread loopThread;
        private static StreamWriter writer;
        private string filePaths = "";
        private int sendNumber = 0; //发送计数
        private int receiveNumber = 0; //接收计数
        private string dataWrite = "";
        private static List<string> tempBuilder = new List<string>();

        static bool isRunning = false;
        static bool isPaused = false;
        static bool isCancelled = false;
        static bool isLoop = false;
        static bool isFlagSend = false;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            configrations();
        }

        #region 串口配置参数
        
        public void configrations()
        {
            portConfig.Items.AddRange(SerialPort.GetPortNames());
            baudrateConfig.DataSource = new[] { "1500000", "921600", "750000", "512000", "460800", "256000", "128000", "115200", "57600", "56000", "38400", "19200", "14400", "9600", "4800" };
            parityConfig.DataSource = new[] { "无效验", "奇校验", "偶校验", "固定1", "固定0"}; //无效验：None、奇校验：Odd、偶校验：Even、固定1：Mark、固定0：Space
            databitsConfig.DataSource = new[] { "5", "6", "7", "8" };
            stopbitsConfig.DataSource = new[] { "1", "2", "1.5" };
            flowcontrolConfig.DataSource = new[] { "None", "RTS", "RTS/X", "Xon/Xoff" };
            //portConfig.SelectedIndex = 0;
            baudrateConfig.SelectedIndex = 7; //默认：115200
            parityConfig.SelectedIndex = 0;
            databitsConfig.SelectedIndex = 3; //默认：8
            stopbitsConfig.SelectedIndex = 0;
            flowcontrolConfig.SelectedIndex = 0;
            openFileDialog1.Filter = "Text|*.txt";
            mySerial.DataReceived += rx_data_event;
            mySerial.ReadBufferSize = 8192;
            tx_repeater_delay.Tick += new EventHandler(send_data);
            backgroundWorker1.DoWork += new DoWorkEventHandler(update_rxtextarea_event);

        }

        #endregion

        /*connect and disconnect*/
        private void connect_Click(object sender, EventArgs e)
        {
            /*Connect*/
            if (!mySerial.IsOpen)
            {
                if (Serial_port_config())
                {
                    try
                    {
                        mySerial.Open();
                    }
                    catch
                    {
                        alert("无法打开 " + mySerial.PortName + " 端口，它可能在其他程序中使用");
                        return;
                    }

                    UserControl_state(true);
                }
            }

            /*Disconnect*/
            else if (mySerial.IsOpen)
            {
                try
                {
                    mySerial.Close();
                    mySerial.DiscardInBuffer();
                    mySerial.DiscardOutBuffer();
                }
                catch {/*ignore*/}


                UserControl_state(false);
            }
        }


        /* RX -----*/

        /* read data from serial */
        private void rx_data_event(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (mySerial.IsOpen)
            {
                try
                {
                    // 添加延时
                    Thread.Sleep(100);
                    // 获取当前时间并添加时间戳
                    string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
                    byte[] dataRecevied;
                    

                    if (checkBoxCRC16.Checked)
                    {

                        //crc接收
                        dataRecevied = ReceiveData();
                        string tempDataRecevied = string.Empty;
                        if (send_hex_radiobutton.Checked == false)
                        {
                           
                            tempDataRecevied = Encoding.Default.GetString(dataRecevied);
                        }

                        if (send_hex_radiobutton.Checked == true)
                        {
                            byte[] bytes = dataRecevied;

                            StringBuilder hexBuilder = new StringBuilder();
                            foreach (byte b in bytes)
                            {
                                hexBuilder.Append($"{b:X2} ");
                            }

                            string hexString = hexBuilder.ToString();
                            tempDataRecevied = hexString;
                        }

                        bool isHex = IsHexadecimalFormat(Encoding.Default.GetString(dataRecevied));

                        //判断：勾选了16进制，但是内容不是16进制
                        if (display_hex_radiobutton.Checked)
                        {
                            // 将文本转换为十六进制
                            byte[] bytes = dataRecevied;

                            StringBuilder hexBuilder = new StringBuilder();
                            foreach (byte b in bytes)
                            {
                                hexBuilder.Append($"{b:X2} ");
                            }

                            string hexString = hexBuilder.ToString();

                            // 将十六进制字符串显示到文本框
                            tempDataRecevied = hexString;
                        }
                        else
                        {
                            tempDataRecevied = Encoding.Default.GetString(dataRecevied);
                        }

                        data = $"[{timestamp}] RX > {tempDataRecevied} \n";
                        rx_textarea.AppendText(data);
                        data = data.TrimStart();
                        receiveNumber += 1;
                        receiveCount.Text = "" + receiveNumber;
                    }
                    else
                    {
                        //普通接收
                        int dataLength = mySerial.BytesToRead;
                        dataRecevied = new byte[dataLength];
                        int nbytes = mySerial.Read(dataRecevied, 0, dataLength);
                        if (nbytes == 0) return;

                        this.BeginInvoke((Action)(() =>
                        {
                            string tempDataRecevied = Encoding.Default.GetString(dataRecevied);
                            if (display_hex_radiobutton.Checked == true)
                            {

                                bool isHex = IsHexadecimalFormat(tempDataRecevied);
                                if (!isHex)
                                {
                                    byte[] bytes = Encoding.ASCII.GetBytes(tempDataRecevied);

                                    StringBuilder hexBuilder = new StringBuilder();
                                    foreach (byte b in bytes)
                                    {
                                        hexBuilder.Append($"{b:X2} ");
                                    }

                                    string hexString = hexBuilder.ToString();

                                    // 将十六进制字符串显示到文本框
                                    tempDataRecevied = hexString;
                                }
                            }

                            data = $"[{timestamp}] RX > {tempDataRecevied} \n";
                            data = data.TrimStart();
                            if (!backgroundWorker1.IsBusy)
                            {
                                if (display_hex_radiobutton.Checked == true && isFlagSend == true)
                                {
                                    //如果内容本来是16进制，那么就不需要再次转换
                                    bool isHex = IsHexadecimalFormat(tempDataRecevied);
                                    if (!isHex)
                                    {
                                        data = $"[{timestamp}] RX > {BitConverter.ToString(dataRecevied)} \n";
                                    }
                                }

                                backgroundWorker1.RunWorkerAsync();
                            }

                            if (plotter_flag)
                            {
                                double number;
                                string[] variables = data.Split('\n')[0].Split(',');
                                for (int i = 0; i < variables.Length && i < 5; i++)
                                {
                                    if (double.TryParse(variables[i], out number))
                                    {
                                        if (graph.Series[i].Points.Count > graph_scaler)
                                            graph.Series[i].Points.RemoveAt(0);
                                        graph.Series[i].Points.Add(number);
                                    }
                                }
                                graph.ResetAutoValues();
                            }
                        }));
                    }

                    



                }
                catch { alert("无法读取表单  " + mySerial.PortName + " 端口，它可能已在其他程序中打开"); }
            }
        }

        /* Append text to rx_textarea*/
        private void update_rxtextarea_event(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (rx_textarea.Lines.Count() > 5000)
                    rx_textarea.ResetText();

                //未勾选暂停接收显示
                if (!display_stop_radiobutton.Checked)
                {
                    #region 接收并保存到文件
                    
                    if (receive_save_file_checkBox.Checked && !string.IsNullOrEmpty(filePaths))
                    {
                        // 创建 StreamWriter 对象并将字符串写入文件
                        using (writer = new StreamWriter(filePaths, true))
                        {
                            string cacheData = data;//缓存数据
                            if (!string.IsNullOrEmpty(dataWrite))
                            {
                                cacheData = dataWrite;
                                writer.Write(cacheData);
                            }

                            if (!string.IsNullOrEmpty(data))
                            {
                                cacheData = data;
                                writer.Write(cacheData);
                            }
                            writer.Flush();
                        }
                    }

                    #endregion

                    //记录接收次数（按条计算接收）
                    receiveNumber += 1;
                    receiveCount.Text = "" + receiveNumber;
                    if (!string.IsNullOrEmpty(dataWrite.Trim()))
                    {                        
                        rx_textarea.AppendText(dataWrite);
                        rx_textarea.AppendText(data);
                        dataWrite = "";
                    }
                    else
                    {
                        rx_textarea.AppendText(data);
                    }
                    
                }
                else
                {
                    dataWrite += data;
                }                

            }));
        }



        /* clear rx textarea */
        private void clear_rx_textarea_Click(object sender, EventArgs e)
        {
            rx_textarea.Clear();

            //发送计数置零
            sendNumber = 0;
            sendCount.Text = "0";

            //接收计数置零
            receiveNumber = 0;
            receiveCount.Text = "0";
        }

        /*TX------*/

        /* Write data to serial port */
        private void sendData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(portConfig.Text))
            {
                alert("没有可用的端口");
                return;
            }

            if (!string.IsNullOrEmpty(tempPart))
            {
                tx_textarea.Text = tempPart;
                tempPart = ""; //置空
            }

            //【文件发送】接收区设置，如果勾选了十六进制显示，那么也需要将发送区的内容转换成十六进制

            if (display_hex_radiobutton.Checked  == true && isFlagSend == true)
            {
                //如果内容本来是16进制，那么就不需要再次转换
                bool isHex = IsHexadecimalFormat(tx_textarea.Text);
                if (!isHex)
                {
                    byte[] bytes = Encoding.ASCII.GetBytes(tx_textarea.Text);

                    StringBuilder hexBuilder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        hexBuilder.Append($"{b:X2} ");
                    }

                    string hexString = hexBuilder.ToString();

                    // 将十六进制字符串显示到文本框
                    tx_textarea.Text = hexString;
                }
            }

            if (!send_data_flag)
            {
                tx_repeater_delay.Interval = 1;
                tx_repeater_delay.Start();
                send_data_flag = true;
                tx_num_panel.Enabled = false;
                tx_textarea.Enabled = false;
            }
            else
            {
                tx_repeater_delay.Stop();
                send_repeat_counter = 0;
                send_data_flag = false;
                tx_num_panel.Enabled = true;
                tx_textarea.Enabled = true;
            }
        }

        private void send_data(object sender, EventArgs e)
        {
            string tx_data = "";

            tx_data = tx_textarea.Text.Replace("\n", Environment.NewLine);
            
            if (send_repeat_counter < 1)
            {
                send_repeat_counter++;
            }
            else
            {
                send_data_flag = false;
            }


            if (send_data_flag)
            {
                if (mySerial.IsOpen)
                {
                    try
                    {
                        
                        //记录发送次数（按条计算发送）
                        sendNumber += 1;
                        sendCount.Text = "" + sendNumber;
                        string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");


                        if (checkBoxCRC16.Checked)
                        {
                            string hexData = "";
                            if (send_hex_radiobutton.Checked == true)
                            {
                                //crc发送
                                hexData = tx_data.Replace(" ", "").Trim(); // 16进制数据

                                byte[] byteArray = new byte[hexData.Length / 2];

                                for (int i = 0; i < hexData.Length; i += 2)
                                {
                                    string hexByte = hexData.Substring(i, 2);
                                    byte convertedByte = byte.Parse(hexByte, System.Globalization.NumberStyles.HexNumber);
                                    byteArray[i / 2] = convertedByte;
                                }

                                tx_data = SendData(byteArray);
                            }

                            if (send_hex_radiobutton.Checked == false)
                            {
                                //crc发送

                                //将字符串转换成十六进制
                                string text = tx_data;
                                byte[] bytes = Encoding.ASCII.GetBytes(text);

                                StringBuilder hexBuilder = new StringBuilder();
                                foreach (byte b in bytes)
                                {
                                    hexBuilder.Append($"{b:X2} ");
                                }

                                string hexString = hexBuilder.ToString();

                                hexData = hexString.Replace(" ", ""); // 16进制数据

                                byte[] byteArray = new byte[hexData.Length / 2];

                                for (int i = 0; i < hexData.Length; i += 2)
                                {
                                    string hexByte = hexData.Substring(i, 2);
                                    byte convertedByte = byte.Parse(hexByte, System.Globalization.NumberStyles.HexNumber);
                                    byteArray[i / 2] = convertedByte;
                                }

                                string textNew = SendData(byteArray);
                                
                                // 将十六进制转换为字符串
                                string hexStringNew = textNew.Replace(" ",""); // 去除空格
                                byte[] bytesNew = new byte[hexStringNew.Length / 2];
                                for (int i = 0; i < bytesNew.Length; i++)
                                {
                                    bytesNew[i] = Convert.ToByte(hexStringNew.Substring(i * 2, 2), 16);
                                }

                                tx_data = Encoding.ASCII.GetString(bytesNew);
                            }


                        }
                        else
                        {
                            //普通发送
                            mySerial.Write(tx_data);
                        }

                        string dataTX = "";
                        if (display_hex_radiobutton.Checked == true)
                        {
                            bool isHex = IsHexadecimalFormat(tx_data);
                            if (!isHex)
                            {
                                byte[] bytes = Encoding.ASCII.GetBytes(tx_data);

                                StringBuilder hexBuilder = new StringBuilder();
                                foreach (byte b in bytes)
                                {
                                    hexBuilder.Append($"{b:X2} ");
                                }

                                string hexString = hexBuilder.ToString();

                                // 将十六进制字符串显示到文本框
                                tx_data = hexString;
                            }
                        }
                        dataTX = $"[{timestamp}] TX > {tx_data} \n";


                        rx_textarea.AppendText(dataTX);

                        #region 接收并保存到文件

                        if (receive_save_file_checkBox.Checked && !string.IsNullOrEmpty(filePaths))
                        {
                            // 创建 StreamWriter 对象并将字符串写入文件
                            using (writer = new StreamWriter(filePaths, true))
                            {
                                writer.Write(dataTX);
                                writer.Flush();
                            }
                        }

                        #endregion

                    }
                    catch (Exception ex)
                    {
                        alert("无法写入 " + mySerial.PortName + " 端口，它可能已在其他程序中打开,具体错误信息："+ ex.Message);
                    }
                }
            }
            else
            {
                tx_repeater_delay.Stop();
                send_repeat_counter = 0;
                tx_num_panel.Enabled = true;
                tx_textarea.Enabled = true;
            }
        }


        //CRC发送
        public string SendData(byte[] data)
        {
            // 计算CRC16-Modbus校验码
            ushort crc = CRC.CalculateCRC(data);

            // 将校验码追加到数据中
            byte[] dataWithCRC = new byte[data.Length + 2];
            Array.Copy(data, 0, dataWithCRC, 0, data.Length);
            dataWithCRC[data.Length] = (byte)(crc & 0xFF); // 低字节
            dataWithCRC[data.Length + 1] = (byte)(crc >> 8); // 高字节

            StringBuilder hexStringBuilder = new StringBuilder();
            byte[] aa = BitConverter.GetBytes(crc);
            for (int i = 0; i < dataWithCRC.Length; i++)
            {
                hexStringBuilder.AppendFormat("{0:x2}" + "", dataWithCRC[i]);
            }
            string hexString = hexStringBuilder.ToString(); // 去除空格的16进制字符串
            string spacedHexString = string.Join(" ", Enumerable.Range(0, hexString.Length / 2)
                .Select(i => hexString.Substring(i * 2, 2)));

            //发送数据
            mySerial.Write(dataWithCRC, 0, dataWithCRC.Length);
            return spacedHexString;
        }


        //CRC接收
        public byte[] ReceiveData()
        {
            // 读取串口接收缓冲区中的数据
            int dataSize = mySerial.BytesToRead;
            byte[] buffer = new byte[dataSize];

            mySerial.Read(buffer, 0, dataSize);

            bool flag = CRC.ValidateData(buffer);

            // 检查接收到的数据的有效性（校验码）
            if (flag)
            {
                // 去除校验码，返回有效数据
                // byte[] data = new byte[buffer.Length - 2];
                
                // 保留校验码
                byte[] data = new byte[buffer.Length];
                Array.Copy(buffer, 0, data, 0, data.Length);
                return data;
            }
            else
            {
                // 数据校验失败
                throw new Exception("Received data validation failed.");
            }
        }



        /* Plotter ------*/
        private void graph_speed_ValueChanged(object sender, EventArgs e)
        {
            graph.ChartAreas[0].AxisY.Interval = (int)graph_speed.Value;
        }
        /* change graph scale*/
        private void graph_scale_ValueChanged(object sender, EventArgs e)
        {
            graph_scaler = (int)graph_scale.Value;
            for (int i = 0; i < 5; i++)
            {
                graph.Series[i].Points.Clear();
            }
        }
        /* set graph max value*/
        private void set_graph_max_enable_CheckedChanged(object sender, EventArgs e)
        {
            if (set_graph_max_enable.Checked)
                try
                {
                    graph_max.Value = (int)graph.ChartAreas[0].AxisY.Maximum;
                    graph.ChartAreas[0].AxisY.Maximum = (int)graph_max.Value;
                }
                catch { alert("无效的最小值"); }
            else
                graph.ChartAreas[0].AxisY.Maximum = Double.NaN;

            graph_max.Enabled = set_graph_max_enable.Checked;
        }
        private void graph_max_ValueChanged(object sender, EventArgs e)
        {
            if (graph_max.Value > graph_min.Value)
                graph.ChartAreas[0].AxisY.Maximum = (int)graph_max.Value;
            else
                alert("无效的最大值");
        }
        /* set graph min value*/
        private void set_graph_min_enable_CheckedChanged(object sender, EventArgs e)
        {
            if (set_graph_min_enable.Checked)
                try
                {
                    graph_min.Value = (int)graph.ChartAreas[0].AxisY.Minimum;
                    graph.ChartAreas[0].AxisY.Minimum = (int)graph_min.Value;
                }
                catch { alert("无效的最小值"); }
            else
                graph.ChartAreas[0].AxisY.Minimum = Double.NaN;

            graph_min.Enabled = set_graph_min_enable.Checked;
        }
        private void graph_min_ValueChanged(object sender, EventArgs e)
        {
            if (graph_min.Value < graph_max.Value)
                graph.ChartAreas[0].AxisY.Minimum = (int)graph_min.Value;
            else
                alert("无效的最大值");
        }
        /* save graph as image*/
        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                graph.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Png);
        }
        /*clear graph*/
        private void clear_graph_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                graph.Series[i].Points.Clear();
            }
        }

        /*Application-----*/
        /*serial port config*/
        private bool Serial_port_config()
        {
            try { mySerial.PortName = portConfig.Text; }
            catch { alert("没有可用的端口"); return false; }
            mySerial.BaudRate = (Int32.Parse(baudrateConfig.Text));
            mySerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (stopbitsConfig.SelectedIndex + 1).ToString(), true);
            mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), parityConfig.SelectedIndex.ToString(), true);
            mySerial.DataBits = (Int32.Parse(databitsConfig.Text));
            mySerial.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowcontrolConfig.SelectedIndex.ToString(), true);

            return true;
        }

        private void UserControl_state(bool value)
        {

            if (value)
            {
                connect.BackColor = Color.FromArgb(42, 192, 90);  // 设置绿色
                connect.Text = "关闭串口";
                toolStripStatusLabel1.Text = "已连接端口: " + mySerial.PortName + " @ " + mySerial.BaudRate + " bps";
            }
            else
            {

                connect.BackColor = Color.Transparent;  // 设置透明色
                connect.Text = "打开串口";
                toolStripStatusLabel1.Text = "无连接";
            }
        }



        /* Search for available serial ports */
        private void portConfig_Click(object sender, EventArgs e)
        {
            portConfig.Items.Clear();
            portConfig.Items.AddRange(SerialPort.GetPortNames());
        }
        /*alert function*/
        private void alert(string text)
        {
            alert_messege.Icon = Icon;
            alert_messege.Visible = true;
            alert_messege.ShowBalloonTip(5000, "提 示", text, ToolTipIcon.Error);
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tx_terminal.Clear();
            rx_textarea.Clear();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {


            //设置只读
            rx_textarea.ReadOnly = true;
            #region 暂停按钮

            // 创建一个 ImageList 控件
            imageList1 = new ImageList();
            // 从文件加载图标并添加到 ImageList
            imageList1.Images.Add(Image.FromFile(Path.GetFullPath("images/暂停.png")));
            btnStartAndPause.Text = "";
            // 将 ImageList 分配给按钮
            btnStartAndPause.ImageList = imageList1;
            // 设置按钮上显示的图标索引
            btnStartAndPause.ImageIndex = 0;

            #endregion

            #region 设置按钮

            BtnChartSetting.Text = "";
            // 设置按钮的样式为 Flat
            BtnChartSetting.FlatStyle = FlatStyle.Flat;
            // 设置按钮的边框颜色与背景颜色一致，使边框不可见
            BtnChartSetting.FlatAppearance.BorderColor = BtnChartSetting.BackColor;
            BtnChartSetting.BackgroundImage = Image.FromFile(Path.GetFullPath("images/设置.png"));
            BtnChartSetting.BackgroundImageLayout = ImageLayout.Zoom;

            #endregion

            #region 发送按钮
            imageList1 = new ImageList();
            imageList1.Images.Add(Image.FromFile(Path.GetFullPath("images/发送.png")));
            imageList1.ImageSize = new Size(50, 50);
            sendData.Text = "";
            sendData.ImageList = imageList1;
            sendData.ImageIndex = 0;

            #endregion

            #region 绑定图表属性

            graph.Series.Clear();

            SQLiteSamples sQLite = new SQLiteSamples();
            List<SysConfig> sysConfigs = sQLite.getAll();
            for (int i = 0; i < sysConfigs.Count; i++)
            {
                string name = sysConfigs[i].Name;
                string legendText = name;
                Series series = new Series(name);
                series.Legend = "Legend1";
                series.Name = name;
                series.BorderWidth = Convert.ToInt32(Convert.ToDouble(sysConfigs[i].LineDesc));
                series.LegendText = legendText;
                series.LabelBorderWidth = Convert.ToInt32(Convert.ToDouble(sysConfigs[i].LineDesc));

                // 设置线图（Line）系列类型
                if (sysConfigs[i].TypeDesc.Equals("Line"))
                {
                    series.ChartType = SeriesChartType.Line;
                }

                // 设置点图（Dot）系列类型
                if (sysConfigs[i].TypeDesc.Equals("Dot"))
                {
                    series.ChartType = SeriesChartType.Point;
                }

                // 设置柱状图（Bar）系列类型
                if (sysConfigs[i].TypeDesc.Equals("Bar"))
                {
                    series.ChartType = SeriesChartType.Bar;
                }

                if (i == 0)
                {
                    series.YValuesPerPoint = 32;
                }
                else
                {
                    series.YValuesPerPoint = 1;
                }

                series.Color = ColorTranslator.FromHtml(sysConfigs[i].ColorDesc);
                // 添加数据点
                series.Points.AddXY(0, 0);
                series.Points.AddXY(0, 0);
                // 添加更多的数据点...

                // 将数据系列添加到图表中
                graph.Series.Add(series);
            }
            #endregion

        }

        /// <summary>
        /// 保存数据：保存缓存数据到txt文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveData_Click(object sender, EventArgs e)
        {
            string cacheData = rx_textarea.Text;//缓存数据
            string saveDataFilePaths = "";
            // 创建 SaveFileDialog 对象
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // 设置文件筛选器，只能选择保存为 txt 格式的文件
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            // 如果用户选择了文件并单击了“保存”按钮
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                saveDataFilePaths = saveFileDialog.FileName;

                // 创建 StreamWriter 对象并将字符串写入文件
                using (StreamWriter writer = new StreamWriter(saveDataFilePaths))
                {
                    writer.Write(cacheData);
                }
            }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearData_Click(object sender, EventArgs e)
        {
            rx_textarea.Text = "";
            //发送计数置零
            sendNumber = 0;
            sendCount.Text = "0";
            //接收计数置零
            receiveNumber = 0;
            receiveCount.Text = "0";
            tempBuilder = new List<string>();
        }


        /// <summary>
        /// 接收并保存到文件：接收以txt文件格式保存，文件名称包含当前时间戳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receive_save_file_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (receive_save_file_checkBox.Checked)
                {
                    string cacheData = rx_textarea.Text;//缓存数据
                    // 获取当前日期时间戳
                    string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");

                    // 创建 SaveFileDialog 对象
                    SaveFileDialog saveFileDialog = new SaveFileDialog();

                    // 设置文件筛选器，只能选择保存为 txt 格式的文件
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                    // 将当前时间戳添加到文件名中
                    saveFileDialog.FileName = "myFile_" + timestamp + ".txt";

                    // 如果用户选择了文件并单击了“保存”按钮
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // 获取选择的文件路径
                        filePaths = saveFileDialog.FileName;

                        // 创建 StreamWriter 对象并将字符串写入文件
                        using (writer = new StreamWriter(filePaths))
                        {
                            writer.Write(cacheData);
                        }
                    }
                }
                else
                {
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        /// <summary>
        /// CMD1-10按钮点击事件：用来设置并保存预定义的指令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CMD1_Click(object sender, EventArgs e)
        {
            string cmdButtonName = ((ControlAccessibleObject)((Control)sender).AccessibilityObject).Name;
            BaseMethod bm = new BaseMethod();
            string fileName = bm.GetAppCurrentPath("\\CommandConfig.ini");

            string fileContent = IniFile.GetINI("PRINT", cmdButtonName, "1", fileName);

            ConvertData(fileContent);
        }

        /// <summary>
        /// 16进制、文本转换
        /// </summary>
        /// <param name="fileContent"></param>
        private void ConvertData(string fileContent)
        {
            tx_textarea.Text = fileContent;
            //判断一个文本内容是否表示一个有效的十六进制值
            bool isHex = IsHexadecimalFormat(fileContent);
            if (send_hex_radiobutton.Checked && isHex)
            {
                //如果勾选了16进制，然后内容本身也是16进制，那么就不需要处理
            }
            else
            {
                //判断：勾选了16进制，但是内容不是16进制
                if (send_hex_radiobutton.Checked && !isHex)
                {
                    // 将文本转换为十六进制
                    string text = fileContent;
                    byte[] bytes = Encoding.ASCII.GetBytes(text);

                    StringBuilder hexBuilder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        hexBuilder.Append($"{b:X2} ");
                    }

                    string hexString = hexBuilder.ToString();

                    // 将十六进制字符串显示到文本框
                    tx_textarea.Text = hexString;
                }

                //判断：未勾选16进制，但是内容是16进制
                if (!send_hex_radiobutton.Checked && isHex)
                {
                    // 将十六进制转换为字符串
                    string hexString = fileContent.Replace(" ", ""); // 去除空格
                    byte[] bytes = new byte[hexString.Length / 2];
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    }

                    string text = Encoding.ASCII.GetString(bytes);

                    // 将字符串显示到文本框
                    tx_textarea.Text = text;
                }
            }
        }


        private static bool IsHexadecimalFormat(string input)
        {
            //判断内容是否包含空格
            if (input.Contains(" "))
            {
                //16进制
                foreach (char c in input)
                {
                    if (!IsHexadecimalCharacter(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                //非16进制
                return false;
            }
        }

        private static bool IsHexadecimalCharacter(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || (c.Equals(' '));
        }

        /// <summary>
        /// /* Close serial port when closing*/
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                    mySerial.Close();

                if (writer != null)
                    writer.Close();

                this.Dispose();//释放资源
                Application.Exit();

            }
            catch (Exception ex)
            {
            }
        }

        private void CMD1_MouseMove(object sender, MouseEventArgs e)
        {
            cmdButtonName = ((ControlAccessibleObject)((Control)sender).AccessibilityObject).Name;
        }

        private void ToolStripMenuItemEditCMD_Click(object sender, EventArgs e)
        {
            FormInstructionSettings instructionSettings = new FormInstructionSettings(cmdButtonName);
            instructionSettings.ShowDialog();
        }

        /// <summary>
        /// 选择文件按钮点击事件：解析csv或txt文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileParsing_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv|Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string content = reader.ReadToEnd();
                    fileContent.Text = content.Replace("，", ",");
                    filePath.Text = openFileDialog.FileName;
                }
            }
        }

        /// <summary>
        /// 复位计数按钮点击事件：接收、发送、循环次数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetCount_Click(object sender, EventArgs e)
        {
            cycleNumber.Enabled = true;
            radioOrderSend.Enabled = true;
            radioRandomSend.Enabled = true;
            //循环次数置零
            cycleNumber.Text = "0";
            //发送计数置零
            sendNumber = 0;
            sendCount.Text = "0";
            //接收计数置零
            receiveNumber = 0;
            receiveCount.Text = "0";
        }

        /// <summary>
        /// 执行按钮：执行发送操作，点击“执行”按钮后禁用“循环次数”、“顺序发送”、“随机发送”控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            send_fixedTime_radiobutton.Checked = false;//关闭定时发送

            if (string.IsNullOrEmpty(portConfig.Text))
            {
                alert("没有可用的端口");
                return;
            }

            file_send_flag = true;
            cycleNumber.Enabled = false;
            radioOrderSend.Enabled = false;
            radioRandomSend.Enabled = false;

            if (!isRunning)
            {
                isFlagSend = true;
                isRunning = true;
                // 创建新线程并开始循环
                loopThread = new Thread(LoopSend);
                loopThread.Start();
                
            }
            else if (isPaused)
            {
                // 继续循环
                isPaused = false;
            }
        }

        /// <summary>
        /// 暂停按钮：暂停当前发送操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuspend_Click(object sender, EventArgs e)
        {
            file_send_flag = true;
            if (string.IsNullOrEmpty(portConfig.Text))
            {
                alert("没有可用的端口");
                return;
            }

            if (isRunning && !isPaused)
            {
                // 暂停循环
                isPaused = true;
            }
            alert("循环未运行或已暂停");
        }

        /// <summary>
        /// 取消按钮：取消操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                send_data_flag = false;
                // 取消循环
                isCancelled = true;
                loopThread.Abort(); // 终止循环线程
                loopThread.Join(); // 等待循环线程结束
                isRunning = false;
                isPaused = false;
                isCancelled = false;
                alert("循环已取消或结束");
                file_send_flag = false;
            }
            isFlagSend = false;
            cycleNumber.Enabled = true;
            radioOrderSend.Enabled = true;
            radioRandomSend.Enabled = true;
        }

        string tempPart = "";
        private void LoopSend()
        {

            //命令1  （说明：初始化或者单一命令，仅执行一次）
            //命令2
            //“{{     （说明：双引号 + 大括号 * 2   “{{代表需要循环发送开始  ）
            //命令1  （说明：大括号内部命令，根据界面选择是否随机循序。是：随机抽取大括号内cmd命令发送 否：依次循环大括号内cmd命令发送）
            //命令2
            //命令3
            //命令4
            //命令5
            //}}”     （说明：大括号 * 2 + 双引号 }}”   代表需要循环发送结束  ）

            CommonHelper fileSendHelper = new CommonHelper();

            //循环次数：输入0为无限循环，>=1循环次数，不允许输入负数、小数、特殊符号 
            if (fileContent.Text.Contains("“{{") && fileContent.Text.Contains("}}”"))
            {

                string[] result = fileContent.Text.Split(new[] { "“{{" }, StringSplitOptions.None);

                int loopCount = Convert.ToInt32(cycleNumber.Value);
                if (loopCount == 0)
                {
                    //无限循环
                    while (true)
                    {

                        if (isCancelled)
                        {
                            // 取消循环
                            send_data_flag = false;
                            break;
                        }

                        if (isPaused)
                        {
                            // 循环暂停，等待继续信号
                            Thread.Sleep(100); // 避免忙等，降低 CPU 使用率
                            continue;
                        }


                        if (!string.IsNullOrEmpty(result[0]))
                        {
                            string[] parts = result[0].Split('\n');
                            foreach (string part in parts)
                            {

                                if (!string.IsNullOrEmpty(part.Trim()))
                                {
                                    tempPart = part.Replace("\r", "").Replace("\n", "");
                                    send_data_flag = false;
                                    Invoke(new Action(() => sendData.PerformClick()));
                                    //判断是否勾选定时发送
                                    if (send_fixedTime_radiobutton.Checked)
                                    {
                                        Thread.Sleep(Convert.ToInt32(send_delay.Value) * 1000);
                                    }
                                    else
                                    {
                                        Thread.Sleep(1000); //默认1秒
                                    }
                                }
                            }

                            result[0] = "";
                        }
                        else
                        {
                            string[] contentResult = result[1].Split(new[] { "}}”" }, StringSplitOptions.None);
                            string[] parts = contentResult[0].Split('\n');
                            //随机生成
                            if (radioRandomSend.Checked)
                            {
                                CommonHelper.ShuffleArray(parts);
                            }
                            foreach (string part in parts)
                            {
                                if (!string.IsNullOrEmpty(part.Trim()))
                                {
                                    tempPart = part.Replace("\r", "").Replace("\n", "");
                                    send_data_flag = false;
                                    Invoke(new Action(() => sendData.PerformClick()));
                                    //判断是否勾选定时发送
                                    if (send_fixedTime_radiobutton.Checked)
                                    {
                                        Thread.Sleep(Convert.ToInt32(send_delay.Value) * 1000);
                                    }
                                    else
                                    {
                                        Thread.Sleep(1000); //默认1秒
                                    }
                                }

                            }
                        }

                    }

                }
                else
                {
                    // 根据循环次数执行循环
                    for (int i = 0; i < loopCount; i++)
                    {
                        if (isCancelled)
                        {
                            // 取消循环
                            send_data_flag = false;
                            break;
                        }

                        if (isPaused)
                        {
                            // 循环暂停，等待继续信号
                            Thread.Sleep(100); // 避免忙等，降低 CPU 使用率
                            i--; // 保持循环次数不变
                            continue;
                        }


                        if (!string.IsNullOrEmpty(result[0]))
                        {

                            string[] parts = result[0].Split('\n');
                            foreach (string part in parts)
                            {

                                if (!string.IsNullOrEmpty(part.Trim()))
                                {
                                    tempPart = part.Replace("\r", "").Replace("\n", "");
                                    send_data_flag = false;
                                    Invoke(new Action(() => sendData.PerformClick()));
                                    //判断是否勾选定时发送
                                    if (send_fixedTime_radiobutton.Checked)
                                    {
                                        Thread.Sleep(Convert.ToInt32(send_delay.Value) * 1000);
                                    }
                                    else
                                    {
                                        Thread.Sleep(1000); //默认1秒
                                    }
                                }
                            }

                            result[0] = "";
                            // 重新开始循环
                            i = -1;
                            continue;
                        }
                        else
                        {
                            string[] contentResult = result[1].Split(new[] { "}}”" }, StringSplitOptions.None);
                            string[] parts = contentResult[0].Split('\n');
                            //随机生成
                            if (radioRandomSend.Checked)
                            {
                                CommonHelper.ShuffleArray(parts);
                            }
                            foreach (string part in parts)
                            {
                                if (!string.IsNullOrEmpty(part.Trim()))
                                {

                                    tempPart = part.Replace("\r", "").Replace("\n", "");
                                    send_data_flag = false;
                                    Invoke(new Action(() => sendData.PerformClick()));
                                    //判断是否勾选定时发送
                                    if (send_fixedTime_radiobutton.Checked)
                                    {
                                        Thread.Sleep(Convert.ToInt32(send_delay.Value) * 1000);
                                    }
                                    else
                                    {
                                        Thread.Sleep(1000); //默认1秒
                                    }
                                }

                            }

                        }

                    }
                }
            }
            else
            {
                alert("文本发送格式不正确！");
                return;
            }

            isLoop = true;
        }

        private void send_hex_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            ConvertData(tx_textarea.Text);
            
        }

        ChartSetting chartSetting = null;

        /// <summary>
        /// 图表设置：名称、字符、线宽、类型、颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChartSetting_Click(object sender, EventArgs e)
        {
            chartSetting = new ChartSetting(graph.Series);
            chartSetting.DataDeleted += ChildForm_DataDeleted;
            chartSetting.ShowDialog();


        }

        private void ChildForm_DataDeleted(object sender, EventArgs e)
        {
            // 在此处执行刷新操作，例如重新加载数据或更新显示
            AutoGraph(chartSetting);
        }

        private void AutoGraph(ChartSetting chartSetting)
        {
            graph.Series.Clear();

            SQLiteSamples sQLite = new SQLiteSamples();
            List<SysConfig> sysConfigs = sQLite.getAll();
            for (int i = 0; i < sysConfigs.Count; i++)
            {
                string name = sysConfigs[i].Name;
                string legendText = name;
                Series series = new Series(name);
                series.Legend = "Legend1";
                series.Name = name;
                series.BorderWidth = Convert.ToInt32(Convert.ToDouble(sysConfigs[i].LineDesc));
                series.LegendText = legendText;

                // 设置线图（Line）系列类型
                if (sysConfigs[i].TypeDesc.Equals("Line"))
                {
                    series.ChartType = SeriesChartType.Line;
                }

                // 设置点图（Dot）系列类型
                if (sysConfigs[i].TypeDesc.Equals("Dot"))
                {
                    series.ChartType = SeriesChartType.Point;
                }

                // 设置柱状图（Bar）系列类型
                if (sysConfigs[i].TypeDesc.Equals("Bar"))
                {
                    series.ChartType = SeriesChartType.Bar;
                }

                if (i == 0)
                {
                    series.YValuesPerPoint = 32;
                }
                else
                {
                    series.YValuesPerPoint = 1;
                }

                series.Color = ColorTranslator.FromHtml(sysConfigs[i].ColorDesc);
                // 添加数据点
                series.Points.AddXY(0, 0);
                series.Points.AddXY(0, 0);
                // 添加更多的数据点...

                // 将数据系列添加到图表中
                graph.Series.Add(series);
            }

            

        }

        private void btnStartAndPause_Click(object sender, EventArgs e)
        {
            if (plotter_flag)
            {
                plotter_flag = false;
                imageList1 = new ImageList();
                imageList1.Images.Add(Image.FromFile(Path.GetFullPath("images/开始.png")));
                btnStartAndPause.Text = "";
                btnStartAndPause.ImageList = imageList1;
                btnStartAndPause.ImageIndex = 0;
            }
            else
            {
                plotter_flag = true;
                imageList1 = new ImageList();
                imageList1.Images.Add(Image.FromFile(Path.GetFullPath("images/暂停.png")));
                btnStartAndPause.Text = "";
                btnStartAndPause.ImageList = imageList1;
                btnStartAndPause.ImageIndex = 0;
            }
        }

        /// <summary>
        /// 定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void send_fixedTime_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (send_fixedTime_radiobutton.Checked)
            {
                timer1.Interval = Convert.ToInt32(send_delay.Value) * 1000;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 在定时器触发时调用按钮方法
            // 如果文件发送已经点了执行按钮，那么就不调用发送按钮方法
            if (!file_send_flag)
            {
                Invoke(new Action(() => sendData.PerformClick()));
            }
        }

        
        private void display_hex_radiobutton_CheckedChanged(object sender, EventArgs e)
        {

            int index = 0;

            if (display_hex_radiobutton.Checked)
            {
                string content = rx_textarea.Text;
                string[] lines = content.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                // 构建新的文本
                StringBuilder outputBuilder = new StringBuilder();

                // 处理每一行

                foreach (string line in lines)
                {
                    
                    String values = " > ";
                    int colonIndex = line.IndexOf(values);
                    if (colonIndex >= 0)
                    {
                        string prefix = line.Substring(0, colonIndex + 3);
                        string value = line.Substring(colonIndex + 3).Trim();

                        bool isHex = IsHexadecimalFormat(value);
                        string hexString = "";
                        if (!isHex)
                        {
                            byte[] bytes = Encoding.ASCII.GetBytes(value);

                            StringBuilder hexBuilder = new StringBuilder();
                            foreach (byte b in bytes)
                            {
                                hexBuilder.Append($"{b:X2} ");
                            }
                            index += 1;
                            hexString = hexBuilder.ToString();
                            tempBuilder.Add(hexString + "钧"+ index + "雷" + value);
                        }
                        else
                        {
                            index += 1;
                            hexString = value;
                        }

                        // 构建新的行并添加到输出文本中
                        outputBuilder.AppendLine(prefix + hexString);
                    }
                }

                rx_textarea.Text = outputBuilder.ToString(); // 获取最终的输出文本
                rx_textarea.Font = new Font("Courier New", rx_textarea.Font.Size);

            }
            else
            {
                string content = rx_textarea.Text;
                string[] lines = content.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                // 构建新的文本
                StringBuilder outputBuilder = new StringBuilder();

                int index2 = 0;
                // 处理每一行
                foreach (string line in lines)
                {
                    
                    String values = " > ";
                    int colonIndex = line.IndexOf(values);
                    if (colonIndex >= 0)
                    {
                        string prefix = line.Substring(0, colonIndex + 3);
                        string value = line.Substring(colonIndex + 3).Trim();

                        bool isHex = IsHexadecimalFormat(value);
                        string textString = "";
                        if (!isHex)
                        {
                            index2 += 1;
                            textString = value;
                        }
                        else
                        {

                            index2 += 1;
                            textString = value;
                            foreach (string temp in tempBuilder)
                            {
                                string tempValue = value + " 钧"+ index2 + "雷";//包含空格
                                if (temp.Contains(tempValue))
                                {
                                    textString = temp.Split('雷')[1];
                                }
                            }
                            
                        }

                        // 构建新的行并添加到输出文本中
                        outputBuilder.AppendLine(prefix + textString);
                    }
                }

                rx_textarea.Text = outputBuilder.ToString(); // 获取最终的输出文本
                rx_textarea.Font = new Font("Courier New", rx_textarea.Font.Size);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //循环结束后点击“执行”按钮可重新进行循环 = 调用取消按钮事件
            if (isLoop)
            {
                isRunning = true;
                
                //重置
                isLoop = false;
                //调用取消按钮事件
                Invoke(new Action(() => btnCancel.PerformClick()));

                isRunning = false;
            }
        }


    }
}















