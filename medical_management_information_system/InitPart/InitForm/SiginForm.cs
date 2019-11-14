using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system
{
    public partial class SiginForm : Form
    {
        public SiginForm()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (Program.user.getConnect()==null)
            {
                if (ConnectForm.ip!=""&&ConnectForm.port!=""&&ConnectForm.user!=""&&ConnectForm.password!="")
                { 
                    if (Program.user.Connect(ConnectForm.ip, ConnectForm.port, ConnectForm.user, ConnectForm.password)!="Connection successful")
                    {
                        Program.user.Close();
                        MessageBox.Show("无法连接服务器！", "警告");
                        return;
                    }

                }
            }
            if (this.accountTextBox.Text=="")
            {
                MessageBox.Show("账号不能为空","警告");
                return;
            }
            if (this.passwordTextBox.Text==""||this.surePasswordTextBox.Text=="")
            {
                MessageBox.Show("密码不能为空", "警告");
                return;
            }
            if (this.passwordTextBox.Text!=this.surePasswordTextBox.Text)
            {
                MessageBox.Show("两次密码不一样", "警告");
                return;
            }
            string result = Program.user.trySigin(this.accountTextBox.Text, this.passwordTextBox.Text);
            if (result=="Account already exists")
            {
                MessageBox.Show("账号已存在", "警告");
                return;
            }
            if (result=="Sigin successful")
            {
                MessageBox.Show("注册成功", "提示");
                this.Close();
            }
        }

        private void accountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.signInBtn_Click(sender, e);
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.signInBtn_Click(sender, e);
            }
        }

        private void surePasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.signInBtn_Click(sender, e);
            }
        }
    }
}
