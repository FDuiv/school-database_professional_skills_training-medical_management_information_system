namespace medical_management_information_system.ServicePart.TabPageModuleForm.Shopping
{
    partial class AddShoppingForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(69, 33);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(69, 6);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(121, 21);
            this.textBox.TabIndex = 8;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distributorTextBox_KeyPress);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(10, 9);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(53, 12);
            this.lab.TabIndex = 7;
            this.lab.Text = "购买量：";
            // 
            // AddShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 68);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddShoppingForm";
            this.Text = "AddShoppingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lab;
    }
}