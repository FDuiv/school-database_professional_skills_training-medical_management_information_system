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
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_SizeChanged(object sender, EventArgs e)
        {
            this.tabControl.Location=new Point(this.logoLab.Location.X, this.logoLab.Location.Y+this.logoLab.Size.Height+10);
            this.tabControl.Size=new Size(this.Size.Width-40, this.Size.Height-101);
            this.personalDataBtn.Location=new Point(this.Size.Width-28-this.setBtn.Size.Width-6-this.personalDataBtn.Size.Width, this.logoLab.Location.Y+8);
            this.setBtn.Location=new Point(this.Size.Width-28-this.setBtn.Size.Width, this.logoLab.Location.Y+8);
        }

        private void personalDataBtn_Click(object sender, EventArgs e)
        {
            BindForm bindForm = new BindForm();
            bindForm.ShowDialog();
        }
    }
}
