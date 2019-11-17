using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.TabPageModuleForm.Requisition
{
    public partial class SelectPharmaceutical : Form
    {
        private int purchasingListId;
        private int drugId;
        public SelectPharmaceutical(int purchasingListId,int drugId)
        {
            InitializeComponent();
            this.purchasingListId=purchasingListId;
            this.drugId=drugId;
        }

        private void SelectPharmaceutical_Load(object sender, EventArgs e)
        {
            string[] distributorNames = DButils.getDistributorWithDrug(this.drugId);
            this.comboBox.Items.Clear();
            for (int i = 0; i<distributorNames.Count(); i++)
            {
                this.comboBox.Items.Add(distributorNames[i]);
            }
        }

        private void sureBtn_Click(object sender, EventArgs e)
        {
            DButils.updateDistributorDrug(this.purchasingListId,DButils.getDistributorId(this.comboBox.Text));
            this.Close();
        }
    }
}
