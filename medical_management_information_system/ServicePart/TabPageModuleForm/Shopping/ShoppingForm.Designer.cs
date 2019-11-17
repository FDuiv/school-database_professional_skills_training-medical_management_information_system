namespace medical_management_information_system.ServicePart.TabPageModuleForm.Shopping
{
    partial class ShoppingForm
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
            this.nameLab = new System.Windows.Forms.Label();
            this.genderLab = new System.Windows.Forms.Label();
            this.dayLab = new System.Windows.Forms.Label();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.monthLab = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearLab = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.birthDayLab = new System.Windows.Forms.Label();
            this.identificationNumberLab = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLab = new System.Windows.Forms.Label();
            this.addrTextBox = new System.Windows.Forms.TextBox();
            this.addrLab = new System.Windows.Forms.Label();
            this.leftDataGridView = new System.Windows.Forms.DataGridView();
            this.rightDataGridView = new System.Windows.Forms.DataGridView();
            this.leftLab = new System.Windows.Forms.Label();
            this.rightLab = new System.Windows.Forms.Label();
            this.leftComboBox = new System.Windows.Forms.ComboBox();
            this.rightComboBox = new System.Windows.Forms.ComboBox();
            this.sureBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.identificationNumberTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(10, 30);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(41, 12);
            this.nameLab.TabIndex = 0;
            this.nameLab.Text = "姓名：";
            // 
            // genderLab
            // 
            this.genderLab.AutoSize = true;
            this.genderLab.Location = new System.Drawing.Point(210, 30);
            this.genderLab.Name = "genderLab";
            this.genderLab.Size = new System.Drawing.Size(41, 12);
            this.genderLab.TabIndex = 1;
            this.genderLab.Text = "性别：";
            // 
            // dayLab
            // 
            this.dayLab.AutoSize = true;
            this.dayLab.Location = new System.Drawing.Point(363, 78);
            this.dayLab.Name = "dayLab";
            this.dayLab.Size = new System.Drawing.Size(17, 12);
            this.dayLab.TabIndex = 19;
            this.dayLab.Text = "日";
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(311, 75);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(46, 20);
            this.dayComboBox.TabIndex = 18;
            this.dayComboBox.Enter += new System.EventHandler(this.dayComboBox_Enter);
            this.dayComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dayComboBox_KeyPress);
            // 
            // monthLab
            // 
            this.monthLab.AutoSize = true;
            this.monthLab.Location = new System.Drawing.Point(288, 78);
            this.monthLab.Name = "monthLab";
            this.monthLab.Size = new System.Drawing.Size(17, 12);
            this.monthLab.TabIndex = 17;
            this.monthLab.Text = "月";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(235, 75);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(47, 20);
            this.monthComboBox.TabIndex = 16;
            this.monthComboBox.Enter += new System.EventHandler(this.monthComboBox_Enter);
            this.monthComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthComboBox_KeyPress);
            // 
            // yearLab
            // 
            this.yearLab.AutoSize = true;
            this.yearLab.Location = new System.Drawing.Point(212, 78);
            this.yearLab.Name = "yearLab";
            this.yearLab.Size = new System.Drawing.Size(17, 12);
            this.yearLab.TabIndex = 15;
            this.yearLab.Text = "年";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(83, 75);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 20);
            this.yearComboBox.TabIndex = 14;
            this.yearComboBox.Enter += new System.EventHandler(this.yearComboBox_Enter);
            this.yearComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearComboBox_KeyPress);
            // 
            // birthDayLab
            // 
            this.birthDayLab.AutoSize = true;
            this.birthDayLab.Location = new System.Drawing.Point(12, 78);
            this.birthDayLab.Name = "birthDayLab";
            this.birthDayLab.Size = new System.Drawing.Size(65, 12);
            this.birthDayLab.TabIndex = 13;
            this.birthDayLab.Text = "出生日期：";
            // 
            // identificationNumberLab
            // 
            this.identificationNumberLab.AutoSize = true;
            this.identificationNumberLab.Location = new System.Drawing.Point(10, 124);
            this.identificationNumberLab.Name = "identificationNumberLab";
            this.identificationNumberLab.Size = new System.Drawing.Size(77, 12);
            this.identificationNumberLab.TabIndex = 20;
            this.identificationNumberLab.Text = "身份证号码：";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(575, 27);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(197, 117);
            this.phoneTextBox.TabIndex = 24;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // phoneLab
            // 
            this.phoneLab.AutoSize = true;
            this.phoneLab.Location = new System.Drawing.Point(573, 12);
            this.phoneLab.Name = "phoneLab";
            this.phoneLab.Size = new System.Drawing.Size(161, 12);
            this.phoneLab.TabIndex = 23;
            this.phoneLab.Text = "电话（多个电话用；分割）：";
            // 
            // addrTextBox
            // 
            this.addrTextBox.Location = new System.Drawing.Point(382, 27);
            this.addrTextBox.Multiline = true;
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(190, 117);
            this.addrTextBox.TabIndex = 22;
            // 
            // addrLab
            // 
            this.addrLab.AutoSize = true;
            this.addrLab.Location = new System.Drawing.Point(384, 12);
            this.addrLab.Name = "addrLab";
            this.addrLab.Size = new System.Drawing.Size(161, 12);
            this.addrLab.TabIndex = 21;
            this.addrLab.Text = "住址（多个住址用；分割）：";
            // 
            // leftDataGridView
            // 
            this.leftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leftDataGridView.Location = new System.Drawing.Point(14, 173);
            this.leftDataGridView.Name = "leftDataGridView";
            this.leftDataGridView.RowTemplate.Height = 23;
            this.leftDataGridView.Size = new System.Drawing.Size(364, 276);
            this.leftDataGridView.TabIndex = 25;
            this.leftDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leftDataGridView_CellDoubleClick);
            // 
            // rightDataGridView
            // 
            this.rightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rightDataGridView.Location = new System.Drawing.Point(382, 173);
            this.rightDataGridView.Name = "rightDataGridView";
            this.rightDataGridView.RowTemplate.Height = 23;
            this.rightDataGridView.Size = new System.Drawing.Size(390, 276);
            this.rightDataGridView.TabIndex = 26;
            this.rightDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rightDataGridView_CellDoubleClick);
            // 
            // leftLab
            // 
            this.leftLab.AutoSize = true;
            this.leftLab.Location = new System.Drawing.Point(12, 153);
            this.leftLab.Name = "leftLab";
            this.leftLab.Size = new System.Drawing.Size(41, 12);
            this.leftLab.TabIndex = 27;
            this.leftLab.Text = "药名：";
            // 
            // rightLab
            // 
            this.rightLab.AutoSize = true;
            this.rightLab.Location = new System.Drawing.Point(380, 153);
            this.rightLab.Name = "rightLab";
            this.rightLab.Size = new System.Drawing.Size(41, 12);
            this.rightLab.TabIndex = 28;
            this.rightLab.Text = "药名：";
            // 
            // leftComboBox
            // 
            this.leftComboBox.FormattingEnabled = true;
            this.leftComboBox.Location = new System.Drawing.Point(57, 150);
            this.leftComboBox.Name = "leftComboBox";
            this.leftComboBox.Size = new System.Drawing.Size(121, 20);
            this.leftComboBox.TabIndex = 29;
            this.leftComboBox.TextChanged += new System.EventHandler(this.leftComboBox_TextChanged);
            // 
            // rightComboBox
            // 
            this.rightComboBox.FormattingEnabled = true;
            this.rightComboBox.Location = new System.Drawing.Point(424, 150);
            this.rightComboBox.Name = "rightComboBox";
            this.rightComboBox.Size = new System.Drawing.Size(121, 20);
            this.rightComboBox.TabIndex = 30;
            this.rightComboBox.TextChanged += new System.EventHandler(this.rightComboBox_TextChanged);
            // 
            // sureBtn
            // 
            this.sureBtn.Location = new System.Drawing.Point(697, 148);
            this.sureBtn.Name = "sureBtn";
            this.sureBtn.Size = new System.Drawing.Size(75, 23);
            this.sureBtn.TabIndex = 31;
            this.sureBtn.Text = "确定";
            this.sureBtn.UseVisualStyleBackColor = true;
            this.sureBtn.Click += new System.EventHandler(this.sureBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(57, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(145, 21);
            this.nameTextBox.TabIndex = 32;
            // 
            // identificationNumberTextBox
            // 
            this.identificationNumberTextBox.Location = new System.Drawing.Point(93, 121);
            this.identificationNumberTextBox.Name = "identificationNumberTextBox";
            this.identificationNumberTextBox.Size = new System.Drawing.Size(283, 21);
            this.identificationNumberTextBox.TabIndex = 34;
            this.identificationNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.identificationNumberTextBox_KeyPress);
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(255, 27);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 20);
            this.genderComboBox.TabIndex = 35;
            this.genderComboBox.Click += new System.EventHandler(this.genderComboBox_Click);
            this.genderComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderComboBox_KeyPress);
            // 
            // ShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.identificationNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.sureBtn);
            this.Controls.Add(this.rightComboBox);
            this.Controls.Add(this.leftComboBox);
            this.Controls.Add(this.rightLab);
            this.Controls.Add(this.leftLab);
            this.Controls.Add(this.rightDataGridView);
            this.Controls.Add(this.leftDataGridView);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLab);
            this.Controls.Add(this.addrTextBox);
            this.Controls.Add(this.addrLab);
            this.Controls.Add(this.identificationNumberLab);
            this.Controls.Add(this.dayLab);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.monthLab);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearLab);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.birthDayLab);
            this.Controls.Add(this.genderLab);
            this.Controls.Add(this.nameLab);
            this.Name = "ShoppingForm";
            this.Text = "ShoppingForm";
            this.Load += new System.EventHandler(this.ShoppingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label genderLab;
        private System.Windows.Forms.Label dayLab;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Label monthLab;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label yearLab;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label birthDayLab;
        private System.Windows.Forms.Label identificationNumberLab;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLab;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.Label addrLab;
        private System.Windows.Forms.DataGridView leftDataGridView;
        private System.Windows.Forms.DataGridView rightDataGridView;
        private System.Windows.Forms.Label leftLab;
        private System.Windows.Forms.Label rightLab;
        private System.Windows.Forms.ComboBox leftComboBox;
        private System.Windows.Forms.ComboBox rightComboBox;
        private System.Windows.Forms.Button sureBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox identificationNumberTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
    }
}