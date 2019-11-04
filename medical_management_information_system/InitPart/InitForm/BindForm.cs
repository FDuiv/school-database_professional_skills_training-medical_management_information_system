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
    public partial class BindForm : Form
    {
        public BindForm()
        {
            InitializeComponent();
        }

        private void sureBtn_Click(object sender, EventArgs e)
        {
            string name = this.nameTextBox.Text;
            string gender = this.genderComboBox.Text;
            string birthDay = this.yearComboBox.Text+"-"+this.monthComboBox.Text+"-"+this.dayComboBox.Text;
            string companyName = this.companyComboBox.Text;
            string branchName = this.branchComboBox.Text;
            string departmentName = this.departmentComboBox.Text;
            string[] addrs = this.addrTextBox.Text.Split('；');
            string[] phones = this.phoneTextBox.Text.Split('；');
            //有效性检测
            if (name=="")
            {
                MessageBox.Show("名字不能为空！", "警告");
                return;
            }
            if (gender=="")
            {
                MessageBox.Show("请选择性别！", "警告");
                return;
            }
            if (this.companyComboBox.Text=="")
            {
                MessageBox.Show("请选择所属公司！", "警告");
                return;
            }
            if (this.branchComboBox.Text=="")
            {
                MessageBox.Show("请选择所属分部！", "警告");
                return;
            }
            if (this.departmentComboBox.Text=="")
            {
                MessageBox.Show("请选择所属部门！", "警告");
                return;
            }

            int addrFlag = 0;
            List<string> addrsNew = new List<string>();
            for (int i = 0; i<addrs.Length; i++)
            {
                if (addrs[i]!="")
                {
                    addrFlag=1;
                    addrsNew.Add(addrs[i]);
                }
            }
            if (addrFlag==0)
            {
                MessageBox.Show("地址不能为空！", "警告");
                return;
            }

            int phoneFlag = 0;
            List<string> phonesNew = new List<string>();
            for (int i = 0; i<phones.Length; i++)
            {
                if (phones[i].Length>11)
                {
                    MessageBox.Show("电话格式不正确！", "警告");
                    return;
                }
                if (phones[i]!="")
                {
                    phoneFlag=1;
                    phonesNew.Add(phones[i]);
                }
            }
            if(phoneFlag==0)
            {
                MessageBox.Show("电话不能为空！", "警告");
                return;
            }
            string result="";
            if (Program.user.getStaffId()==-1)
            {
                result = Program.user.bindAccount(name, gender, birthDay, companyName, branchName, departmentName, addrsNew, phonesNew);
            }
            else
            {
                result=Program.user.updateInformation(name, gender, birthDay, companyName, branchName, departmentName, addrsNew, phonesNew);
            }
            if (result=="null account")
            {
                MessageBox.Show("账号未登录！", "警告");
                return;
            }
            this.Close(); 
        }

        private void BindForm_Load(object sender, EventArgs e)
        {
            if (Program.user.getStaffId()!=-1)
            {
                //已绑定，个人资料抽取
                this.nameTextBox.Text=Program.user.getName();
                this.genderComboBox.Text=Program.user.getGender();
                string[] birthDay = Program.user.getBirthDay().Split(' ')[0].Split('/');
                this.yearComboBox.Text=birthDay[0];
                this.monthComboBox.Text=birthDay[1];
                this.dayComboBox.Text=birthDay[2];
                this.companyComboBox.Text=Program.user.getCompanyName();
                this.branchComboBox.Text=Program.user.getBranchName();
                this.departmentComboBox.Text=Program.user.getDepartmentName();
                string[] addrs = Program.user.getAddrs();
                for (int i=0; i<addrs.Length; i++)
                {
                    this.addrTextBox.Text+=addrs[i]+"；";
                }
                string[] phones = Program.user.getPhones();
                for (int i = 0; i<phones.Length; i++)
                {
                    this.phoneTextBox.Text+=phones[i]+"；";
                }
            }
            else
            {
                //未绑定
                this.yearComboBox.Text=1970.ToString();
                this.monthComboBox.Text=1.ToString();
                this.dayComboBox.Text=1.ToString();
            }
        }
        private void genderComboBox_Click(object sender, EventArgs e)
        {
            this.genderComboBox.Items.Clear();
            this.genderComboBox.Items.Add("男");
            this.genderComboBox.Items.Add("女");
        }

  
        private void yearComboBox_Enter(object sender, EventArgs e)
        {
            this.yearComboBox.Items.Clear();
            for (int i = 1970; i<=int.Parse(DateTime.Now.ToString("yyyy")); i++)
            {
                this.yearComboBox.Items.Add(i);
            }
        }
        private void monthComboBox_Enter(object sender, EventArgs e)
        {
            this.monthComboBox.Items.Clear();
            for (int i = 1; i<=12; i++)
            {
                this.monthComboBox.Items.Add(i);
            }
        }
        private void dayComboBox_Enter(object sender, EventArgs e)
        {
            this.dayComboBox.Items.Clear();
            int year = int.Parse(this.yearComboBox.Text);
            int month = int.Parse(this.monthComboBox.Text);
            int day = 0;
            if (month==4||month==6||month==10||month==11)
            {
                day=30;
            }
            else if (month==2)
            {
                if (year%4==0&&year%100!=0||year%400==0)
                {
                    day=29;
                }
                else
                {
                    day=28;
                }
            }
            else
            {
                day=31;
            }
            for (int i = 1; i<=day; i++)
            {
                this.dayComboBox.Items.Add(i);
            }
        }

        private void companyComboBox_Enter(object sender, EventArgs e)
        {
            this.companyComboBox.Items.Clear();
            List<string> companys = new List<string>();
            companys=DButils.getAllCompanys();
            for (int i = 0; i<companys.Count(); i++)
            {
                this.companyComboBox.Items.Add(companys[i]);
            }
        }
        private void BindForm_Shown(object sender, EventArgs e)
        {
            this.nameTextBox.Focus();
        }

        private void branchComboBox_Enter(object sender, EventArgs e)
        {
            this.branchComboBox.Items.Clear();
            List<string> branchs = new List<string>();
            branchs=DButils.getBranchs(this.companyComboBox.Text);
            for (int i = 0; i<branchs.Count(); i++)
            {
                this.branchComboBox.Items.Add(branchs[i]);
            }
        }

        private void departmentComboBox_Enter(object sender, EventArgs e)
        {
            this.departmentComboBox.Items.Clear();
            List<string> departments = new List<string>();
            departments=DButils.getDepartments(this.branchComboBox.Text);
            for (int i = 0; i<departments.Count(); i++)
            {
                this.departmentComboBox.Items.Add(departments[i]);
            }
        }


        private void genderComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void yearComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void monthComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void dayComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void companyComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void branchComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void departmentComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
            if (e.KeyChar=='；')
            {
                e.Handled=false;
            }
        }

        private void companyComboBox_TextChanged(object sender, EventArgs e)
        {
            this.branchComboBox.Text="";
            this.departmentComboBox.Text="";
        }

        private void branchComboBox_TextChanged(object sender, EventArgs e)
        {
            this.departmentComboBox.Text="";
        }
    }
}
