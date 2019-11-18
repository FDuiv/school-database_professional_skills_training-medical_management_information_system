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
    public partial class ShoppingForm : Form
    {
        private List<string[]> shoppingDrugIds;
        public ShoppingForm()
        {
            InitializeComponent();
            this.shoppingDrugIds=new List<string[]>();
            string[] strs = { "0", "0"};
            this.shoppingDrugIds.Add(strs);
        }

        public void ShoppingForm_Load(object sender, EventArgs e)
        {
            
            this.leftComboBox_TextChanged(sender, e);
            this.rightComboBox_TextChanged(sender, e);
        }

        private void genderComboBox_Click(object sender, EventArgs e)
        {
            this.genderComboBox.Items.Clear();
            this.genderComboBox.Items.Add("男");
            this.genderComboBox.Items.Add("女");
        }

        private void genderComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void yearComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void monthComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void dayComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void yearComboBox_Enter(object sender, EventArgs e)
        {
            this.yearComboBox.Items.Clear();
            for (int i = 1970; i<=int.Parse(DateTime.Now.ToString("yyyy")); i++)
            {
                this.yearComboBox.Items.Add(i);
            }
        }

        private void monthComboBox_Enter(object sender, EventArgs e)
        {
            this.monthComboBox.Items.Clear();
            for (int i = 1; i<=12; i++)
            {
                this.monthComboBox.Items.Add(i);
            }
        }

        private void dayComboBox_Enter(object sender, EventArgs e)
        {
            this.dayComboBox.Items.Clear();
            int year = int.Parse(this.yearComboBox.Text);
            int month = int.Parse(this.monthComboBox.Text);
            int day = 0;
            if (month==4||month==6||month==10||month==11)
            {
                day=30;
            }
            else if (month==2)
            {
                if (year%4==0&&year%100!=0||year%400==0)
                {
                    day=29;
                }
                else
                {
                    day=28;
                }
            }
            else
            {
                day=31;
            }
            for (int i = 1; i<=day; i++)
            {
                this.dayComboBox.Items.Add(i);
            }
        }

        private void identificationNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=e.KeyChar<'0'||e.KeyChar>'9';  //允许输入数字
            if (e.KeyChar==(char)8)  //允许输入回退键
            {
                e.Handled=false;
            }
            if (e.KeyChar=='；')
            {
                e.Handled=false;
            }
        }

        private void leftComboBox_TextChanged(object sender, EventArgs e)
        {
            List<string> strs=new List<string>();
            for (int i = 0; i<this.shoppingDrugIds.Count; i++)
            {
                strs.Add(this.shoppingDrugIds[i][0]);
            }
            this.leftDataGridView.DataSource=DButils.getPurchaseDrug(strs, this.leftComboBox.Text, false);
            this.leftComboBox.Items.Clear();
            for (int i = 0; i<((DataTable)this.leftDataGridView.DataSource).Rows.Count; i++)
            {
                this.leftComboBox.Items.Add(((DataTable)this.leftDataGridView.DataSource).Rows[i][1]);
            }
        }

        private void rightComboBox_TextChanged(object sender, EventArgs e)
        {
            List<string> strs = new List<string>();
            for (int i = 0; i<this.shoppingDrugIds.Count; i++)
            {
                strs.Add(this.shoppingDrugIds[i][0]);
            }
            this.rightDataGridView.DataSource=DButils.getPurchaseDrug(strs, this.rightComboBox.Text, true);
            this.rightComboBox.Items.Clear();
            for (int i = 0; i<((DataTable)this.rightDataGridView.DataSource).Rows.Count; i++)
            {
                this.rightComboBox.Items.Add(((DataTable)this.rightDataGridView.DataSource).Rows[i][1]);
            }
        }

        private void sureBtn_Click(object sender, EventArgs e)
        {
            string name = this.nameTextBox.Text;
            string gender = this.genderComboBox.Text;
            string birthDay = this.yearComboBox.Text+"-"+this.monthComboBox.Text+"-"+this.dayComboBox.Text;
            string identity = this.identificationNumberTextBox.Text;
            string[] addrs = this.addrTextBox.Text.Split('；');
            string[] phones = this.phoneTextBox.Text.Split('；');
            List<string> drugIds = new List<string>();
            for (int i = 0; i<this.shoppingDrugIds.Count; i++)
            {
                drugIds.Add(this.shoppingDrugIds[i][0]);
            }
            //有效性检测
            if (name=="")
            {
                MessageBox.Show("名字不能为空！", "警告");
                return;
            }
            if (gender=="")
            {
                MessageBox.Show("请选择性别！", "警告");
                return;
            }
            if (identity.Length!=18)
            {
                MessageBox.Show("身份证号码格式有误！", "警告");
                return;
            }

            int addrFlag = 0;
            List<string> addrsNew = new List<string>();
            for (int i = 0; i<addrs.Length; i++)
            {
                if (addrs[i]!="")
                {
                    addrFlag=1;
                    addrsNew.Add(addrs[i]);
                }
            }
            if (addrFlag==0)
            {
                MessageBox.Show("地址不能为空！", "警告");
                return;
            }

            int phoneFlag = 0;
            List<string> phonesNew = new List<string>();
            for (int i = 0; i<phones.Length; i++)
            {
                if (phones[i].Length>11)
                {
                    MessageBox.Show("电话格式不正确！", "警告");
                    return;
                }
                if (phones[i]!="")
                {
                    phoneFlag=1;
                    phonesNew.Add(phones[i]);
                }
            }
            if (phoneFlag==0)
            {
                MessageBox.Show("电话不能为空！", "警告");
                return;
            }

            int clientId = DButils.addClient(name,gender,birthDay, identity, addrsNew,phonesNew);
;           int shoppingOrdersId = Program.user.addShoppingOrders(clientId);
            for (int i = 1; i<this.shoppingDrugIds.Count; i++)
            {
                float unitPrice=DButils.getDrugUnitPrice(int.Parse(this.shoppingDrugIds[i][0]));
                DButils.addShoppingList(shoppingOrdersId,int.Parse(this.shoppingDrugIds[i][0]), int.Parse(this.shoppingDrugIds[i][1]), unitPrice);
            }
            MessageBox.Show("录入成功！", "警告");
            this.ShoppingForm_Load(sender,e);
        }

        private void rightDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new AddShoppingForm().ShowDialog();
            string[] strs = { this.rightDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),AddShoppingForm.shoppingNum.ToString()};
            this.shoppingDrugIds.Add(strs);
            this.leftComboBox_TextChanged(sender, e);
            this.rightComboBox_TextChanged(sender, e);
        }

        private void leftDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i<this.shoppingDrugIds.Count; i++)
            {
                if (this.shoppingDrugIds[i][0]==this.leftDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    this.shoppingDrugIds.Remove(this.shoppingDrugIds[i]);
                }
            }
            this.leftComboBox_TextChanged(sender, e);
            this.rightComboBox_TextChanged(sender, e);
        }
    }
}
