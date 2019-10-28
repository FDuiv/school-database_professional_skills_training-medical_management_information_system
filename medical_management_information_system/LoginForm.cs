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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
             if (this.accountTextBox.Text=="")
            {
                MessageBox.Show("账号不能为空", "警告");
                return;
            }
            if (this.passwordTextBox.Text=="")
            {
                MessageBox.Show("密码不能为空", "警告");
                return;
            }

            string result = Program.user.tryLogin(this.accountTextBox.Text, this.passwordTextBox.Text);
            if (result=="Account does not exist")
            {
                MessageBox.Show("账号不存在", "警告");
                return;
            }
            if (result=="Password error")
            {
                MessageBox.Show("密码错误", "警告");
                return;
            }
            
            if (result=="Login successful")
            {
                //进入主界面
                this.Close();
            }
        }


        private void signInBtn_Click(object sender, EventArgs e)
        {
            SiginForm siginForm = new SiginForm();
            siginForm.ShowDialog();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            ConnectForm setForm = new ConnectForm();
            setForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (ConnectForm.ip!=""&&ConnectForm.port!=""&&ConnectForm.user!=""&&ConnectForm.password!="")
            {
                Program.user.Connect(ConnectForm.ip, ConnectForm.port, ConnectForm.user, ConnectForm.password);
            }
        }
    }
}
