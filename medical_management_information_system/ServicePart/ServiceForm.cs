
using medical_management_information_system.ServicePart.TabPageModuleForm;
using medical_management_information_system.ServicePart.TabPageModuleForm.Shopping;
using medical_management_information_system.ServicePart.TabPageModuleForm.ShoppingCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace medical_management_information_system.ServicePart
{
    
    public partial class ServiceForm : Form
    {
        private delegate void autoSizeDelegate(object sender, EventArgs e);
        private event autoSizeDelegate autoSizeEvent;
        public static bool isLogoff=false;
        public ServiceForm()
        {
            InitializeComponent();
        }
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            ServiceForm.isLogoff=false;
            Dictionary<string, bool> jurisdictions = Program.user.getJurisdictions();
            foreach (KeyValuePair<string, bool> kvp in jurisdictions)
            {
                if (kvp.Value)
                {
                    this.Add_TabPage(kvp.Key, this.selectForm(kvp.Key));
                }
            }
            this.tabControl.SelectTab(this.tabControl.Controls[0].Name);
            this.ServiceForm_SizeChanged(sender, e);
        }
        private void ServiceForm_SizeChanged(object sender, EventArgs e)
        {
            this.tabControl.Location=new Point(this.logoLab.Location.X, this.logoLab.Location.Y+this.logoLab.Size.Height+10);
            this.tabControl.Size=new Size(this.Size.Width-40, this.Size.Height-101);
            this.personalDataBtn.Location=new Point(this.Size.Width-28-this.logoffBtn.Size.Width-6-this.personalDataBtn.Size.Width, this.logoLab.Location.Y+8);
            this.logoffBtn.Location=new Point(this.Size.Width-28-this.logoffBtn.Size.Width, this.logoLab.Location.Y+8);
            foreach (TabPage tabPage in this.tabControl.TabPages)
            {
                tabPage.Controls[0].Size=tabPage.Size;
            }
        }
        private void personalDataBtn_Click(object sender, EventArgs e)
        {
            BindForm bindForm = new BindForm();
            bindForm.ShowDialog();
        }

        private void logoffBtn_Click(object sender, EventArgs e)
        {
            ServiceForm.isLogoff=true;
            this.Close();
            
        }

        /********************私有功能函数***********************/
        private void Add_TabPage(string tabPageName, Form tabPageModuleForm) //将标题添加进tabpage中
        {

            if (!this.tabControlCheckHave(this.tabControl, tabPageName))
            {
                this.tabControl.TabPages.Add(tabPageName.Substring(0,tabPageName.Length-2));
                this.tabControl.SelectTab((int)(this.tabControl.TabPages.Count-1));
                this.tabControl.SelectedTab.Name=tabPageName;
                if (tabPageModuleForm==null)
                {
                    this.tabControl.TabPages.Remove(this.tabControl.SelectedTab);
                    return;
                }
                
                tabPageModuleForm.FormBorderStyle=FormBorderStyle.None;     
                tabPageModuleForm.TopLevel=false;
                tabPageModuleForm.Show();
                tabPageModuleForm.Parent=this.tabControl.SelectedTab;

            }
        }
        private bool tabControlCheckHave(TabControl tab, string tabPageName) //看tabpage中是否已有窗体
        {
            for (int i = 0; i<tab.TabCount; i++)
            {
                if (tab.TabPages[i].Name==tabPageName)
                {
                    tab.SelectedIndex=i;
                    return true;
                }
            }
            return false;
        }
        private Form selectForm(string formName)
        {
            switch (formName)
            {
                case "药品管理页表":
                    DrugAdministrationForm drugAdministrationForm = new DrugAdministrationForm();
                    this.autoSizeEvent+=drugAdministrationForm.DrugAdministrationForm_Load;
                    return drugAdministrationForm;
                case "经销商管理页表":
                    DealerManagementForm dealerManagementForm = new DealerManagementForm();
                    this.autoSizeEvent+=dealerManagementForm.DealerManagementForm_Load;
                    return dealerManagementForm;
                case "采购订单页表":
                    PurchaseOrderForm purchaseOrderForm = new PurchaseOrderForm();
                    this.autoSizeEvent+=purchaseOrderForm.PurchaseOrderForm_Load;
                    return purchaseOrderForm; 
                case "请购单页表":
                    RequisitionForm requisitionForm = new RequisitionForm();
                    this.autoSizeEvent+=requisitionForm.RequisitionForm_Load;
                    return requisitionForm;
                case "购物窗口页表":
                    ShoppingForm shoppingForm = new ShoppingForm();
                    this.autoSizeEvent+=shoppingForm.ShoppingForm_Load;
                    return shoppingForm;
                case "购物单页表":
                    ShoppingCheckForm shoppingCheckForm = new ShoppingCheckForm();
                    this.autoSizeEvent+=shoppingCheckForm.ShoppingCheckForm_Load;
                    return shoppingCheckForm;
            }
            return null;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.autoSizeEvent(sender,e);
        }
    }
}
