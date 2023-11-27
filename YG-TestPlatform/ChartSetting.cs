using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YG_TestPlatform
{
    public partial class ChartSetting : Form
    {
        private DataTable dataTable;
        private Color selectedColor;
        public SeriesCollection new_seriesCollection;
        private List<Line> listLines = new List<Line>();
        public event EventHandler DataDeleted;
        public string legendText;
        SQLiteSamples sQLite = new SQLiteSamples();

        public ChartSetting()
        {
            InitializeComponent();
        }

        public ChartSetting(SeriesCollection seriesCollection)
        {

            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {

            dataTable = new DataTable();
            dataTable.Columns.Add("名称", typeof(string));

            // 添加下拉列表列
            DataColumn colorColumn = dataTable.Columns.Add("字符", typeof(string));
            colorColumn.ExtendedProperties.Add("IsComboBoxColumn", true);
            colorColumn.ExtendedProperties.Add("ComboBoxItems", new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });

            DataColumn colorColumn1 = dataTable.Columns.Add("线宽", typeof(string));
            colorColumn1.ExtendedProperties.Add("IsComboBoxColumn", true);
            colorColumn1.ExtendedProperties.Add("ComboBoxItems", new List<string> { "1.0", "1.5", "2.0", "2.5", "3.0", "3.5", "4.0", "4.5", "5.0", "5.5" });

            DataColumn colorColumn2 = dataTable.Columns.Add("类型", typeof(string));
            colorColumn2.ExtendedProperties.Add("IsComboBoxColumn", true);
            colorColumn2.ExtendedProperties.Add("ComboBoxItems", new List<string> { "Line", "Dot" });

            dataTable.Columns.Add("颜色", typeof(Line));
            dataTable.Columns.Add("NAME", typeof(string));
            dataTable.Columns.Add("ID", typeof(int));

            //绑定数据
            dataGridView1.DataSource = dataTable;

            // 设置选中单元格的背景颜色和前景颜色
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("188,220,244");
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["NAME"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["颜色"].ReadOnly = true;

            // 设置数据源为 DataTable
            dataGridView1.DataSource = dataTable;

            // 将 "字符" 列设置为下拉列表列
            SetComboBoxColumn("字符");

            // 将 "线宽" 列设置为下拉列表列
            SetComboBoxColumn("线宽");

            // 将 "类型" 列设置为下拉列表列
            SetComboBoxColumn("类型");


            //绑定数据源
            List<SysConfig> sysConfigs = sQLite.getAll();
            for (int i = 0; i < sysConfigs.Count; i++)
            {
                Line line = new Line(ColorTranslator.FromHtml(sysConfigs[i].ColorDesc), 2);
                dataTable.Rows.Add(sysConfigs[i].Name,
                    sysConfigs[i].CharDesc,
                    sysConfigs[i].LineDesc,
                    sysConfigs[i].TypeDesc,
                    line,
                    sysConfigs[i].Name,
                    sysConfigs[i].Id);
            }
        }

        public void SetComboBoxColumn(string name)
        {
            if (dataTable.Columns[name].ExtendedProperties.ContainsKey("IsComboBoxColumn"))
            {
                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.HeaderText = name;
                comboBoxColumn.Name = name;
                comboBoxColumn.DataPropertyName = name;
                comboBoxColumn.DataSource = (List<string>)dataTable.Columns[name].ExtendedProperties["ComboBoxItems"];

                dataGridView1.Columns.Remove(name);
                dataGridView1.Columns.Insert(dataTable.Columns.IndexOf(name), comboBoxColumn);
            }
        }


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("名称不能为空！");
                return;
            }

            SysConfig sysConfig = new SysConfig()
            {
                Name = tbName.Text,
                CharDesc = char_combo.Text.ToString(),
                LineDesc = line_combo.Text.ToString(),
                TypeDesc = type_combo.Text.ToString(),
                ColorDesc = selectedColor.R.ToString() + ", "
                    + selectedColor.G.ToString() + ", "
                    + selectedColor.B.ToString()
            };
            //调用新增方法
            sQLite.insert(sysConfig);
            //调用更新方法
            InitializeDataTable();
            // 数据已更新，触发事件通知父窗体
            DataDeleted?.Invoke(this, EventArgs.Empty);

        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                SysConfig sysConfig = new SysConfig() {
                    Name = dataGridView1.SelectedRows[0].Cells["名称"].Value.ToString(),
                    CharDesc = dataGridView1.SelectedRows[0].Cells["字符"].Value.ToString(),
                    LineDesc = dataGridView1.SelectedRows[0].Cells["线宽"].Value.ToString(),
                    TypeDesc = dataGridView1.SelectedRows[0].Cells["类型"].Value.ToString(),
                    ColorDesc = ((Line)dataGridView1.SelectedRows[0].Cells["颜色"].Value).Color.R.ToString() + ", "
                    + ((Line)dataGridView1.SelectedRows[0].Cells["颜色"].Value).Color.G.ToString() + ", "
                    + ((Line)dataGridView1.SelectedRows[0].Cells["颜色"].Value).Color.B.ToString()
                };

                //调用修改方法
                sQLite.updateById(id, sysConfig);
                //调用更新方法
                InitializeDataTable();
                // 数据已更新，触发事件通知父窗体
                DataDeleted?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("请至少选中一行，然后再进行编辑操作！");
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                if (MessageBox.Show("删除后不可恢复，确定要删除吗?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //调用删除方法
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    sQLite.deleteById(id);

                    //调用更新方法
                    InitializeDataTable();
                    // 数据已删除，触发事件通知父窗体
                    DataDeleted?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("请至少选中一行，然后再进行删除操作！");
                return;
            }
        }

       
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4) // 第二列
            {
                if (e.Value is Line line)
                {

                    e.PaintBackground(e.CellBounds, true);
                    Rectangle rect = new Rectangle(e.CellBounds.X + e.CellStyle.Padding.Left,
                                                   e.CellBounds.Y + e.CellStyle.Padding.Top,
                                                   e.CellBounds.Width - e.CellStyle.Padding.Horizontal,
                                                   e.CellBounds.Height - e.CellStyle.Padding.Vertical);

                    using (Pen pen = new Pen(line.Color, line.Width))
                    {
                        e.Graphics.DrawLine(pen, rect.Left, rect.Top + rect.Height / 2, rect.Right, rect.Top + rect.Height / 2);
                    }

                    e.Paint(e.CellBounds, DataGridViewPaintParts.Border);
                    e.Handled = true;

                }
            }
        }

        private Button colorButton;
        private ColorDialog colorDialog;

        private void ChartSetting_Load(object sender, EventArgs e)
        {


            // 初始化按钮
            colorButton = new Button();
            colorButton.Location = new Point(480, 40);
            colorButton.Text = "选择颜色";
            colorButton.Click += ColorButton_Click;

            // 初始化颜色对话框
            colorDialog = new ColorDialog();

            // 将按钮添加到窗体
            Controls.Add(colorButton);

            type_combo.SelectedIndex = 0;
            line_combo.SelectedIndex = 0;
            char_combo.SelectedIndex = 0;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            // 显示颜色对话框
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // 获取选定的颜色
                selectedColor = colorDialog.Color;
            }
        }


        private void ChartSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            //调用更新方法
            InitializeDataTable();
            // 数据已更新，触发事件通知父窗体
            DataDeleted?.Invoke(this, EventArgs.Empty);
            this.Dispose();
            this.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // 监听颜色的索引
            {
                this.ColorButton_Click(null,null);
                // 在这里编写触发事件后的逻辑处理
                // 你可以使用以下代码获取修改后的单元格值
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                object newValue = cell.Value;
                ((YG_TestPlatform.Line)cell.Value).Color = selectedColor;
                // 执行相应的操作
            }
        }

    }

    public class Line
    {
        public Color Color { get; set; }
        public float Width { get; set; }

        public Line(Color color, float width)
        {
            Color = color;
            Width = width;
        }
    }

    public class ColorItem
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        public ColorItem(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
