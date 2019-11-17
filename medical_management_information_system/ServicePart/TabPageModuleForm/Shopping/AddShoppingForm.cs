using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.TabPageModuleForm.Shopping
{
    public partial class AddShoppingForm : Form
    {
        static public int shoppingNum;
        public AddShoppingForm()
        {
            InitializeComponent();
        }

        private void distributorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddShoppingForm.shoppingNum=int.Parse(this.textBox.Text);
            this.Close();
        }
    }
}
