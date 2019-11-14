using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.OtherForm
{
    public partial class AddPharmaceuticalForm : Form
    {
        public AddPharmaceuticalForm()
        {
            InitializeComponent();
        }

        private void AddPharmaceuticalForm_Load(object sender, EventArgs e)
        {

        }

        private void companyComboBox_Enter(object sender, EventArgs e)
        {
            this.companyComboBox.Items.Clear();
            string[] companys = DButils.getPharmaceuticalDistributorCompanys();
            for (int i = 0; i<companys.Length; i++)
            {
                this.companyComboBox.Items.Add(companys[i]);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.companyComboBox.Text=="")
            {
                MessageBox.Show("公司名不能为空", "警告");
                return;
            }
            if (this.distributorTextBox.Text=="")
            {
                MessageBox.Show("部门名不能为空", "警告");
                return;
            }
            string[] companys = DButils.getPharmaceuticalDistributorCompanys();
            if (!string.Join("；", companys).Contains(this.companyComboBox.Text))
            {
                //新增公司
                DButils.addPharmaceuticalCompany(this.companyComboBox.Text);
            }
            DButils.addPharmaceuticalDistributor(this.companyComboBox.Text, this.distributorTextBox.Text);
            MessageBox.Show("添加成功", "提示");
        }
    }
}
