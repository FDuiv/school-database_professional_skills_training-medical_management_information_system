namespace medical_management_information_system.ServicePart.OtherForm
{
    partial class AddPharmaceuticalForm
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
            this.companyNameLab = new System.Windows.Forms.Label();
            this.DistributorLab = new System.Windows.Forms.Label();
            this.distributorTextBox = new System.Windows.Forms.TextBox();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyNameLab
            // 
            this.companyNameLab.AutoSize = true;
            this.companyNameLab.Location = new System.Drawing.Point(98, 94);
            this.companyNameLab.Name = "companyNameLab";
            this.companyNameLab.Size = new System.Drawing.Size(53, 12);
            this.companyNameLab.TabIndex = 0;
            this.companyNameLab.Text = "公司名：";
            // 
            // DistributorLab
            // 
            this.DistributorLab.AutoSize = true;
            this.DistributorLab.Location = new System.Drawing.Point(98, 121);
            this.DistributorLab.Name = "DistributorLab";
            this.DistributorLab.Size = new System.Drawing.Size(53, 12);
            this.DistributorLab.TabIndex = 1;
            this.DistributorLab.Text = "分部名：";
            // 
            // distributorTextBox
            // 
            this.distributorTextBox.Location = new System.Drawing.Point(157, 118);
            this.distributorTextBox.Name = "distributorTextBox";
            this.distributorTextBox.Size = new System.Drawing.Size(121, 21);
            this.distributorTextBox.TabIndex = 3;
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(157, 91);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(121, 20);
            this.companyComboBox.TabIndex = 4;
            this.companyComboBox.Enter += new System.EventHandler(this.companyComboBox_Enter);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(157, 226);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddPharmaceuticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.distributorTextBox);
            this.Controls.Add(this.DistributorLab);
            this.Controls.Add(this.companyNameLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPharmaceuticalForm";
            this.Text = "AddPharmaceuticalForm";
            this.Load += new System.EventHandler(this.AddPharmaceuticalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLab;
        private System.Windows.Forms.Label DistributorLab;
        private System.Windows.Forms.TextBox distributorTextBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Button addBtn;
    }
}