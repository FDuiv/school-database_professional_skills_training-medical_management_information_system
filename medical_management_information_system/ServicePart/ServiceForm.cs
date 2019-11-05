﻿
using medical_management_information_system.ServicePart.TabPageModuleForm;
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
        public static bool isLogoff=false;
        public ServiceForm()
        {
            InitializeComponent();
        }
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, bool> jurisdictions = Program.user.getJurisdictions();
            foreach (KeyValuePair<string, bool> kvp in jurisdictions)
            {
                this.Add_TabPage(kvp.Key, this.selectForm(kvp.Key));
            }
            this.tabControl.SelectTab(this.tabControl.Controls[0].Name);
        }
        private void ServiceForm_SizeChanged(object sender, EventArgs e)
        {
            this.tabControl.Location=new Point(this.logoLab.Location.X, this.logoLab.Location.Y+this.logoLab.Size.Height+10);
            this.tabControl.Size=new Size(this.Size.Width-40, this.Size.Height-101);
            this.personalDataBtn.Location=new Point(this.Size.Width-28-this.logoffBtn.Size.Width-6-this.personalDataBtn.Size.Width, this.logoLab.Location.Y+8);
            this.logoffBtn.Location=new Point(this.Size.Width-28-this.logoffBtn.Size.Width, this.logoLab.Location.Y+8);
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
            if (tabPageModuleForm==null)
            {
                return; 
            }
            if (!this.tabControlCheckHave(this.tabControl, tabPageName))
            {
                this.tabControl.TabPages.Add(tabPageName);
                this.tabControl.SelectTab((int)(this.tabControl.TabPages.Count-1));
                this.tabControl.SelectedTab.Name=tabPageName;
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
                case "采购订单页表":
                    return new PurchaseOrderForm(); 
                    break;
                case "请购单页表":
                    return new RequisitionForm();
                    break;
            }
            return null;
        }


    }
}
