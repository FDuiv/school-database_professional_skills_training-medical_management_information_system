﻿using System;
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
            if (this.Parent!=null)
            {
                this.Size=this.Parent.Size;
            }
        }
    }
}
