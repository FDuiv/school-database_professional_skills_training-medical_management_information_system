using medical_management_information_system.ServicePart.TabPageModuleForm.Requisition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.TabPageModuleForm
{
    public partial class RequisitionForm : Form
    {
        public RequisitionForm()
        {
            InitializeComponent();
            
        }

        public void RequisitionForm_Load(object sender, EventArgs e)
        {
            this.RequisitionForm_SizeChanged(sender, e);
            this.treeView.Nodes.Clear();
            string[] requisitionOrders = DButils.getRequisitionOrders();
            for (int i = 0; i<requisitionOrders.Length; i++)
            {
                TreeNode node = new TreeNode(requisitionOrders[i]);
                this.treeView.Nodes.Add(node);
            }
        }

        private void RequisitionForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent!=null)
            {
                this.Size=this.Parent.Size;
            }
            this.treeView.Size=new Size(this.treeView.Size.Width, this.Size.Height-26);
            this.flashBtn.Location=new Point(this.Size.Width-this.flashBtn.Size.Width-12,this.flashBtn.Location.Y);
            this.dataGridView.Size=new Size(this.flashBtn.Location.X+this.flashBtn.Size.Width-this.dataGridView.Location.X,this.treeView.Location.Y+this.treeView.Size.Height-this.dataGridView.Location.Y);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] temp=this.treeView.SelectedNode.Text.Split(' ');
            int requisitionOrderId=DButils.getRequisitionOrderId(temp[0]+" "+temp[2]);
            this.dataGridView.DataSource=DButils.getPurchasingList(requisitionOrderId);
        }

        private void flashBtn_Click(object sender, EventArgs e)
        {
            if (this.treeView.SelectedNode!=null)
            {
                string[] temp = this.treeView.SelectedNode.Text.Split(' ');
                int requisitionOrderId = DButils.getRequisitionOrderId(temp[0]+" "+temp[2]);
                this.dataGridView.DataSource=DButils.getPurchasingList(requisitionOrderId);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new SelectPharmaceutical(int.Parse(this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()), int.Parse(this.dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString())).ShowDialog();
            this.flashBtn_Click(sender, e);
            if (this.dataGridView.Rows.Count==1)
            {
                string[] temp = this.treeView.SelectedNode.Text.Split(' ');
                int requisitionOrderId = DButils.getRequisitionOrderId(temp[0]+" "+temp[2]);
                DButils.completePurchase(requisitionOrderId);
                this.RequisitionForm_Load(sender, e);
                this.dataGridView.DataSource=null; 
            }
            
        }
    }
}
