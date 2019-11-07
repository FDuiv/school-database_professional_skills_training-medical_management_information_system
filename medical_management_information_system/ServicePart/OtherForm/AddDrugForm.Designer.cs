namespace medical_management_information_system.ServicePart.OtherForm
{
    partial class AddDrugForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.approvalNumLab = new System.Windows.Forms.Label();
            this.approvalNumTextBox = new System.Windows.Forms.TextBox();
            this.attendingFunctionsLab = new System.Windows.Forms.Label();
            this.attendingFunctionsTextBox = new System.Windows.Forms.TextBox();
            this.tabooTextBox = new System.Windows.Forms.TextBox();
            this.tabooLab = new System.Windows.Forms.Label();
            this.adverseReactionTextBox = new System.Windows.Forms.TextBox();
            this.adverseReactionLab = new System.Windows.Forms.Label();
            this.expirationDateLab = new System.Windows.Forms.Label();
            this.expirationDateTextBox = new System.Windows.Forms.TextBox();
            this.monthLab = new System.Windows.Forms.Label();
            this.unitPriceLab = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.usageTextBox = new System.Windows.Forms.TextBox();
            this.usageLab = new System.Windows.Forms.Label();
            this.yuanLab = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(12, 9);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(53, 12);
            this.nameLab.TabIndex = 0;
            this.nameLab.Text = "药品名：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(71, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // approvalNumLab
            // 
            this.approvalNumLab.AutoSize = true;
            this.approvalNumLab.Location = new System.Drawing.Point(177, 9);
            this.approvalNumLab.Name = "approvalNumLab";
            this.approvalNumLab.Size = new System.Drawing.Size(65, 12);
            this.approvalNumLab.TabIndex = 2;
            this.approvalNumLab.Text = "批准文号：";
            // 
            // approvalNumTextBox
            // 
            this.approvalNumTextBox.Location = new System.Drawing.Point(248, 6);
            this.approvalNumTextBox.Name = "approvalNumTextBox";
            this.approvalNumTextBox.Size = new System.Drawing.Size(88, 21);
            this.approvalNumTextBox.TabIndex = 3;
            this.approvalNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.approvalNumTextBox_KeyPress);
            // 
            // attendingFunctionsLab
            // 
            this.attendingFunctionsLab.AutoSize = true;
            this.attendingFunctionsLab.Location = new System.Drawing.Point(12, 34);
            this.attendingFunctionsLab.Name = "attendingFunctionsLab";
            this.attendingFunctionsLab.Size = new System.Drawing.Size(65, 12);
            this.attendingFunctionsLab.TabIndex = 4;
            this.attendingFunctionsLab.Text = "功能主治：";
            // 
            // attendingFunctionsTextBox
            // 
            this.attendingFunctionsTextBox.Location = new System.Drawing.Point(12, 49);
            this.attendingFunctionsTextBox.Multiline = true;
            this.attendingFunctionsTextBox.Name = "attendingFunctionsTextBox";
            this.attendingFunctionsTextBox.Size = new System.Drawing.Size(159, 173);
            this.attendingFunctionsTextBox.TabIndex = 5;
            // 
            // tabooTextBox
            // 
            this.tabooTextBox.Location = new System.Drawing.Point(177, 49);
            this.tabooTextBox.Multiline = true;
            this.tabooTextBox.Name = "tabooTextBox";
            this.tabooTextBox.Size = new System.Drawing.Size(159, 173);
            this.tabooTextBox.TabIndex = 7;
            // 
            // tabooLab
            // 
            this.tabooLab.AutoSize = true;
            this.tabooLab.Location = new System.Drawing.Point(177, 34);
            this.tabooLab.Name = "tabooLab";
            this.tabooLab.Size = new System.Drawing.Size(41, 12);
            this.tabooLab.TabIndex = 6;
            this.tabooLab.Text = "禁忌：";
            // 
            // adverseReactionTextBox
            // 
            this.adverseReactionTextBox.Location = new System.Drawing.Point(342, 49);
            this.adverseReactionTextBox.Multiline = true;
            this.adverseReactionTextBox.Name = "adverseReactionTextBox";
            this.adverseReactionTextBox.Size = new System.Drawing.Size(159, 173);
            this.adverseReactionTextBox.TabIndex = 9;
            // 
            // adverseReactionLab
            // 
            this.adverseReactionLab.AutoSize = true;
            this.adverseReactionLab.Location = new System.Drawing.Point(342, 34);
            this.adverseReactionLab.Name = "adverseReactionLab";
            this.adverseReactionLab.Size = new System.Drawing.Size(65, 12);
            this.adverseReactionLab.TabIndex = 8;
            this.adverseReactionLab.Text = "不良反应：";
            // 
            // expirationDateLab
            // 
            this.expirationDateLab.AutoSize = true;
            this.expirationDateLab.Location = new System.Drawing.Point(342, 9);
            this.expirationDateLab.Name = "expirationDateLab";
            this.expirationDateLab.Size = new System.Drawing.Size(53, 12);
            this.expirationDateLab.TabIndex = 10;
            this.expirationDateLab.Text = "保质期：";
            // 
            // expirationDateTextBox
            // 
            this.expirationDateTextBox.Location = new System.Drawing.Point(401, 6);
            this.expirationDateTextBox.Name = "expirationDateTextBox";
            this.expirationDateTextBox.Size = new System.Drawing.Size(79, 21);
            this.expirationDateTextBox.TabIndex = 11;
            this.expirationDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expirationDateTextBox_KeyPress);
            // 
            // monthLab
            // 
            this.monthLab.AutoSize = true;
            this.monthLab.Location = new System.Drawing.Point(486, 9);
            this.monthLab.Name = "monthLab";
            this.monthLab.Size = new System.Drawing.Size(17, 12);
            this.monthLab.TabIndex = 12;
            this.monthLab.Text = "月";
            // 
            // unitPriceLab
            // 
            this.unitPriceLab.AutoSize = true;
            this.unitPriceLab.Location = new System.Drawing.Point(507, 9);
            this.unitPriceLab.Name = "unitPriceLab";
            this.unitPriceLab.Size = new System.Drawing.Size(41, 12);
            this.unitPriceLab.TabIndex = 13;
            this.unitPriceLab.Text = "单价：";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(554, 6);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(93, 21);
            this.unitPriceTextBox.TabIndex = 14;
            this.unitPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitPriceTextBox_KeyPress);
            // 
            // usageTextBox
            // 
            this.usageTextBox.Location = new System.Drawing.Point(509, 49);
            this.usageTextBox.Multiline = true;
            this.usageTextBox.Name = "usageTextBox";
            this.usageTextBox.Size = new System.Drawing.Size(159, 173);
            this.usageTextBox.TabIndex = 16;
            // 
            // usageLab
            // 
            this.usageLab.AutoSize = true;
            this.usageLab.Location = new System.Drawing.Point(509, 34);
            this.usageLab.Name = "usageLab";
            this.usageLab.Size = new System.Drawing.Size(65, 12);
            this.usageLab.TabIndex = 15;
            this.usageLab.Text = "服用方法：";
            // 
            // yuanLab
            // 
            this.yuanLab.AutoSize = true;
            this.yuanLab.Location = new System.Drawing.Point(653, 9);
            this.yuanLab.Name = "yuanLab";
            this.yuanLab.Size = new System.Drawing.Size(17, 12);
            this.yuanLab.TabIndex = 17;
            this.yuanLab.Text = "元";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(301, 228);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 261);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.yuanLab);
            this.Controls.Add(this.usageTextBox);
            this.Controls.Add(this.usageLab);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.unitPriceLab);
            this.Controls.Add(this.monthLab);
            this.Controls.Add(this.expirationDateTextBox);
            this.Controls.Add(this.expirationDateLab);
            this.Controls.Add(this.adverseReactionTextBox);
            this.Controls.Add(this.adverseReactionLab);
            this.Controls.Add(this.tabooTextBox);
            this.Controls.Add(this.tabooLab);
            this.Controls.Add(this.attendingFunctionsTextBox);
            this.Controls.Add(this.attendingFunctionsLab);
            this.Controls.Add(this.approvalNumTextBox);
            this.Controls.Add(this.approvalNumLab);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDrugForm";
            this.Text = "AddDrugForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label approvalNumLab;
        private System.Windows.Forms.TextBox approvalNumTextBox;
        private System.Windows.Forms.Label attendingFunctionsLab;
        private System.Windows.Forms.TextBox attendingFunctionsTextBox;
        private System.Windows.Forms.TextBox tabooTextBox;
        private System.Windows.Forms.Label tabooLab;
        private System.Windows.Forms.TextBox adverseReactionTextBox;
        private System.Windows.Forms.Label adverseReactionLab;
        private System.Windows.Forms.Label expirationDateLab;
        private System.Windows.Forms.TextBox expirationDateTextBox;
        private System.Windows.Forms.Label monthLab;
        private System.Windows.Forms.Label unitPriceLab;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox usageTextBox;
        private System.Windows.Forms.Label usageLab;
        private System.Windows.Forms.Label yuanLab;
        private System.Windows.Forms.Button addBtn;
    }
}