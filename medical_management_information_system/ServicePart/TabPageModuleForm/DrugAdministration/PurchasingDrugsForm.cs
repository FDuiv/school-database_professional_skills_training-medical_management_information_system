using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.TabPageModuleForm.DrugAdministration
{
    public partial class PurchasingDrugsForm : Form
    {
        private List<string[]> purchaseDrugIdNums;
        public PurchasingDrugsForm()
        {
            InitializeComponent();
            this.purchaseDrugIdNums=new List<string[]>();
            string[] initStr = { "0", "0" };
            this.purchaseDrugIdNums.Add(initStr);

        }

        private void upComboBox_TextChanged(object sender, EventArgs e)
        {
            List<string> purchaseDrugIds = new List<string>();
            for (int i = 0; i<this.purchaseDrugIdNums.Count; i++)
            {
                purchaseDrugIds.Add(this.purchaseDrugIdNums[i][0]);
            }
            this.upDataGridView.DataSource=DButils.getPurchaseDrug(purchaseDrugIds,this.upComboBox.Text,false);
            this.upComboBox.Items.Clear();
            for (int i = 0; i<((DataTable)this.upDataGridView.DataSource).Rows.Count; i++)
            {
                this.upComboBox.Items.Add(((DataTable)this.upDataGridView.DataSource).Rows[i][1]);
            }
        }
        private void downComboBox_TextChanged(object sender, EventArgs e)
        {
            List<string> purchaseDrugIds = new List<string>();
            for (int i = 0; i<this.purchaseDrugIdNums.Count; i++)
            {
                purchaseDrugIds.Add(this.purchaseDrugIdNums[i][0]);
            }
            this.downDataGridView.DataSource=DButils.getPurchaseDrug(purchaseDrugIds, this.downComboBox.Text, true);
            this.downComboBox.Items.Clear();
            for (int i = 0; i<((DataTable)this.downDataGridView.DataSource).Rows.Count; i++)
            {
                this.downComboBox.Items.Add(((DataTable)this.downDataGridView.DataSource).Rows[i][1]);
            }
        }

        private void PurchasingDrugsForm_Load(object sender, EventArgs e)
        {
            this.upComboBox_TextChanged(sender, e);
            this.downComboBox_TextChanged(sender, e);
        }

        private void upDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i<this.purchaseDrugIdNums.Count; i++)
            {
                if (this.purchaseDrugIdNums[i][0]==this.upDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    this.purchaseDrugIdNums.Remove(this.purchaseDrugIdNums[i]);

                }
            }
            this.upComboBox_TextChanged(sender, e);
            this.downComboBox_TextChanged(sender, e);
        }
        private void downDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] strs = { this.downDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), this.NumTextBox.Text };
            this.purchaseDrugIdNums.Add(strs);
            this.upComboBox_TextChanged(sender, e);
            this.downComboBox_TextChanged(sender, e);
        }

        private void sureBtn_Click(object sender, EventArgs e)
        {
            List<string[]> temp = new List<string[]>();
            for (int i = 1; i<this.purchaseDrugIdNums.Count; i++)
            {
                string[] strs = {this.purchaseDrugIdNums[i][0], this.purchaseDrugIdNums[i][1] };
                temp.Add(strs);
            }
            DButils.addPurchaseOrders(temp);
            this.Close();
        }

        private void NumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
        }

        private void NumTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.NumTextBox.Text=="")
            {
                this.NumTextBox.Text="0";
            }
        }
    }
}
