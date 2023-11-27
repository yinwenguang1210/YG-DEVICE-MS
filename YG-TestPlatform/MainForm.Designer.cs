namespace YG_TestPlatform
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.connect = new System.Windows.Forms.Button();
            this.portConfig = new System.Windows.Forms.ComboBox();
            this.baudrateConfig = new System.Windows.Forms.ComboBox();
            this.databitsConfig = new System.Windows.Forms.ComboBox();
            this.stopbitsConfig = new System.Windows.Forms.ComboBox();
            this.parityConfig = new System.Windows.Forms.ComboBox();
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.serial_options_group = new System.Windows.Forms.GroupBox();
            this.flowconrol_label = new System.Windows.Forms.Label();
            this.baudrate_label = new System.Windows.Forms.Label();
            this.flowcontrolConfig = new System.Windows.Forms.ComboBox();
            this.parity_label = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.stopbits_label = new System.Windows.Forms.Label();
            this.databits_label = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.byte_counter_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rx_textarea = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.plotter_option_group = new System.Windows.Forms.GroupBox();
            this.btnStartAndPause = new System.Windows.Forms.Button();
            this.BtnChartSetting = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemEditCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.graph_max = new System.Windows.Forms.NumericUpDown();
            this.set_graph_min_enable = new System.Windows.Forms.CheckBox();
            this.graph_min = new System.Windows.Forms.NumericUpDown();
            this.set_graph_max_enable = new System.Windows.Forms.CheckBox();
            this.graph_scale = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.graph_speed = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.cycleNumber = new System.Windows.Forms.NumericUpDown();
            this.fileContent = new System.Windows.Forms.TextBox();
            this.fileParsing = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioRandomSend = new System.Windows.Forms.RadioButton();
            this.radioOrderSend = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.receiveCount = new System.Windows.Forms.Label();
            this.resetCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.read_options_group = new System.Windows.Forms.GroupBox();
            this.display_stop_radiobutton = new System.Windows.Forms.CheckBox();
            this.display_hex_radiobutton = new System.Windows.Forms.CheckBox();
            this.receive_save_file_checkBox = new System.Windows.Forms.CheckBox();
            this.saveData = new System.Windows.Forms.Label();
            this.clearData = new System.Windows.Forms.Label();
            this.tx_num_panel = new System.Windows.Forms.Panel();
            this.send_delay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.sendData = new System.Windows.Forms.Button();
            this.tx_textarea = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tx_repeater_delay = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.alert_messege = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CMD10 = new System.Windows.Forms.Button();
            this.CMD9 = new System.Windows.Forms.Button();
            this.CMD8 = new System.Windows.Forms.Button();
            this.CMD7 = new System.Windows.Forms.Button();
            this.CMD6 = new System.Windows.Forms.Button();
            this.CMD5 = new System.Windows.Forms.Button();
            this.CMD4 = new System.Windows.Forms.Button();
            this.CMD3 = new System.Windows.Forms.Button();
            this.CMD2 = new System.Windows.Forms.Button();
            this.CMD1 = new System.Windows.Forms.Button();
            this.send_hex_radiobutton = new System.Windows.Forms.CheckBox();
            this.send_fixedTime_radiobutton = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxCRC16 = new System.Windows.Forms.CheckBox();
            this.serial_options_group.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.plotter_option_group.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.graph_menu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycleNumber)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.read_options_group.SuspendLayout();
            this.tx_num_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_delay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connect.Location = new System.Drawing.Point(16, 267);
            this.connect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(252, 46);
            this.connect.TabIndex = 0;
            this.connect.Text = "打开串口";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // portConfig
            // 
            this.portConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portConfig.FormattingEnabled = true;
            this.portConfig.Location = new System.Drawing.Point(88, 39);
            this.portConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.portConfig.Name = "portConfig";
            this.portConfig.Size = new System.Drawing.Size(180, 28);
            this.portConfig.TabIndex = 1;
            this.portConfig.Click += new System.EventHandler(this.portConfig_Click);
            // 
            // baudrateConfig
            // 
            this.baudrateConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateConfig.FormattingEnabled = true;
            this.baudrateConfig.Location = new System.Drawing.Point(88, 77);
            this.baudrateConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.baudrateConfig.Name = "baudrateConfig";
            this.baudrateConfig.Size = new System.Drawing.Size(180, 28);
            this.baudrateConfig.TabIndex = 2;
            // 
            // databitsConfig
            // 
            this.databitsConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitsConfig.FormattingEnabled = true;
            this.databitsConfig.Location = new System.Drawing.Point(88, 114);
            this.databitsConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.databitsConfig.Name = "databitsConfig";
            this.databitsConfig.Size = new System.Drawing.Size(180, 28);
            this.databitsConfig.TabIndex = 3;
            // 
            // stopbitsConfig
            // 
            this.stopbitsConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.stopbitsConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbitsConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stopbitsConfig.FormattingEnabled = true;
            this.stopbitsConfig.Location = new System.Drawing.Point(88, 152);
            this.stopbitsConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stopbitsConfig.Name = "stopbitsConfig";
            this.stopbitsConfig.Size = new System.Drawing.Size(180, 28);
            this.stopbitsConfig.TabIndex = 4;
            // 
            // parityConfig
            // 
            this.parityConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityConfig.FormattingEnabled = true;
            this.parityConfig.Location = new System.Drawing.Point(88, 189);
            this.parityConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.parityConfig.Name = "parityConfig";
            this.parityConfig.Size = new System.Drawing.Size(180, 28);
            this.parityConfig.TabIndex = 5;
            // 
            // serial_options_group
            // 
            this.serial_options_group.Controls.Add(this.flowconrol_label);
            this.serial_options_group.Controls.Add(this.baudrate_label);
            this.serial_options_group.Controls.Add(this.flowcontrolConfig);
            this.serial_options_group.Controls.Add(this.parity_label);
            this.serial_options_group.Controls.Add(this.connect);
            this.serial_options_group.Controls.Add(this.port_label);
            this.serial_options_group.Controls.Add(this.portConfig);
            this.serial_options_group.Controls.Add(this.baudrateConfig);
            this.serial_options_group.Controls.Add(this.parityConfig);
            this.serial_options_group.Controls.Add(this.stopbitsConfig);
            this.serial_options_group.Controls.Add(this.stopbits_label);
            this.serial_options_group.Controls.Add(this.databitsConfig);
            this.serial_options_group.Controls.Add(this.databits_label);
            this.serial_options_group.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serial_options_group.Location = new System.Drawing.Point(19, 23);
            this.serial_options_group.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serial_options_group.Name = "serial_options_group";
            this.serial_options_group.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serial_options_group.Size = new System.Drawing.Size(295, 332);
            this.serial_options_group.TabIndex = 9;
            this.serial_options_group.TabStop = false;
            this.serial_options_group.Text = "串口设置";
            // 
            // flowconrol_label
            // 
            this.flowconrol_label.AutoSize = true;
            this.flowconrol_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowconrol_label.Location = new System.Drawing.Point(13, 230);
            this.flowconrol_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flowconrol_label.Name = "flowconrol_label";
            this.flowconrol_label.Size = new System.Drawing.Size(69, 20);
            this.flowconrol_label.TabIndex = 13;
            this.flowconrol_label.Text = "流控制：";
            // 
            // baudrate_label
            // 
            this.baudrate_label.AutoSize = true;
            this.baudrate_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baudrate_label.Location = new System.Drawing.Point(13, 80);
            this.baudrate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baudrate_label.Name = "baudrate_label";
            this.baudrate_label.Size = new System.Drawing.Size(69, 20);
            this.baudrate_label.TabIndex = 8;
            this.baudrate_label.Text = "波特率：";
            // 
            // flowcontrolConfig
            // 
            this.flowcontrolConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowcontrolConfig.FormattingEnabled = true;
            this.flowcontrolConfig.Location = new System.Drawing.Point(88, 227);
            this.flowcontrolConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowcontrolConfig.Name = "flowcontrolConfig";
            this.flowcontrolConfig.Size = new System.Drawing.Size(180, 28);
            this.flowcontrolConfig.TabIndex = 12;
            // 
            // parity_label
            // 
            this.parity_label.AutoSize = true;
            this.parity_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parity_label.Location = new System.Drawing.Point(13, 192);
            this.parity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parity_label.Name = "parity_label";
            this.parity_label.Size = new System.Drawing.Size(69, 20);
            this.parity_label.TabIndex = 11;
            this.parity_label.Text = "校验位：";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.port_label.Location = new System.Drawing.Point(13, 43);
            this.port_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(69, 20);
            this.port_label.TabIndex = 7;
            this.port_label.Text = "串口号：";
            // 
            // stopbits_label
            // 
            this.stopbits_label.AutoSize = true;
            this.stopbits_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopbits_label.Location = new System.Drawing.Point(13, 155);
            this.stopbits_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stopbits_label.Name = "stopbits_label";
            this.stopbits_label.Size = new System.Drawing.Size(69, 20);
            this.stopbits_label.TabIndex = 10;
            this.stopbits_label.Text = "停止位：";
            // 
            // databits_label
            // 
            this.databits_label.AutoSize = true;
            this.databits_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.databits_label.Location = new System.Drawing.Point(13, 117);
            this.databits_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databits_label.Name = "databits_label";
            this.databits_label.Size = new System.Drawing.Size(69, 20);
            this.databits_label.TabIndex = 9;
            this.databits_label.Text = "数据位：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byte_counter_label,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 682);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(759, 29);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1924, 29);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // byte_counter_label
            // 
            this.byte_counter_label.Name = "byte_counter_label";
            this.byte_counter_label.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(6, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 24);
            this.toolStripStatusLabel1.Text = "无连接";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(344, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1578, 521);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.rx_textarea);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1570, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文本模式";
            // 
            // rx_textarea
            // 
            this.rx_textarea.BackColor = System.Drawing.Color.White;
            this.rx_textarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rx_textarea.ContextMenuStrip = this.contextMenuStrip1;
            this.rx_textarea.DetectUrls = false;
            this.rx_textarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rx_textarea.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rx_textarea.HideSelection = false;
            this.rx_textarea.Location = new System.Drawing.Point(4, 3);
            this.rx_textarea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rx_textarea.Name = "rx_textarea";
            this.rx_textarea.Size = new System.Drawing.Size(1562, 482);
            this.rx_textarea.TabIndex = 29;
            this.rx_textarea.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 28);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clear_rx_textarea_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage2.Controls.Add(this.plotter_option_group);
            this.tabPage2.Controls.Add(this.graph);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1570, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图形模式";
            // 
            // plotter_option_group
            // 
            this.plotter_option_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotter_option_group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plotter_option_group.Controls.Add(this.btnStartAndPause);
            this.plotter_option_group.Controls.Add(this.BtnChartSetting);
            this.plotter_option_group.Controls.Add(this.graph_max);
            this.plotter_option_group.Controls.Add(this.set_graph_min_enable);
            this.plotter_option_group.Controls.Add(this.graph_min);
            this.plotter_option_group.Controls.Add(this.set_graph_max_enable);
            this.plotter_option_group.Controls.Add(this.graph_scale);
            this.plotter_option_group.Controls.Add(this.label3);
            this.plotter_option_group.Controls.Add(this.graph_speed);
            this.plotter_option_group.Controls.Add(this.label7);
            this.plotter_option_group.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plotter_option_group.Location = new System.Drawing.Point(12, 14);
            this.plotter_option_group.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotter_option_group.Name = "plotter_option_group";
            this.plotter_option_group.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plotter_option_group.Size = new System.Drawing.Size(1541, 74);
            this.plotter_option_group.TabIndex = 25;
            this.plotter_option_group.TabStop = false;
            // 
            // btnStartAndPause
            // 
            this.btnStartAndPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartAndPause.Location = new System.Drawing.Point(1358, 25);
            this.btnStartAndPause.Name = "btnStartAndPause";
            this.btnStartAndPause.Size = new System.Drawing.Size(38, 38);
            this.btnStartAndPause.TabIndex = 35;
            this.btnStartAndPause.Text = "暂";
            this.btnStartAndPause.UseVisualStyleBackColor = true;
            this.btnStartAndPause.Click += new System.EventHandler(this.btnStartAndPause_Click);
            // 
            // BtnChartSetting
            // 
            this.BtnChartSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChartSetting.ContextMenuStrip = this.contextMenuStrip3;
            this.BtnChartSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnChartSetting.Location = new System.Drawing.Point(1408, 25);
            this.BtnChartSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnChartSetting.Name = "BtnChartSetting";
            this.BtnChartSetting.Size = new System.Drawing.Size(117, 38);
            this.BtnChartSetting.TabIndex = 34;
            this.BtnChartSetting.Text = "设置";
            this.BtnChartSetting.UseVisualStyleBackColor = true;
            this.BtnChartSetting.Click += new System.EventHandler(this.BtnChartSetting_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEditCMD});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(139, 28);
            // 
            // ToolStripMenuItemEditCMD
            // 
            this.ToolStripMenuItemEditCMD.Name = "ToolStripMenuItemEditCMD";
            this.ToolStripMenuItemEditCMD.Size = new System.Drawing.Size(138, 24);
            this.ToolStripMenuItemEditCMD.Text = "编辑指令";
            this.ToolStripMenuItemEditCMD.Click += new System.EventHandler(this.ToolStripMenuItemEditCMD_Click);
            // 
            // graph_max
            // 
            this.graph_max.AutoSize = true;
            this.graph_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_max.Enabled = false;
            this.graph_max.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_max.Location = new System.Drawing.Point(113, 32);
            this.graph_max.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graph_max.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.graph_max.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.graph_max.Name = "graph_max";
            this.graph_max.Size = new System.Drawing.Size(100, 27);
            this.graph_max.TabIndex = 28;
            this.graph_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.graph_max.ValueChanged += new System.EventHandler(this.graph_max_ValueChanged);
            // 
            // set_graph_min_enable
            // 
            this.set_graph_min_enable.AutoSize = true;
            this.set_graph_min_enable.Location = new System.Drawing.Point(300, 35);
            this.set_graph_min_enable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.set_graph_min_enable.Name = "set_graph_min_enable";
            this.set_graph_min_enable.Size = new System.Drawing.Size(80, 24);
            this.set_graph_min_enable.TabIndex = 27;
            this.set_graph_min_enable.Text = "最小值:";
            this.set_graph_min_enable.UseVisualStyleBackColor = true;
            this.set_graph_min_enable.CheckedChanged += new System.EventHandler(this.set_graph_min_enable_CheckedChanged);
            // 
            // graph_min
            // 
            this.graph_min.AutoSize = true;
            this.graph_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_min.Enabled = false;
            this.graph_min.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_min.Location = new System.Drawing.Point(390, 32);
            this.graph_min.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graph_min.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.graph_min.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.graph_min.Name = "graph_min";
            this.graph_min.Size = new System.Drawing.Size(100, 27);
            this.graph_min.TabIndex = 26;
            this.graph_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_min.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.graph_min.ValueChanged += new System.EventHandler(this.graph_min_ValueChanged);
            // 
            // set_graph_max_enable
            // 
            this.set_graph_max_enable.AutoSize = true;
            this.set_graph_max_enable.Location = new System.Drawing.Point(22, 35);
            this.set_graph_max_enable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.set_graph_max_enable.Name = "set_graph_max_enable";
            this.set_graph_max_enable.Size = new System.Drawing.Size(80, 24);
            this.set_graph_max_enable.TabIndex = 25;
            this.set_graph_max_enable.Text = "最大值:";
            this.set_graph_max_enable.UseVisualStyleBackColor = true;
            this.set_graph_max_enable.CheckedChanged += new System.EventHandler(this.set_graph_max_enable_CheckedChanged);
            // 
            // graph_scale
            // 
            this.graph_scale.AutoSize = true;
            this.graph_scale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_scale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_scale.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.graph_scale.Location = new System.Drawing.Point(652, 32);
            this.graph_scale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graph_scale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.graph_scale.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.graph_scale.Name = "graph_scale";
            this.graph_scale.Size = new System.Drawing.Size(89, 27);
            this.graph_scale.TabIndex = 19;
            this.graph_scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_scale.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.graph_scale.ValueChanged += new System.EventHandler(this.graph_scale_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Points:";
            // 
            // graph_speed
            // 
            this.graph_speed.AllowDrop = true;
            this.graph_speed.AutoSize = true;
            this.graph_speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_speed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_speed.Location = new System.Drawing.Point(920, 32);
            this.graph_speed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graph_speed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.graph_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graph_speed.Name = "graph_speed";
            this.graph_speed.Size = new System.Drawing.Size(89, 27);
            this.graph_speed.TabIndex = 17;
            this.graph_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graph_speed.ValueChanged += new System.EventHandler(this.graph_speed_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(840, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Interval:";
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph.BorderlineWidth = 0;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BorderColor = System.Drawing.Color.Maroon;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.ContextMenuStrip = this.graph_menu;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(12, 95);
            this.graph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(1555, 365);
            this.graph.TabIndex = 16;
            this.graph.Text = "chart2";
            // 
            // graph_menu
            // 
            this.graph_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.graph_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsImageToolStripMenuItem,
            this.clearToolStripMenuItem1});
            this.graph_menu.Name = "clear_graph";
            this.graph_menu.Size = new System.Drawing.Size(181, 52);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saveAsImageToolStripMenuItem.Text = "Save as image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clear_graph_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.ImageIndex = 1;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1570, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "文件发送";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cycleNumber);
            this.panel1.Controls.Add(this.fileContent);
            this.panel1.Controls.Add(this.fileParsing);
            this.panel1.Controls.Add(this.filePath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioRandomSend);
            this.panel1.Controls.Add(this.radioOrderSend);
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 481);
            this.panel1.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExecute);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSuspend);
            this.groupBox1.Location = new System.Drawing.Point(13, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1544, 62);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(15, 17);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(117, 38);
            this.btnExecute.TabIndex = 36;
            this.btnExecute.Text = "执行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1421, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 38);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSuspend
            // 
            this.btnSuspend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuspend.Location = new System.Drawing.Point(671, 17);
            this.btnSuspend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(117, 38);
            this.btnSuspend.TabIndex = 37;
            this.btnSuspend.Text = "暂停";
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // cycleNumber
            // 
            this.cycleNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cycleNumber.Location = new System.Drawing.Point(1482, 12);
            this.cycleNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cycleNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cycleNumber.Name = "cycleNumber";
            this.cycleNumber.Size = new System.Drawing.Size(71, 27);
            this.cycleNumber.TabIndex = 42;
            this.cycleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cycleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fileContent
            // 
            this.fileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileContent.Enabled = false;
            this.fileContent.Location = new System.Drawing.Point(12, 102);
            this.fileContent.Multiline = true;
            this.fileContent.Name = "fileContent";
            this.fileContent.Size = new System.Drawing.Size(1546, 302);
            this.fileContent.TabIndex = 35;
            // 
            // fileParsing
            // 
            this.fileParsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileParsing.Location = new System.Drawing.Point(1435, 53);
            this.fileParsing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fileParsing.Name = "fileParsing";
            this.fileParsing.Size = new System.Drawing.Size(117, 38);
            this.fileParsing.TabIndex = 34;
            this.fileParsing.Text = "选择文件";
            this.fileParsing.UseVisualStyleBackColor = true;
            this.fileParsing.Click += new System.EventHandler(this.fileParsing_Click);
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.Location = new System.Drawing.Point(12, 54);
            this.filePath.Multiline = true;
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(1387, 38);
            this.filePath.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1377, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "循环次数：";
            // 
            // radioRandomSend
            // 
            this.radioRandomSend.AutoSize = true;
            this.radioRandomSend.Location = new System.Drawing.Point(152, 17);
            this.radioRandomSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioRandomSend.Name = "radioRandomSend";
            this.radioRandomSend.Size = new System.Drawing.Size(90, 24);
            this.radioRandomSend.TabIndex = 19;
            this.radioRandomSend.Text = "随机发送";
            this.radioRandomSend.UseVisualStyleBackColor = true;
            // 
            // radioOrderSend
            // 
            this.radioOrderSend.AutoSize = true;
            this.radioOrderSend.Checked = true;
            this.radioOrderSend.Location = new System.Drawing.Point(12, 17);
            this.radioOrderSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioOrderSend.Name = "radioOrderSend";
            this.radioOrderSend.Size = new System.Drawing.Size(90, 24);
            this.radioOrderSend.TabIndex = 18;
            this.radioOrderSend.TabStop = true;
            this.radioOrderSend.Text = "顺序发送";
            this.radioOrderSend.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "字体.png");
            this.imageList1.Images.SetKeyName(1, "文件.png");
            this.imageList1.Images.SetKeyName(2, "图形.png");
            // 
            // receiveCount
            // 
            this.receiveCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.receiveCount.AutoSize = true;
            this.receiveCount.Location = new System.Drawing.Point(750, 125);
            this.receiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.receiveCount.Name = "receiveCount";
            this.receiveCount.Size = new System.Drawing.Size(18, 20);
            this.receiveCount.TabIndex = 44;
            this.receiveCount.Text = "0";
            // 
            // resetCount
            // 
            this.resetCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetCount.AutoSize = true;
            this.resetCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resetCount.Location = new System.Drawing.Point(1210, 125);
            this.resetCount.Name = "resetCount";
            this.resetCount.Size = new System.Drawing.Size(69, 20);
            this.resetCount.TabIndex = 41;
            this.resetCount.Text = "复位计数";
            this.resetCount.Click += new System.EventHandler(this.resetCount_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "发送：";
            // 
            // sendCount
            // 
            this.sendCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendCount.AutoSize = true;
            this.sendCount.Location = new System.Drawing.Point(94, 125);
            this.sendCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sendCount.Name = "sendCount";
            this.sendCount.Size = new System.Drawing.Size(18, 20);
            this.sendCount.TabIndex = 43;
            this.sendCount.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "接收：";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(116, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.toolStripMenuItem1.Text = "Clear";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // read_options_group
            // 
            this.read_options_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.read_options_group.Controls.Add(this.display_stop_radiobutton);
            this.read_options_group.Controls.Add(this.display_hex_radiobutton);
            this.read_options_group.Controls.Add(this.receive_save_file_checkBox);
            this.read_options_group.Controls.Add(this.saveData);
            this.read_options_group.Controls.Add(this.clearData);
            this.read_options_group.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.read_options_group.Location = new System.Drawing.Point(19, 367);
            this.read_options_group.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.read_options_group.Name = "read_options_group";
            this.read_options_group.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.read_options_group.Size = new System.Drawing.Size(295, 152);
            this.read_options_group.TabIndex = 26;
            this.read_options_group.TabStop = false;
            this.read_options_group.Text = "接收区设置";
            // 
            // display_stop_radiobutton
            // 
            this.display_stop_radiobutton.AutoSize = true;
            this.display_stop_radiobutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.display_stop_radiobutton.Location = new System.Drawing.Point(30, 89);
            this.display_stop_radiobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display_stop_radiobutton.Name = "display_stop_radiobutton";
            this.display_stop_radiobutton.Size = new System.Drawing.Size(121, 24);
            this.display_stop_radiobutton.TabIndex = 30;
            this.display_stop_radiobutton.Text = "暂停接收显示";
            this.display_stop_radiobutton.UseVisualStyleBackColor = true;
            // 
            // display_hex_radiobutton
            // 
            this.display_hex_radiobutton.AutoSize = true;
            this.display_hex_radiobutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.display_hex_radiobutton.Location = new System.Drawing.Point(30, 57);
            this.display_hex_radiobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display_hex_radiobutton.Name = "display_hex_radiobutton";
            this.display_hex_radiobutton.Size = new System.Drawing.Size(121, 24);
            this.display_hex_radiobutton.TabIndex = 29;
            this.display_hex_radiobutton.Text = "十六进制显示";
            this.display_hex_radiobutton.UseVisualStyleBackColor = true;
            this.display_hex_radiobutton.CheckedChanged += new System.EventHandler(this.display_hex_radiobutton_CheckedChanged);
            // 
            // receive_save_file_checkBox
            // 
            this.receive_save_file_checkBox.AutoSize = true;
            this.receive_save_file_checkBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receive_save_file_checkBox.Location = new System.Drawing.Point(30, 25);
            this.receive_save_file_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receive_save_file_checkBox.Name = "receive_save_file_checkBox";
            this.receive_save_file_checkBox.Size = new System.Drawing.Size(151, 24);
            this.receive_save_file_checkBox.TabIndex = 28;
            this.receive_save_file_checkBox.Text = "接收并保存到文件";
            this.receive_save_file_checkBox.UseVisualStyleBackColor = true;
            this.receive_save_file_checkBox.CheckedChanged += new System.EventHandler(this.receive_save_file_checkBox_CheckedChanged);
            // 
            // saveData
            // 
            this.saveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveData.AutoSize = true;
            this.saveData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.saveData.Location = new System.Drawing.Point(13, 123);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(69, 20);
            this.saveData.TabIndex = 27;
            this.saveData.Text = "保存数据";
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // clearData
            // 
            this.clearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearData.AutoSize = true;
            this.clearData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearData.Location = new System.Drawing.Point(196, 123);
            this.clearData.Name = "clearData";
            this.clearData.Size = new System.Drawing.Size(69, 20);
            this.clearData.TabIndex = 26;
            this.clearData.Text = "清空数据";
            this.clearData.Click += new System.EventHandler(this.clearData_Click);
            // 
            // tx_num_panel
            // 
            this.tx_num_panel.Controls.Add(this.send_delay);
            this.tx_num_panel.Controls.Add(this.label2);
            this.tx_num_panel.Location = new System.Drawing.Point(141, 29);
            this.tx_num_panel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tx_num_panel.Name = "tx_num_panel";
            this.tx_num_panel.Size = new System.Drawing.Size(127, 39);
            this.tx_num_panel.TabIndex = 31;
            // 
            // send_delay
            // 
            this.send_delay.Location = new System.Drawing.Point(13, 6);
            this.send_delay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.send_delay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.send_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.send_delay.Name = "send_delay";
            this.send_delay.Size = new System.Drawing.Size(71, 27);
            this.send_delay.TabIndex = 21;
            this.send_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.send_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "秒";
            // 
            // sendData
            // 
            this.sendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendData.Location = new System.Drawing.Point(1340, 16);
            this.sendData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(219, 105);
            this.sendData.TabIndex = 13;
            this.sendData.Text = "发送";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // tx_textarea
            // 
            this.tx_textarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tx_textarea.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_textarea.Location = new System.Drawing.Point(17, 59);
            this.tx_textarea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tx_textarea.Multiline = true;
            this.tx_textarea.Name = "tx_textarea";
            this.tx_textarea.Size = new System.Drawing.Size(1283, 62);
            this.tx_textarea.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "log_file";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "figure";
            this.saveFileDialog1.Filter = "PNG|.png| JPEG|.jpg";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // alert_messege
            // 
            this.alert_messege.Text = "notifyIcon1";
            this.alert_messege.Visible = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.resetCount);
            this.groupBox2.Controls.Add(this.receiveCount);
            this.groupBox2.Controls.Add(this.CMD10);
            this.groupBox2.Controls.Add(this.CMD9);
            this.groupBox2.Controls.Add(this.CMD8);
            this.groupBox2.Controls.Add(this.CMD7);
            this.groupBox2.Controls.Add(this.CMD6);
            this.groupBox2.Controls.Add(this.CMD5);
            this.groupBox2.Controls.Add(this.CMD4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sendCount);
            this.groupBox2.Controls.Add(this.CMD3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CMD2);
            this.groupBox2.Controls.Add(this.CMD1);
            this.groupBox2.Controls.Add(this.sendData);
            this.groupBox2.Controls.Add(this.tx_textarea);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(344, 529);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1578, 149);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // CMD10
            // 
            this.CMD10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD10.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD10.Location = new System.Drawing.Point(1185, 16);
            this.CMD10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD10.Name = "CMD10";
            this.CMD10.Size = new System.Drawing.Size(117, 38);
            this.CMD10.TabIndex = 42;
            this.CMD10.Text = "CMD10";
            this.CMD10.UseVisualStyleBackColor = true;
            this.CMD10.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD9
            // 
            this.CMD9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD9.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD9.Location = new System.Drawing.Point(1056, 16);
            this.CMD9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD9.Name = "CMD9";
            this.CMD9.Size = new System.Drawing.Size(117, 38);
            this.CMD9.TabIndex = 41;
            this.CMD9.Text = "CMD9";
            this.CMD9.UseVisualStyleBackColor = true;
            this.CMD9.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD8
            // 
            this.CMD8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD8.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD8.Location = new System.Drawing.Point(926, 16);
            this.CMD8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD8.Name = "CMD8";
            this.CMD8.Size = new System.Drawing.Size(117, 38);
            this.CMD8.TabIndex = 40;
            this.CMD8.Text = "CMD8";
            this.CMD8.UseVisualStyleBackColor = true;
            this.CMD8.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD7
            // 
            this.CMD7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD7.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD7.Location = new System.Drawing.Point(796, 16);
            this.CMD7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD7.Name = "CMD7";
            this.CMD7.Size = new System.Drawing.Size(117, 38);
            this.CMD7.TabIndex = 39;
            this.CMD7.Text = "CMD7";
            this.CMD7.UseVisualStyleBackColor = true;
            this.CMD7.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD6
            // 
            this.CMD6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD6.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD6.Location = new System.Drawing.Point(666, 16);
            this.CMD6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD6.Name = "CMD6";
            this.CMD6.Size = new System.Drawing.Size(117, 38);
            this.CMD6.TabIndex = 38;
            this.CMD6.Text = "CMD6";
            this.CMD6.UseVisualStyleBackColor = true;
            this.CMD6.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD5
            // 
            this.CMD5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD5.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD5.Location = new System.Drawing.Point(537, 16);
            this.CMD5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD5.Name = "CMD5";
            this.CMD5.Size = new System.Drawing.Size(117, 38);
            this.CMD5.TabIndex = 37;
            this.CMD5.Text = "CMD5";
            this.CMD5.UseVisualStyleBackColor = true;
            this.CMD5.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD4
            // 
            this.CMD4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD4.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD4.Location = new System.Drawing.Point(407, 16);
            this.CMD4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD4.Name = "CMD4";
            this.CMD4.Size = new System.Drawing.Size(117, 38);
            this.CMD4.TabIndex = 36;
            this.CMD4.Text = "CMD4";
            this.CMD4.UseVisualStyleBackColor = true;
            this.CMD4.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD3
            // 
            this.CMD3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD3.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD3.Location = new System.Drawing.Point(277, 16);
            this.CMD3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD3.Name = "CMD3";
            this.CMD3.Size = new System.Drawing.Size(117, 38);
            this.CMD3.TabIndex = 35;
            this.CMD3.Text = "CMD3";
            this.CMD3.UseVisualStyleBackColor = true;
            this.CMD3.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD2
            // 
            this.CMD2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD2.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD2.Location = new System.Drawing.Point(147, 16);
            this.CMD2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD2.Name = "CMD2";
            this.CMD2.Size = new System.Drawing.Size(117, 38);
            this.CMD2.TabIndex = 34;
            this.CMD2.Text = "CMD2";
            this.CMD2.UseVisualStyleBackColor = true;
            this.CMD2.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // CMD1
            // 
            this.CMD1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMD1.ContextMenuStrip = this.contextMenuStrip3;
            this.CMD1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMD1.Location = new System.Drawing.Point(17, 16);
            this.CMD1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMD1.Name = "CMD1";
            this.CMD1.Size = new System.Drawing.Size(117, 38);
            this.CMD1.TabIndex = 33;
            this.CMD1.Text = "CMD1";
            this.CMD1.UseVisualStyleBackColor = true;
            this.CMD1.Click += new System.EventHandler(this.CMD1_Click);
            this.CMD1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CMD1_MouseMove);
            // 
            // send_hex_radiobutton
            // 
            this.send_hex_radiobutton.AutoSize = true;
            this.send_hex_radiobutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send_hex_radiobutton.Location = new System.Drawing.Point(30, 73);
            this.send_hex_radiobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send_hex_radiobutton.Name = "send_hex_radiobutton";
            this.send_hex_radiobutton.Size = new System.Drawing.Size(121, 24);
            this.send_hex_radiobutton.TabIndex = 32;
            this.send_hex_radiobutton.Text = "十六进制发送";
            this.send_hex_radiobutton.UseVisualStyleBackColor = true;
            this.send_hex_radiobutton.CheckedChanged += new System.EventHandler(this.send_hex_radiobutton_CheckedChanged);
            // 
            // send_fixedTime_radiobutton
            // 
            this.send_fixedTime_radiobutton.AutoSize = true;
            this.send_fixedTime_radiobutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send_fixedTime_radiobutton.Location = new System.Drawing.Point(30, 41);
            this.send_fixedTime_radiobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send_fixedTime_radiobutton.Name = "send_fixedTime_radiobutton";
            this.send_fixedTime_radiobutton.Size = new System.Drawing.Size(91, 24);
            this.send_fixedTime_radiobutton.TabIndex = 31;
            this.send_fixedTime_radiobutton.Text = "定时发送";
            this.send_fixedTime_radiobutton.UseVisualStyleBackColor = true;
            this.send_fixedTime_radiobutton.CheckedChanged += new System.EventHandler(this.send_fixedTime_radiobutton_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.checkBoxCRC16);
            this.groupBox3.Controls.Add(this.send_hex_radiobutton);
            this.groupBox3.Controls.Add(this.tx_num_panel);
            this.groupBox3.Controls.Add(this.send_fixedTime_radiobutton);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox3.Location = new System.Drawing.Point(19, 529);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 149);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送区设置";
            // 
            // checkBoxCRC16
            // 
            this.checkBoxCRC16.AutoSize = true;
            this.checkBoxCRC16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxCRC16.Location = new System.Drawing.Point(30, 110);
            this.checkBoxCRC16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCRC16.Name = "checkBoxCRC16";
            this.checkBoxCRC16.Size = new System.Drawing.Size(146, 24);
            this.checkBoxCRC16.TabIndex = 33;
            this.checkBoxCRC16.Text = "CRC16-Modbus";
            this.checkBoxCRC16.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1924, 711);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.read_options_group);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.serial_options_group);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YG-串口调试助手";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.serial_options_group.ResumeLayout(false);
            this.serial_options_group.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.plotter_option_group.ResumeLayout(false);
            this.plotter_option_group.PerformLayout();
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graph_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.graph_menu.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cycleNumber)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.read_options_group.ResumeLayout(false);
            this.read_options_group.PerformLayout();
            this.tx_num_panel.ResumeLayout(false);
            this.tx_num_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_delay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox portConfig;
        private System.Windows.Forms.ComboBox baudrateConfig;
        private System.Windows.Forms.ComboBox databitsConfig;
        private System.Windows.Forms.ComboBox stopbitsConfig;
        private System.Windows.Forms.ComboBox parityConfig;
        private System.IO.Ports.SerialPort mySerial;
        private System.Windows.Forms.GroupBox serial_options_group;
        private System.Windows.Forms.Label parity_label;
        private System.Windows.Forms.Label stopbits_label;
        private System.Windows.Forms.Label databits_label;
        private System.Windows.Forms.Label baudrate_label;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label flowconrol_label;
        private System.Windows.Forms.ComboBox flowcontrolConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.TextBox tx_textarea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown graph_speed;
        private System.Windows.Forms.Timer tx_repeater_delay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip graph_menu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown graph_scale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox plotter_option_group;
        private System.Windows.Forms.CheckBox set_graph_min_enable;
        private System.Windows.Forms.NumericUpDown graph_min;
        protected System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown send_delay;
        private System.Windows.Forms.NotifyIcon alert_messege;
        private System.Windows.Forms.RichTextBox rx_textarea;
        private System.Windows.Forms.GroupBox read_options_group;
        private System.Windows.Forms.NumericUpDown graph_max;
        private System.Windows.Forms.ToolStripStatusLabel byte_counter_label;
        private System.Windows.Forms.Panel tx_num_panel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox set_graph_max_enable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label saveData;
        private System.Windows.Forms.Label clearData;
        private System.Windows.Forms.CheckBox display_stop_radiobutton;
        private System.Windows.Forms.CheckBox display_hex_radiobutton;
        private System.Windows.Forms.CheckBox receive_save_file_checkBox;
        private System.Windows.Forms.CheckBox send_hex_radiobutton;
        private System.Windows.Forms.CheckBox send_fixedTime_radiobutton;
        private System.Windows.Forms.Button CMD10;
        private System.Windows.Forms.Button CMD9;
        private System.Windows.Forms.Button CMD8;
        private System.Windows.Forms.Button CMD7;
        private System.Windows.Forms.Button CMD6;
        private System.Windows.Forms.Button CMD5;
        private System.Windows.Forms.Button CMD4;
        private System.Windows.Forms.Button CMD3;
        private System.Windows.Forms.Button CMD2;
        private System.Windows.Forms.Button CMD1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioRandomSend;
        private System.Windows.Forms.RadioButton radioOrderSend;
        private System.Windows.Forms.TextBox fileContent;
        private System.Windows.Forms.Button fileParsing;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label resetCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditCMD;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NumericUpDown cycleNumber;
        private System.Windows.Forms.Label receiveCount;
        private System.Windows.Forms.Label sendCount;
        private System.Windows.Forms.Button BtnChartSetting;
        private System.Windows.Forms.Button btnStartAndPause;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxCRC16;
    }
}

