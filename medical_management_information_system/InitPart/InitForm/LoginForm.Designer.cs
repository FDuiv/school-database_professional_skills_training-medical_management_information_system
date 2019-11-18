namespace medical_management_information_system
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.passwordLab = new System.Windows.Forms.Label();
            this.accountLab = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(135, 126);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(162, 21);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(135, 78);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(162, 21);
            this.accountTextBox.TabIndex = 10;
            this.accountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.accountTextBox_KeyDown);
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.Location = new System.Drawing.Point(88, 129);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(41, 12);
            this.passwordLab.TabIndex = 9;
            this.passwordLab.Text = "密码：";
            // 
            // accountLab
            // 
            this.accountLab.AutoSize = true;
            this.accountLab.Location = new System.Drawing.Point(88, 81);
            this.accountLab.Name = "accountLab";
            this.accountLab.Size = new System.Drawing.Size(41, 12);
            this.accountLab.TabIndex = 8;
            this.accountLab.Text = "账号：";
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(90, 176);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 23);
            this.logInBtn.TabIndex = 7;
            this.logInBtn.Text = "登录";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(222, 176);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(75, 23);
            this.signInBtn.TabIndex = 6;
            this.signInBtn.Text = "注册";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(12, 226);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(63, 23);
            this.connectBtn.TabIndex = 12;
            this.connectBtn.Text = "连接设置";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.passwordLab);
            this.Controls.Add(this.accountLab);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.signInBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.Label accountLab;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Button connectBtn;
    }
}

