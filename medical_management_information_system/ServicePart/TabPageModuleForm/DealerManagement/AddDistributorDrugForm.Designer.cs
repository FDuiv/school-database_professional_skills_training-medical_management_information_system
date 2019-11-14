namespace medical_management_information_system.ServicePart.TabPageModuleForm.DealerManagement
{
    partial class AddDistributorDrugForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceLab = new System.Windows.Forms.Label();
            this.inventoryLab = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(158, 226);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(158, 129);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(121, 21);
            this.unitPriceTextBox.TabIndex = 8;
            this.unitPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitPriceTextBox_KeyPress);
            // 
            // unitPriceLab
            // 
            this.unitPriceLab.AutoSize = true;
            this.unitPriceLab.Location = new System.Drawing.Point(111, 132);
            this.unitPriceLab.Name = "unitPriceLab";
            this.unitPriceLab.Size = new System.Drawing.Size(41, 12);
            this.unitPriceLab.TabIndex = 7;
            this.unitPriceLab.Text = "单价：";
            // 
            // inventoryLab
            // 
            this.inventoryLab.AutoSize = true;
            this.inventoryLab.Location = new System.Drawing.Point(111, 105);
            this.inventoryLab.Name = "inventoryLab";
            this.inventoryLab.Size = new System.Drawing.Size(41, 12);
            this.inventoryLab.TabIndex = 6;
            this.inventoryLab.Text = "库存：";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(158, 102);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(121, 21);
            this.inventoryTextBox.TabIndex = 11;
            this.inventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inventoryTextBox_KeyPress);
            // 
            // AddDistributorDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.unitPriceLab);
            this.Controls.Add(this.inventoryLab);
            this.Name = "AddDistributorDrugForm";
            this.Text = "AddDistributorDrugForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label unitPriceLab;
        private System.Windows.Forms.Label inventoryLab;
        private System.Windows.Forms.TextBox inventoryTextBox;
    }
}