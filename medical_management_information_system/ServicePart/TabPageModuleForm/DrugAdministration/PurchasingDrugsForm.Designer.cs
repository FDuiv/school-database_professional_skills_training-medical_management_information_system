namespace medical_management_information_system.ServicePart.TabPageModuleForm.DrugAdministration
{
    partial class PurchasingDrugsForm
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
            this.upLab = new System.Windows.Forms.Label();
            this.upComboBox = new System.Windows.Forms.ComboBox();
            this.upDataGridView = new System.Windows.Forms.DataGridView();
            this.downDataGridView = new System.Windows.Forms.DataGridView();
            this.downComboBox = new System.Windows.Forms.ComboBox();
            this.downLab = new System.Windows.Forms.Label();
            this.sureBtn = new System.Windows.Forms.Button();
            this.NumTextBox = new System.Windows.Forms.TextBox();
            this.NumLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // upLab
            // 
            this.upLab.AutoSize = true;
            this.upLab.Location = new System.Drawing.Point(10, 9);
            this.upLab.Name = "upLab";
            this.upLab.Size = new System.Drawing.Size(53, 12);
            this.upLab.TabIndex = 0;
            this.upLab.Text = "药品名：";
            // 
            // upComboBox
            // 
            this.upComboBox.FormattingEnabled = true;
            this.upComboBox.Location = new System.Drawing.Point(71, 6);
            this.upComboBox.Name = "upComboBox";
            this.upComboBox.Size = new System.Drawing.Size(121, 20);
            this.upComboBox.TabIndex = 1;
            this.upComboBox.TextChanged += new System.EventHandler(this.upComboBox_TextChanged);
            // 
            // upDataGridView
            // 
            this.upDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upDataGridView.Location = new System.Drawing.Point(12, 32);
            this.upDataGridView.Name = "upDataGridView";
            this.upDataGridView.RowTemplate.Height = 23;
            this.upDataGridView.Size = new System.Drawing.Size(760, 474);
            this.upDataGridView.TabIndex = 2;
            this.upDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upDataGridView_CellDoubleClick);
            // 
            // downDataGridView
            // 
            this.downDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.downDataGridView.Location = new System.Drawing.Point(12, 545);
            this.downDataGridView.Name = "downDataGridView";
            this.downDataGridView.RowTemplate.Height = 23;
            this.downDataGridView.Size = new System.Drawing.Size(760, 474);
            this.downDataGridView.TabIndex = 5;
            this.downDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.downDataGridView_CellDoubleClick);
            // 
            // downComboBox
            // 
            this.downComboBox.FormattingEnabled = true;
            this.downComboBox.Location = new System.Drawing.Point(71, 519);
            this.downComboBox.Name = "downComboBox";
            this.downComboBox.Size = new System.Drawing.Size(121, 20);
            this.downComboBox.TabIndex = 4;
            this.downComboBox.TextChanged += new System.EventHandler(this.downComboBox_TextChanged);
            // 
            // downLab
            // 
            this.downLab.AutoSize = true;
            this.downLab.Location = new System.Drawing.Point(10, 522);
            this.downLab.Name = "downLab";
            this.downLab.Size = new System.Drawing.Size(53, 12);
            this.downLab.TabIndex = 3;
            this.downLab.Text = "药品名：";
            // 
            // sureBtn
            // 
            this.sureBtn.Location = new System.Drawing.Point(697, 4);
            this.sureBtn.Name = "sureBtn";
            this.sureBtn.Size = new System.Drawing.Size(75, 23);
            this.sureBtn.TabIndex = 6;
            this.sureBtn.Text = "提交采购单";
            this.sureBtn.UseVisualStyleBackColor = true;
            this.sureBtn.Click += new System.EventHandler(this.sureBtn_Click);
            // 
            // NumTextBox
            // 
            this.NumTextBox.Location = new System.Drawing.Point(672, 519);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.Size = new System.Drawing.Size(100, 21);
            this.NumTextBox.TabIndex = 7;
            this.NumTextBox.Text = "0";
            this.NumTextBox.TextChanged += new System.EventHandler(this.NumTextBox_TextChanged);
            this.NumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumTextBox_KeyPress);
            // 
            // NumLab
            // 
            this.NumLab.AutoSize = true;
            this.NumLab.Location = new System.Drawing.Point(577, 522);
            this.NumLab.Name = "NumLab";
            this.NumLab.Size = new System.Drawing.Size(89, 12);
            this.NumLab.TabIndex = 8;
            this.NumLab.Text = "默认添加数量：";
            // 
            // PurchasingDrugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 1031);
            this.Controls.Add(this.NumLab);
            this.Controls.Add(this.NumTextBox);
            this.Controls.Add(this.sureBtn);
            this.Controls.Add(this.downDataGridView);
            this.Controls.Add(this.downComboBox);
            this.Controls.Add(this.downLab);
            this.Controls.Add(this.upDataGridView);
            this.Controls.Add(this.upComboBox);
            this.Controls.Add(this.upLab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchasingDrugsForm";
            this.Text = "PurchasingDrugsForm";
            this.Load += new System.EventHandler(this.PurchasingDrugsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upLab;
        private System.Windows.Forms.ComboBox upComboBox;
        private System.Windows.Forms.DataGridView upDataGridView;
        private System.Windows.Forms.DataGridView downDataGridView;
        private System.Windows.Forms.ComboBox downComboBox;
        private System.Windows.Forms.Label downLab;
        private System.Windows.Forms.Button sureBtn;
        private System.Windows.Forms.TextBox NumTextBox;
        private System.Windows.Forms.Label NumLab;
    }
}