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

        }

        private void BindForm_Load(object sender, EventArgs e)
        {
            this.yearComboBox.Text=1970.ToString();
            this.monthComboBox.Text=1.ToString();
            this.dayComboBox.Text=1.ToString();
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
            branchs=DButils.getBranch(this.companyComboBox.Text);
            for (int i = 0; i<branchs.Count(); i++)
            {
                this.branchComboBox.Items.Add(branchs[i]);
            }
        }

        private void departmentComboBox_Enter(object sender, EventArgs e)
        {
            this.departmentComboBox.Items.Clear();
            List<string> departments = new List<string>();
            departments=DButils.getDepartment(this.branchComboBox.Text);
            for (int i = 0; i<departments.Count(); i++)
            {
                this.departmentComboBox.Items.Add(departments[i]);
            }
        }
    }
}
