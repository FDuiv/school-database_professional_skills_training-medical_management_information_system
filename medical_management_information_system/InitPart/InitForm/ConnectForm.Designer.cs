namespace medical_management_information_system
{
    partial class ConnectForm
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
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.ip_portLab = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.userLab = new System.Windows.Forms.Label();
            this.passwordLab = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(277, 80);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(29, 21);
            this.portTextBox.TabIndex = 17;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(144, 80);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(127, 21);
            this.ipTextBox.TabIndex = 16;
            // 
            // ip_portLab
            // 
            this.ip_portLab.AutoSize = true;
            this.ip_portLab.Location = new System.Drawing.Point(79, 83);
            this.ip_portLab.Name = "ip_portLab";
            this.ip_portLab.Size = new System.Drawing.Size(59, 12);
            this.ip_portLab.TabIndex = 15;
            this.ip_portLab.Text = "IP:PORT：";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(144, 193);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 18;
            this.connectBtn.Text = "确定";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.sureBtn_Click);
            // 
            // userLab
            // 
            this.userLab.AutoSize = true;
            this.userLab.Location = new System.Drawing.Point(97, 115);
            this.userLab.Name = "userLab";
            this.userLab.Size = new System.Drawing.Size(41, 12);
            this.userLab.TabIndex = 19;
            this.userLab.Text = "user：";
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Location = new System.Drawing.Point(73, 145);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(65, 12);
            this.passwordLab.TabIndex = 20;
            this.passwordLab.Text = "password：";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(144, 112);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(162, 21);
            this.userTextBox.TabIndex = 21;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(144, 142);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(162, 21);
            this.passwordTextBox.TabIndex = 22;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordLab);
            this.Controls.Add(this.userLab);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ip_portLab);
            this.Name = "ConnectForm";
            this.Text = "ConnectForm";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label ip_portLab;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label userLab;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}