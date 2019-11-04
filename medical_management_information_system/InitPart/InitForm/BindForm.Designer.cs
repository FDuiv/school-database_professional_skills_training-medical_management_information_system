namespace medical_management_information_system
{
    partial class BindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.branchLab = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLab = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLab = new System.Windows.Forms.Label();
            this.birthDayLab = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.yearLab = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.monthLab = new System.Windows.Forms.Label();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.dayLab = new System.Windows.Forms.Label();
            this.addrLab = new System.Windows.Forms.Label();
            this.addrTextBox = new System.Windows.Forms.TextBox();
            this.phoneLab = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.sureBtn = new System.Windows.Forms.Button();
            this.companyLab = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.departmentLab = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // branchComboBox
            // 
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(77, 92);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(295, 20);
            this.branchComboBox.TabIndex = 0;
            this.branchComboBox.TextChanged += new System.EventHandler(this.branchComboBox_TextChanged);
            this.branchComboBox.Enter += new System.EventHandler(this.branchComboBox_Enter);
            this.branchComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.branchComboBox_KeyPress);
            // 
            // branchLab
            // 
            this.branchLab.AutoSize = true;
            this.branchLab.Location = new System.Drawing.Point(6, 95);
            this.branchLab.Name = "branchLab";
            this.branchLab.Size = new System.Drawing.Size(65, 12);
            this.branchLab.TabIndex = 1;
            this.branchLab.Text = "所属分部：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(59, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(139, 21);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(12, 9);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(41, 12);
            this.nameLab.TabIndex = 3;
            this.nameLab.Text = "姓名：";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(251, 6);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 20);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.Click += new System.EventHandler(this.genderComboBox_Click);
            this.genderComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderComboBox_KeyPress);
            // 
            // genderLab
            // 
            this.genderLab.AutoSize = true;
            this.genderLab.Location = new System.Drawing.Point(204, 9);
            this.genderLab.Name = "genderLab";
            this.genderLab.Size = new System.Drawing.Size(41, 12);
            this.genderLab.TabIndex = 5;
            this.genderLab.Text = "性别：";
            // 
            // birthDayLab
            // 
            this.birthDayLab.AutoSize = true;
            this.birthDayLab.Location = new System.Drawing.Point(6, 36);
            this.birthDayLab.Name = "birthDayLab";
            this.birthDayLab.Size = new System.Drawing.Size(65, 12);
            this.birthDayLab.TabIndex = 6;
            this.birthDayLab.Text = "出生日期：";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(77, 33);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 20);
            this.yearComboBox.TabIndex = 7;
            this.yearComboBox.Enter += new System.EventHandler(this.yearComboBox_Enter);
            this.yearComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearComboBox_KeyPress);
            // 
            // yearLab
            // 
            this.yearLab.AutoSize = true;
            this.yearLab.Location = new System.Drawing.Point(204, 36);
            this.yearLab.Name = "yearLab";
            this.yearLab.Size = new System.Drawing.Size(17, 12);
            this.yearLab.TabIndex = 8;
            this.yearLab.Text = "年";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(227, 33);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(47, 20);
            this.monthComboBox.TabIndex = 9;
            this.monthComboBox.Enter += new System.EventHandler(this.monthComboBox_Enter);
            this.monthComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthComboBox_KeyPress);
            // 
            // monthLab
            // 
            this.monthLab.AutoSize = true;
            this.monthLab.Location = new System.Drawing.Point(280, 36);
            this.monthLab.Name = "monthLab";
            this.monthLab.Size = new System.Drawing.Size(17, 12);
            this.monthLab.TabIndex = 10;
            this.monthLab.Text = "月";
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(303, 33);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(46, 20);
            this.dayComboBox.TabIndex = 11;
            this.dayComboBox.Enter += new System.EventHandler(this.dayComboBox_Enter);
            this.dayComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dayComboBox_KeyPress);
            // 
            // dayLab
            // 
            this.dayLab.AutoSize = true;
            this.dayLab.Location = new System.Drawing.Point(355, 36);
            this.dayLab.Name = "dayLab";
            this.dayLab.Size = new System.Drawing.Size(17, 12);
            this.dayLab.TabIndex = 12;
            this.dayLab.Text = "日";
            // 
            // addrLab
            // 
            this.addrLab.AutoSize = true;
            this.addrLab.Location = new System.Drawing.Point(12, 153);
            this.addrLab.Name = "addrLab";
            this.addrLab.Size = new System.Drawing.Size(161, 12);
            this.addrLab.TabIndex = 13;
            this.addrLab.Text = "住址（多个住址用；分割）：";
            // 
            // addrTextBox
            // 
            this.addrTextBox.Location = new System.Drawing.Point(8, 168);
            this.addrTextBox.Multiline = true;
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(190, 101);
            this.addrTextBox.TabIndex = 14;
            // 
            // phoneLab
            // 
            this.phoneLab.AutoSize = true;
            this.phoneLab.Location = new System.Drawing.Point(204, 153);
            this.phoneLab.Name = "phoneLab";
            this.phoneLab.Size = new System.Drawing.Size(161, 12);
            this.phoneLab.TabIndex = 15;
            this.phoneLab.Text = "电话（多个电话用；分割）：";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(204, 168);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(168, 101);
            this.phoneTextBox.TabIndex = 16;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // sureBtn
            // 
            this.sureBtn.Location = new System.Drawing.Point(161, 275);
            this.sureBtn.Name = "sureBtn";
            this.sureBtn.Size = new System.Drawing.Size(75, 23);
            this.sureBtn.TabIndex = 17;
            this.sureBtn.Text = "确定";
            this.sureBtn.UseVisualStyleBackColor = true;
            this.sureBtn.Click += new System.EventHandler(this.sureBtn_Click);
            // 
            // companyLab
            // 
            this.companyLab.AutoSize = true;
            this.companyLab.Location = new System.Drawing.Point(6, 69);
            this.companyLab.Name = "companyLab";
            this.companyLab.Size = new System.Drawing.Size(65, 12);
            this.companyLab.TabIndex = 19;
            this.companyLab.Text = "所属公司：";
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(77, 66);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(295, 20);
            this.companyComboBox.TabIndex = 18;
            this.companyComboBox.TextChanged += new System.EventHandler(this.companyComboBox_TextChanged);
            this.companyComboBox.Enter += new System.EventHandler(this.companyComboBox_Enter);
            this.companyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companyComboBox_KeyPress);
            // 
            // departmentLab
            // 
            this.departmentLab.AutoSize = true;
            this.departmentLab.Location = new System.Drawing.Point(6, 121);
            this.departmentLab.Name = "departmentLab";
            this.departmentLab.Size = new System.Drawing.Size(65, 12);
            this.departmentLab.TabIndex = 21;
            this.departmentLab.Text = "所属部门：";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(77, 118);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(295, 20);
            this.departmentComboBox.TabIndex = 20;
            this.departmentComboBox.Enter += new System.EventHandler(this.departmentComboBox_Enter);
            this.departmentComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.departmentComboBox_KeyPress);
            // 
            // BindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.departmentLab);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.companyLab);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.sureBtn);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLab);
            this.Controls.Add(this.addrTextBox);
            this.Controls.Add(this.addrLab);
            this.Controls.Add(this.dayLab);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.monthLab);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearLab);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.birthDayLab);
            this.Controls.Add(this.genderLab);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.branchLab);
            this.Controls.Add(this.branchComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BindForm";
            this.Text = "BindForm";
            this.Load += new System.EventHandler(this.BindForm_Load);
            this.Shown += new System.EventHandler(this.BindForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Label branchLab;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLab;
        private System.Windows.Forms.Label birthDayLab;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label yearLab;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label monthLab;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Label dayLab;
        private System.Windows.Forms.Label addrLab;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.Label phoneLab;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button sureBtn;
        private System.Windows.Forms.Label companyLab;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label departmentLab;
        private System.Windows.Forms.ComboBox departmentComboBox;
    }
}