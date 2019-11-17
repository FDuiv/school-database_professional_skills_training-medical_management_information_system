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
    public partial class PurchaseOrderForm : Form
    {
        private bool isCompleteFlag = false;
        private string tempDate = "";
        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        public void PurchaseOrderForm_Load(object sender, EventArgs e)
        {

            this.PurchaseOrderForm_SizeChanged(sender, e);
            this.tabControl_SelectedIndexChanged(sender, e);
        }
        private void PurchaseOrderForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent!=null)
            {
                this.Size=this.Parent.Size;
            }
            this.printingBtn.Location=new Point(this.Size.Width-this.printingBtn.Size.Width-12, this.tabControl.Location.Y-7);
            this.tabControl.Size=new Size(221, this.Size.Height-26);
            this.sortByTimeTreeView.Size=new Size(this.tabControl.SelectedTab.Size.Width-13, this.tabControl.SelectedTab.Size.Height-13);
            this.sortByCompletionTreeView.Size=new Size(this.tabControl.SelectedTab.Size.Width-13, this.tabControl.SelectedTab.Size.Height-13);
            this.dataGridView.Size=new Size(this.printingBtn.Location.X+this.printingBtn.Size.Width-this.dataGridView.Location.X, this.Size.Height-50);
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab==this.sortByTimeTabPage)
            {
                string[] purchaseOrders = Program.user.getPurchaseOrders(true,true);
                this.sortByTimeTreeView.Nodes.Clear();
                for (int i = 0; i<purchaseOrders.Length; i++)
                {
                    this.sortByTimeTreeView.Nodes.Add(new TreeNode().Text=purchaseOrders[i]);
                }
            }
            else if (this.tabControl.SelectedTab==this.sortByCompletionTabPage)
            {
                string[] purchaseOrders = Program.user.getPurchaseOrders(true,false);
                this.sortByCompletionTreeView.Nodes.Clear();
                for (int i = 0; i<purchaseOrders.Length; i++)
                {
                    this.sortByCompletionTreeView.Nodes.Add(new TreeNode().Text=purchaseOrders[i]);
                }
            }
        }

        private void printingBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.DataSource==null)
            {
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter="xlsx文件(*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory=false;
            if (this.isCompleteFlag)
            {
                saveFileDialog.FileName="完成日期_"+this.tempDate.Replace("/","-").Replace(":", "-").Replace(" ", "_")+"_采购单.xlsx";
            }
            else
            {
                saveFileDialog.FileName="提交日期_"+this.tempDate.Replace("/", "-").Replace(":", "-").Replace(" ", "_")+"_采购单.xlsx";
            }
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                ExcelReport.Export(this.dataGridView, saveFileDialog.FileName.Split('\\')[saveFileDialog.FileName.Split('\\').Length-1].Split('.')[0], saveFileDialog.FileName);
            }
        }

        private void sortByTimeTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] temp = this.sortByTimeTreeView.SelectedNode.Text.Split(' ');
            int requisitionOrderId = DButils.getRequisitionOrderId(temp[0]+" "+temp[2],true);
            this.dataGridView.DataSource=DButils.getPurchasingList(requisitionOrderId,true);
            this.tempDate=this.sortByTimeTreeView.SelectedNode.Text;
            this.isCompleteFlag=false;
        }

        private void sortByCompletionTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] temp = this.sortByCompletionTreeView.SelectedNode.Text.Split(' ');
            int requisitionOrderId = DButils.getRequisitionOrderId(temp[0]+" "+temp[2],false);
            this.dataGridView.DataSource=DButils.getPurchasingList(requisitionOrderId,true);
            this.tempDate=this.sortByCompletionTreeView.SelectedNode.Text;
            this.isCompleteFlag=true;
        }
    }
}
