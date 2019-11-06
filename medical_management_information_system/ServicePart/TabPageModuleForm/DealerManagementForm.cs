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
        public DealerManagementForm()
        {
            InitializeComponent();
        }

        public void DealerManagementForm_Load(object sender, EventArgs e)
        {
            this.DealerManagementForm_SizeChanged(sender, e);
        }

        private void DealerManagementForm_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
