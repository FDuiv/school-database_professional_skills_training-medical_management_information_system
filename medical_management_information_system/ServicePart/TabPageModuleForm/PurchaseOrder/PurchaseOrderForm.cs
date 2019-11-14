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

        }
    }
}
