using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.TabPageModuleForm.ShoppingCheck
{
    public partial class ShoppingCheckForm : Form
    {
        public ShoppingCheckForm()
        {
            InitializeComponent();
        }

        public void ShoppingCheckForm_Load(object sender, EventArgs e)
        {
            this.ShoppingCheckForm_SizeChanged(sender, e);
            this.treeView.Nodes.Clear();
            string[] requisitionOrders = DButils.getShoppingOrders();
            for (int i = 0; i<requisitionOrders.Length; i++)
            {
                TreeNode node = new TreeNode(requisitionOrders[i]);
                this.treeView.Nodes.Add(node);
            }
        }

        private void ShoppingCheckForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent!=null)
            {
                this.Size=this.Parent.Size;
            }
            this.treeView.Size=new Size(this.treeView.Size.Width, this.Size.Height-26);
            this.printBtn.Location=new Point(this.Size.Width-this.printBtn.Size.Width-12, this.printBtn.Location.Y);
            this.flashBtn.Location=new Point(this.printBtn.Location.X-12-this.flashBtn.Size.Width, this.flashBtn.Location.Y);
            this.dataGridView.Size=new Size(this.printBtn.Location.X+this.printBtn.Size.Width-this.dataGridView.Location.X, this.treeView.Location.Y+this.treeView.Size.Height-this.dataGridView.Location.Y);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] temp = this.treeView.SelectedNode.Text.Split(' ');
            int shoppingOrdersId = DButils.getShoppingOrdersId(temp[0]+" "+temp[2]);
            this.dataGridView.DataSource=DButils.getShoppingList(shoppingOrdersId);
        }

        private void flashBtn_Click(object sender, EventArgs e)
        {       
            if (this.treeView.SelectedNode!=null)
            {
                string[] temp = this.treeView.SelectedNode.Text.Split(' ');
                int requisitionOrderId = DButils.getRequisitionOrderId(temp[0]+" "+temp[2], true);
                this.dataGridView.DataSource=DButils.getPurchasingList(requisitionOrderId, false);
                this.ShoppingCheckForm_Load(sender, e);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter="xlsx文件(*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory=false;
            string[] temp = this.treeView.SelectedNode.Text.Split(' ');
            saveFileDialog.FileName=DButils.getShoppingOrdersName(temp[0]+" "+temp[2])+"购买单.xlsx";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                ExcelReport.Export(this.dataGridView, saveFileDialog.FileName.Split('\\')[saveFileDialog.FileName.Split('\\').Length-1].Split('.')[0], saveFileDialog.FileName);
            }
        }
    }
}
