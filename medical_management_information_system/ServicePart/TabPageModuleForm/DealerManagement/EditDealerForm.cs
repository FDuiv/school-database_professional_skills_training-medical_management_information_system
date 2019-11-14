using medical_management_information_system.ServicePart.TabPageModuleForm.DealerManagement;
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
    public partial class EditDealerForm : Form
    {
        private int distributorId;
        public EditDealerForm(int distributorId)
        {
            InitializeComponent();
            this.distributorId=distributorId;
        }

        private void EditDealerForm_Load(object sender, EventArgs e)
        {
            this.drugDataGridView.DataSource=DButils.getDistributorDrugNeed(this.distributorId, this.downComboBox.Text);
            this.downComboBox.Items.Clear();
            for (int i = 0; i<((DataTable)this.drugDataGridView.DataSource).Rows.Count; i++)
            {
                this.downComboBox.Items.Add(((DataTable)this.drugDataGridView.DataSource).Rows[i][1]);
            }
            this.distributorDrugDataGridView.DataSource=DButils.getDistributorDrug(this.distributorId, this.upComboBox.Text);
            this.upComboBox.Items.Clear();
            for (int i = 0; i<((DataTable)this.distributorDrugDataGridView.DataSource).Rows.Count; i++)
            {
                this.upComboBox.Items.Add(((DataTable)this.distributorDrugDataGridView.DataSource).Rows[i][1]);
            }
        }

        private void drugDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new AddDistributorDrugForm(this.distributorId,int.Parse(this.drugDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
            this.EditDealerForm_Load(sender, e);
        }

        private void upComboBox_TextChanged(object sender, EventArgs e)
        {
            this.distributorDrugDataGridView.DataSource=DButils.getDistributorDrug(this.distributorId, this.upComboBox.Text);
            
        }

        private void downComboBox_TextChanged(object sender, EventArgs e)
        {
            this.drugDataGridView.DataSource=DButils.getDistributorDrugNeed(this.distributorId, this.downComboBox.Text);
        }

        private void distributorDrugDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除选定行？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                DButils.deleteDistributorDrug(int.Parse(this.distributorDrugDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                this.EditDealerForm_Load(sender, e);
            }
            
        }
    }
}
