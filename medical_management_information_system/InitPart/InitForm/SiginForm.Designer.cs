namespace medical_management_information_system
{
    partial class SiginForm
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.passwordLab = new System.Windows.Forms.Label();
            this.accountLab = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.surePasswordTextBox = new System.Windows.Forms.TextBox();
            this.surePasswordLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(135, 104);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(162, 21);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(135, 62);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(162, 21);
            this.accountTextBox.TabIndex = 10;
            this.accountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.accountTextBox_KeyDown);
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Location = new System.Drawing.Point(88, 107);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(41, 12);
            this.passwordLab.TabIndex = 9;
            this.passwordLab.Text = "密码：";
            // 
            // accountLab
            // 
            this.accountLab.AutoSize = true;
            this.accountLab.Location = new System.Drawing.Point(88, 65);
            this.accountLab.Name = "accountLab";
            this.accountLab.Size = new System.Drawing.Size(41, 12);
            this.accountLab.TabIndex = 8;
            this.accountLab.Text = "账号：";
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(154, 183);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(75, 23);
            this.signInBtn.TabIndex = 6;
            this.signInBtn.Text = "注册";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // surePasswordTextBox
            // 
            this.surePasswordTextBox.Location = new System.Drawing.Point(135, 145);
            this.surePasswordTextBox.Name = "surePasswordTextBox";
            this.surePasswordTextBox.PasswordChar = '*';
            this.surePasswordTextBox.Size = new System.Drawing.Size(162, 21);
            this.surePasswordTextBox.TabIndex = 13;
            this.surePasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.surePasswordTextBox_KeyDown);
            // 
            // surePasswordLab
            // 
            this.surePasswordLab.AutoSize = true;
            this.surePasswordLab.Location = new System.Drawing.Point(64, 148);
            this.surePasswordLab.Name = "surePasswordLab";
            this.surePasswordLab.Size = new System.Drawing.Size(65, 12);
            this.surePasswordLab.TabIndex = 12;
            this.surePasswordLab.Text = "确认密码：";
            // 
            // SiginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.surePasswordTextBox);
            this.Controls.Add(this.surePasswordLab);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.passwordLab);
            this.Controls.Add(this.accountLab);
            this.Controls.Add(this.signInBtn);
            this.Name = "SiginForm";
            this.Text = "SiginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.Label accountLab;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.TextBox surePasswordTextBox;
        private System.Windows.Forms.Label surePasswordLab;
    }
}