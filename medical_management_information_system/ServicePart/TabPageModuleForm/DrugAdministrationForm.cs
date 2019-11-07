using medical_management_information_system.ServicePart.OtherForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.TabPageModuleForm
{
    public partial class DrugAdministrationForm : Form
    {
        public DrugAdministrationForm()
        {
            InitializeComponent();
        }

        public void DrugAdministrationForm_Load(object sender, EventArgs e)
        {
            this.comboBox.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.comboBox.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
            this.deleteBtn.Enabled=false;
            this.flashBtn_Click(sender, e);
        }

        private void DrugAdministrationForm_SizeChanged(object sender, EventArgs e)
        {
            this.printingBtn.Location=new Point(this.Size.Width-this.printingBtn.Size.Width-12, this.printingBtn.Location.Y);
            this.flashBtn.Location=new Point(this.printingBtn.Location.X-this.printingBtn.Size.Width-6, this.flashBtn.Location.Y);
            this.generatePurchaseOrderBtn.Location=new Point(this.flashBtn.Location.X-this.flashBtn.Size.Width-6,this.generatePurchaseOrderBtn.Location.Y);
            this.dataGridView.Size=new Size(this.Size.Width-22, this.Size.Height-52);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            new AddDrugForm().ShowDialog();
            this.flashBtn_Click(sender, e);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new AddDrugForm(int.Parse(this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
            this.flashBtn_Click(sender, e);
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            List<int> drugIds = new List<int>();
            for (int i = 0; i<this.dataGridView.SelectedRows.Count; i++)
            {
                drugIds.Add(int.Parse(this.dataGridView.SelectedRows[i].Cells[0].Value.ToString()));
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            List<int> drugIds = new List<int>();
            for (int i = 0; i<this.dataGridView.SelectedRows.Count; i++)
            {
                drugIds.Add(int.Parse(this.dataGridView.SelectedRows[i].Cells[0].Value.ToString()));
            }
            if (drugIds.Count!=0)
            {
                DialogResult result = MessageBox.Show("确定删除选定行？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    DButils.deleteDrug(drugIds);
                    this.dataGridView.DataSource=DButils.getDrugGridView();
                    this.deleteBtn.Enabled=false;
                }
            }
        }

        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count==0)
            {
                this.deleteBtn.Enabled=false;
            }
            else
            {
                this.deleteBtn.Enabled=true;
            }
        }

        private void flashBtn_Click(object sender, EventArgs e)
        {
            if (this.Parent!=null)
            {
                this.Size=this.Parent.Size;
            }
            this.DrugAdministrationForm_SizeChanged(sender, e);
            this.dataGridView.DataSource=DButils.getDrugGridView(-1, this.comboBox.Text);
            this.comboBox.Items.Clear();
            for (int i = 0; i<((DataTable)this.dataGridView.DataSource).Rows.Count; i++)
            {
                this.comboBox.Items.Add(((DataTable)this.dataGridView.DataSource).Rows[i][1]);
            }

        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView.DataSource=DButils.getDrugGridView(-1, this.comboBox.Text);
            this.comboBox.Items.Clear();
            for (int i = 0; i<((DataTable)this.dataGridView.DataSource).Rows.Count; i++)
            {
                this.comboBox.Items.Add(((DataTable)this.dataGridView.DataSource).Rows[i][1]);
            }
        }

    }
}
