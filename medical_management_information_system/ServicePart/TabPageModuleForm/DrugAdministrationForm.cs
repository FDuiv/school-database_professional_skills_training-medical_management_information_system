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
    public partial class DrugAdministrationForm : Form
    {
        public DrugAdministrationForm()
        {
            InitializeComponent();
        }

        public void DrugAdministrationForm_Load(object sender, EventArgs e)
        {
            if (this.Parent!=null)
            {
                this.Size=this.Parent.Size;
            }
            this.DrugAdministrationForm_SizeChanged(sender, e);
            this.dataGridView.DataSource=DButils.getDrugGridView();
        }

        private void DrugAdministrationForm_SizeChanged(object sender, EventArgs e)
        {
            this.printingBtn.Location=new Point(this.Size.Width-this.printingBtn.Size.Width-12, this.printingBtn.Location.Y);
            this.generatePurchaseOrderBtn.Location=new Point(this.printingBtn.Location.X-this.printingBtn.Size.Width-6,this.generatePurchaseOrderBtn.Location.Y);
            this.dataGridView.Size=new Size(this.Size.Width-12, this.Size.Height-12);
        }
    }
}
