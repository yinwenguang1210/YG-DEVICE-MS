using System;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace YG_TestPlatform
{
    public class BaseMethod
    {
        public BaseMethod()
        {
            //struct
        }

        public string GetAppCurrentPath(string src)
        {
            string strPlatfrom = System.Environment.OSVersion.Platform.ToString().Trim();

            if (strPlatfrom == "")
            {
                return "\\Program Files\\" + src;
            }

            switch (strPlatfrom.ToUpper())
            {
                case "WINCE":
                    return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.ToString()) + src;
                case "WIN32NT":
                    return System.IO.Directory.GetCurrentDirectory() + src;
                default:
                    return src;
            }
        }

        public void SetControlFocus(Control control, System.Windows.Forms.KeyEventArgs e)
        {
            string strPlatfrom = System.Environment.OSVersion.Platform.ToString().Trim();

            if (strPlatfrom == "")
            {
                return;
            }

            if (strPlatfrom == "WIN32NT")
            {
                return;
            }

            if (e.KeyCode.ToString().ToUpper() == "F23")
            {
                control.Focus();
            }
        }

        public void SetControlFocus(Control control, System.Windows.Forms.KeyPressEventArgs e)
        {
            string strPlatfrom = System.Environment.OSVersion.Platform.ToString().Trim();

            if (e.KeyChar == 13)
            {
                control.Focus();
            }
        }

        /// <summary>
        /// 消息的提示类型
        /// </summary>
        public enum MessageType
        {
            Pass,
            Fail,
            Wait,
            Special
        }

        /// <summary>
        /// 按照指定的类型显示错误信息
        /// </summary>
        /// <param name="lblInfo">Label控件</param>
        /// <param name="msg">需要显示的消息，"CRLF" 会被替换为换行符</param>
        /// <param name="msgType">消息类型</param>
        public static void ShowMessageInfo(Label lblInfo, string msg, MessageType msgType)
        {
            Color backColor, foreColor;

            switch (msgType)
            {
                case MessageType.Pass:
                    backColor = Color.FromArgb(0, 200, 0);
                    foreColor = Color.Black;
                    break;
                case MessageType.Fail:
                    backColor = Color.Red;
                    foreColor = Color.Black;
                    break;
                case MessageType.Wait:
                    backColor = Color.Yellow;
                    foreColor = Color.Black;
                    break;
                case MessageType.Special:
                    backColor = Color.LightBlue;
                    foreColor = Color.White;
                    break;
                default:
                    backColor = SystemColors.Control;
                    foreColor = SystemColors.ControlText;
                    break;
            }

            lblInfo.BackColor = backColor;
            lblInfo.ForeColor = foreColor;

            lblInfo.Text = msg.Replace("CRLF", "\r\n");
        }

        /// <summary>
        /// 检查 DataTable 是否包含有效数据
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>是否包含有效数据</returns>
        public static bool CheckDataTableValid(DataTable dt)
        {
            if (dt == null)
                return false;

            if (dt.Rows.Count == 0)
                return false;

            return true;
        }

        public void ShowMessage(TextBox lblInfo, string msg, int flag)
        {
            if (flag == 0)
            {
                lblInfo.ForeColor = Color.Red;
            }
            else if (flag == 1)
            {
                lblInfo.ForeColor = Color.Green;
            }
            else
            {
                lblInfo.ForeColor = Color.Transparent;
            }

            lblInfo.Text = msg.Replace("CRLF", "\r\n");
        }

        public void ShowMessageBackColor(TextBox lblInfo, string msg, int flag)
        {
            if (flag == 0)
            {
                lblInfo.BackColor = Color.Red;
                lblInfo.ForeColor = Color.Black;

            }
            else if (flag == 1)
            {
                lblInfo.BackColor = Color.Lime;
                lblInfo.ForeColor = Color.Black;

            }
            else
            {
                lblInfo.BackColor = Color.Blue;
                lblInfo.ForeColor = Color.Black;
            }

            lblInfo.Text = msg.Replace("CRLF", "\r\n");
        }

        public bool IsSucceed(string result)
        {
            if (result.Trim().ToUpper() == "PASS")
            {
                return true;
            }

            return false;
        }

        public string DebugDataRow(DataTable dt, DataRow dr)
        {
            if (dt == null || dr == null)
            {
                return "";
            }

            StringBuilder content = new StringBuilder();
            content.Remove(0, content.Length);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (content.Length == 0)
                {
                    content.Append(dr[i].ToString());
                }
                else
                {
                    content.Append("," + dr[i].ToString());
                }
            }

            return content.ToString();
        }

        public bool IsNumeric(string qty)
        {
            int iQty = 0;
            try
            {
                iQty = Convert.ToInt32(qty);
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 文本框获取焦点
        /// </summary>
        /// <param name="txtBox"></param>
        public void GotTextFocus(TextBox txtBox)
        {
            txtBox.Focus();
            txtBox.SelectAll();
            txtBox.BackColor = Color.PeachPuff;
        }

        /// <summary>
        /// 文本框失去焦点
        /// </summary>
        /// <param name="txtBox"></param>
        public void LostTextFocus(TextBox txtBox)
        {
            txtBox.BackColor = Color.White;
        }


    }
}
