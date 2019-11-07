using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management_information_system.ServicePart.OtherForm
{
    public partial class AddDrugForm : Form
    {
        public AddDrugForm(int drug_id=-1)
        {
            InitializeComponent();
            if (drug_id!=-1)
            {
                DataTable dataTable = DButils.getDrugGridView(drug_id,"");
                this.nameTextBox.Text=dataTable.Rows[0][1].ToString();
            }
            else
            {

            }
        }

        private void approvalNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=(e.KeyChar<'0'||e.KeyChar>'9')&&(e.KeyChar<'A'||e.KeyChar>'Z')&&(e.KeyChar<'a'||e.KeyChar>'z');  //允许输入数字//允许输入大写字符//允许输入大写字符
            if (this.approvalNumTextBox.Text.Length>9)
            {
                e.Handled=true;
            }
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
            
        }

        private void expirationDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
        }

        private void unitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
            if (e.KeyChar=='.')  //允许输入回退键
            {
                e.Handled=false;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = this.nameTextBox.Text;
            string approvalNumber=this.approvalNumTextBox.Text;
            string attendingFunctions=this.attendingFunctionsTextBox.Text;
            string taboo=this.tabooTextBox.Text;
            string adverseReaction=adverseReactionTextBox.Text;
            int expirationDate;
            try
            {
                expirationDate = int.Parse(expirationDateTextBox.Text);
            }
            catch
            {
                MessageBox.Show("保质期格式有误！", "警告");
                return;
            }
            string usage=this.usageTextBox.Text;
            double unitPrice;
            try
            {
                unitPrice = double.Parse(this.unitPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("单价格式有误！", "警告");
                return;
            }
            if (name.Length==0)
            {
                MessageBox.Show("药名不能为空！", "警告");
                return;
            }
            if (approvalNumber.Length!=9)
            {
                MessageBox.Show("批准文号格式有错！", "警告");
                return;
            }
            if (attendingFunctions.Length==0)
            {
                MessageBox.Show("功能主治不能为空！", "警告");
                return;
            }
            if (taboo.Length==0)
            {
                MessageBox.Show("禁忌不能为空！", "警告");
                return;
            }
            if (adverseReaction.Length==0)
            {
                MessageBox.Show("不良反应不能为空！", "警告");
                return;
            }
            if (usage.Length==0)
            {
                MessageBox.Show("服用方法不能为空！", "警告");
                return;
            }
            DButils.addDrug(name, approvalNumber, attendingFunctions, taboo, adverseReaction, expirationDate, usage, unitPrice);
            this.Close();
        }
    }
}
