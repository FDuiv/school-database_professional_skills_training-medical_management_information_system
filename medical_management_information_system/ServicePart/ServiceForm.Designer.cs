namespace medical_management_information_system.ServicePart
{
    partial class ServiceForm
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
            this.logoLab = new System.Windows.Forms.Label();
            this.setBtn = new System.Windows.Forms.Button();
            this.personalDataBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // logoLab
            // 
            this.logoLab.AutoSize = true;
            this.logoLab.Font = new System.Drawing.Font("宋体", 20F);
            this.logoLab.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoLab.Location = new System.Drawing.Point(12, 9);
            this.logoLab.Name = "logoLab";
            this.logoLab.Size = new System.Drawing.Size(68, 27);
            this.logoLab.TabIndex = 1;
            this.logoLab.Text = "MMIS";
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(697, 17);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(75, 23);
            this.setBtn.TabIndex = 2;
            this.setBtn.Text = "设置";
            this.setBtn.UseVisualStyleBackColor = true;
            // 
            // personalDataBtn
            // 
            this.personalDataBtn.Location = new System.Drawing.Point(616, 17);
            this.personalDataBtn.Name = "personalDataBtn";
            this.personalDataBtn.Size = new System.Drawing.Size(75, 23);
            this.personalDataBtn.TabIndex = 3;
            this.personalDataBtn.Text = "个人资料";
            this.personalDataBtn.UseVisualStyleBackColor = true;
            this.personalDataBtn.Click += new System.EventHandler(this.personalDataBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(12, 46);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 403);
            this.tabControl.TabIndex = 4;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.personalDataBtn);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.logoLab);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.SizeChanged += new System.EventHandler(this.ServiceForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label logoLab;
        protected System.Windows.Forms.Button setBtn;
        protected System.Windows.Forms.Button personalDataBtn;
        protected System.Windows.Forms.TabControl tabControl;
    }
}