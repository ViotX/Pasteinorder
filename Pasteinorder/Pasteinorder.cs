using System;
using System.Text;
using System.Windows.Forms;

namespace Pasteinorder
{
    public partial class Pasteinorder : Form
    {
        int addNO = 0;
        int setNO = 0;
        int loopNO = 0;
        bool show = false;
        public Pasteinorder()
        {
            InitializeComponent();
        }
        private const int WM_HOTKEY = 0x312; //窗口消息-热键
        private const int Space = 0x3572; //热键ID
        /// <summary>
        /// 导入文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Selectpath_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Multiselect = false;
            fd.Title = "Please Select File";
            fd.Filter = "TXT文件|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
                path = fd.FileName;
            if (path != "")
            {
                string before = System.IO.File.ReadAllText(path);
                string[] after = before.Split(new string[] { sep.Text, "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in after)
                {
                    dataGridView1.Rows.Add(addNO, item);
                    addNO++;
                }
            }
        }
        /// <summary>
        /// 清空表格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmptyB_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            no.Text = "0";
            addNO = 0;
            setNO = 0;

        }
        private void OpenB_Click(object sender, EventArgs e)
        {
            string shortCutKeys = keyText.Text;
            string[] keyStrs = shortCutKeys.Split('+');
            if (keyStrs.Length == 1)
            {
                HotKey.RegKey(Handle, Space, "None", keyStrs[0]);
            }
            else
            {
                HotKey.RegKey(Handle, Space, keyStrs[0], keyStrs[1]);
            }
            condition.Text = "运行中！" + Environment.NewLine + "当前热键：" + keyText.Text;
        }
        private void CloseB_Click(object sender, EventArgs e)
        {
            HotKey.UnRegKey(Handle, Space);
            condition.Text = "未运行！";
        }
        /// <summary>
        /// 全局热键
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_HOTKEY: //窗口消息-热键ID
                    switch (m.WParam.ToInt32())
                    {
                        case Space: //热键ID
                            if (setNO < dataGridView1.RowCount)
                            {
                                Clipboard.SetText(dataGridView1.Rows[setNO].Cells[1].Value.ToString());
                                SendKeys.Send("^v");
                                setNO++;
                                show = false;

                                //如果启用循环并且当前序号大于列表全部数量，则判断循环次数
                                if (enable.Checked && setNO >= dataGridView1.RowCount)
                                {
                                    if (loopNO > 1)
                                    {
                                        setNO = 0;
                                        loopNO--;
                                    }
                                }
                                no.Text = Convert.ToString(setNO);
                            }
                            else
                            {
                                if (!show)
                                {
                                    MessageBox.Show("已经复制到终点！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                    show = true;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        private void keyDown(object sender, KeyEventArgs e)
        {
            StringBuilder keyValue = new StringBuilder();
            keyValue.Length = 0;
            keyValue.Append("");
            if (e.Modifiers != 0)
            {
                if (e.Control)
                    keyValue.Append("Ctrl + ");
                if (e.Alt)
                    keyValue.Append("Alt + ");
                if (e.Shift)
                    keyValue.Append("Shift + ");
            }
            if ((e.KeyValue >= 33 && e.KeyValue <= 40) ||
                (e.KeyValue >= 65 && e.KeyValue <= 90) ||   //a-z/A-Z
                (e.KeyValue >= 112 && e.KeyValue <= 123))   //F1-F12
            {
                keyValue.Append(e.KeyCode);
            }
            else if ((e.KeyValue >= 48 && e.KeyValue <= 57))    //0-9
            {
                keyValue.Append(e.KeyCode.ToString().Substring(1));
            }
            this.ActiveControl.Text = "";
            //设置当前活动控件的文本内容
            this.ActiveControl.Text = keyValue.ToString();
        }
        private void keyUp(object sender, KeyEventArgs e)
        {
            string str = this.ActiveControl.Text.TrimEnd();
            int len = str.Length;
            if (len >= 1 && str.Substring(str.Length - 1) == "+")
            {
                this.ActiveControl.Text = "";
            }
        }
        /// <summary>
        /// 输入序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textChanged(object sender, EventArgs e)
        {
            setNO = Convert.ToInt32(no.Text);
        }

        private void enable_Click(object sender, EventArgs e)
        {
            loopNO = (int)loop.Value;
            if (setNO >= dataGridView1.RowCount) setNO = 0;
        }
    }
}