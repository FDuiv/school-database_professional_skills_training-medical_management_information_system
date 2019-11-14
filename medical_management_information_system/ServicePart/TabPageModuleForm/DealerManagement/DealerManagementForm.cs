using medical_management_information_system.ServicePart.OtherForm;
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
    public partial class DealerManagementForm : Form
    {
        private TreeNode beforeSelectNode=new TreeNode();
        public DealerManagementForm()
        {
            InitializeComponent();
            this.treeView.Nodes.Clear();
            string[] companyNames = DButils.getPharmaceuticalDistributorCompanys();
            for (int i = 0; i<companyNames.Length; i++)
            {
                TreeNode node = new TreeNode(companyNames[i]);
                this.treeView.Nodes.Add(node);
                string[] distributorNames = DButils.getPharmaceuticalDistributors(companyNames[i]);
                for (int j = 0; j<distributorNames.Length; j++)
                {
                    node.Nodes.Add(distributorNames[j]);
                }
            }
        }

        public void DealerManagementForm_Load(object sender, EventArgs e)
        {
            this.DealerManagementForm_SizeChanged(sender, e);
            this.deleteBtn.Enabled=false;
            this.printingBtn.Enabled=false;

        }

        private void DealerManagementForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Parent!=null)
            {
                this.Size=this.Parent.Size;
            }
            this.printingBtn.Location=new Point(this.Size.Width-this.printingBtn.Size.Width-12, this.treeView.Location.Y);
            this.flashBtn.Location=new Point(this.printingBtn.Location.X-6-this.flashBtn.Size.Width, this.flashBtn.Location.Y);
            this.treeView.Size=new Size(this.treeView.Width,this.Size.Height-26);
            this.dataGridView.Size=new Size(this.printingBtn.Location.X+this.printingBtn.Size.Width-this.dataGridView.Location.X, this.treeView.Location.Y+this.treeView.Height-this.dataGridView.Location.Y);

        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //this.treeView.SelectedNode
            if (this.treeView.SelectedNode.Parent!=null&&this.treeView.SelectedNode!=null)
            {
                (new EditDealerForm(DButils.getPharmaceuticalId(this.treeView.SelectedNode.Parent.Text, this.treeView.SelectedNode.Text))).ShowDialog();
                int distributorId = DButils.getPharmaceuticalId(this.treeView.SelectedNode.Parent.Text, this.treeView.SelectedNode.Text);
                this.dataGridView.DataSource=DButils.getDistributorDrug(distributorId);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            (new AddPharmaceuticalForm()).ShowDialog();
            this.flashBtn_Click(sender, e);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除"+this.treeView.SelectedNode.Text+"？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                if (this.treeView.Nodes.Contains(this.treeView.SelectedNode))
                {
                    //选择了公司
                    DButils.deletePharmaceuticalCompany(this.treeView.SelectedNode.Text);
                }
                else
                {
                    //选择了部门
                    DButils.deletePharmaceuticalDistributor(this.treeView.SelectedNode.Parent.Text, this.treeView.SelectedNode.Text);
                }
                this.flashBtn_Click(sender, e);
            }
            
            
            
        }

        private void flashBtn_Click(object sender, EventArgs e)
        {
            this.treeView.Nodes.Clear();
            string[] companyNames = DButils.getPharmaceuticalDistributorCompanys();
            for (int i = 0; i<companyNames.Length; i++)
            {
                TreeNode node = new TreeNode(companyNames[i]);
                this.treeView.Nodes.Add(node);
                string[] distributorNames = DButils.getPharmaceuticalDistributors(companyNames[i]);
                for (int j = 0; j<distributorNames.Length; j++)
                {
                    node.Nodes.Add(distributorNames[j]);
                }
            }
            this.DealerManagementForm_Load(sender,e);

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.deleteBtn.Enabled=true;
            this.beforeSelectNode.ForeColor=Color.Black;
            this.treeView.SelectedNode.ForeColor=Color.Red;
            this.beforeSelectNode=this.treeView.SelectedNode;

            if (this.treeView.SelectedNode.Parent!=null)
            {
                int distributorId = DButils.getPharmaceuticalId(this.treeView.SelectedNode.Parent.Text, this.treeView.SelectedNode.Text);
                this.dataGridView.DataSource=DButils.getDistributorDrug(distributorId);
            }
            else
            {
                this.dataGridView.DataSource=null; 
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.flashBtn_Click(sender, e);
        }

        private void printingBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter="xlsx文件(*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory=false;
            saveFileDialog.FileName="经销商提供的药品.xlsx";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                ExcelReport.Export(this.dataGridView, saveFileDialog.FileName.Split('\\')[saveFileDialog.FileName.Split('\\').Length-1].Split('.')[0], saveFileDialog.FileName);
            }
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridView.DataSource==null)
            {
                this.printingBtn.Enabled=false;
            }
            else
            {
                this.printingBtn.Enabled=true;
            }
        }
    }
}
