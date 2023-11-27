using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YG_TestPlatform
{
    public partial class FormInstructionSettings : Form
    {
        public FormInstructionSettings()
        {
            InitializeComponent();
        }

        private string buttonName = string.Empty;//CMD按钮名称

        /// <summary>
        /// 带参构造函数
        /// </summary>
        /// <param name="buttonName"></param>
        public FormInstructionSettings(string _buttonName)
        {
            buttonName = _buttonName;
            InitializeComponent();
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string commandText = tx_command.Text;
            BaseMethod bm = new BaseMethod();
            string fileName = bm.GetAppCurrentPath("\\CommandConfig.ini");
            IniFile.PutINI("PRINT", buttonName, commandText, fileName);
            alert("保存成功！");
            this.Close();
        }

        /// <summary>
        /// 取消按钮点击事件：取消当前操作，所修改内容不保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 加载事件：
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInstructionSettings_Load(object sender, EventArgs e)
        {
            BaseMethod bm = new BaseMethod();
            string fileName = bm.GetAppCurrentPath("\\CommandConfig.ini");
            tx_command.Text = IniFile.GetINI("PRINT", buttonName, "1", fileName);
        }

        private void alert(string text)
        {
            alert_messege.Icon = Icon;
            alert_messege.Visible = true;
            alert_messege.ShowBalloonTip(5000, "提 示", text, ToolTipIcon.Info);
        }
    }
}
