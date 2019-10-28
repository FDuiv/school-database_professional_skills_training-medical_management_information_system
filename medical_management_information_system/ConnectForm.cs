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
    public partial class ConnectForm : Form
    {
        public static string ip= "119.23.232.245", port="3306",user= "SQLcourse", password="ghghgghh";

        private void ConnectForm_Load(object sender, EventArgs e)
        { 
            this.ipTextBox.Text=ConnectForm.ip;
            this.portTextBox.Text=ConnectForm.port;
            this.userTextBox.Text=ConnectForm.user;
            this.passwordTextBox.Text=ConnectForm.password;
        }

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void sureBtn_Click(object sender, EventArgs e)
        {
            ip=this.ipTextBox.Text;
            port=this.portTextBox.Text;
            user=this.userTextBox.Text;
            password=this.passwordTextBox.Text;

            if (ConnectForm.ip!=""&&ConnectForm.port!=""&&ConnectForm.user!=""&&ConnectForm.password!="")
            {
                Program.user.Close();
                Program.user.Connect(ConnectForm.ip, ConnectForm.port, ConnectForm.user, ConnectForm.password);
                this.Close();
                return;
            }
            MessageBox.Show("连接失败！", "提示");
            this.Close();
        }
    }
}
