using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.TabPageModuleForm.DealerManagement
{
    public partial class AddDistributorDrugForm : Form
    {
        private int distributorId;
        private int drugId;
        public AddDistributorDrugForm(int distributorId,int drugId)
        {
            InitializeComponent();
            this.distributorId=distributorId;
            this.drugId=drugId;
        }

        private void inventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
        }

        private void unitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar=='.')//允许输入点
            {
                e.Handled=false;
            }
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.inventoryTextBox.Text=="")
            {
                MessageBox.Show("库存不能为空！", "警告");
                return;
            }
            if (this.unitPriceTextBox.Text=="")
            {
                MessageBox.Show("单价不能为空！", "警告");
                return;
            }
            DButils.addDistributorDrug(this.distributorId,this.drugId,int.Parse(this.inventoryTextBox.Text),float.Parse(this.unitPriceTextBox.Text));
            this.Close();
        }
    }
}
