namespace medical_management_information_system.ServicePart.OtherForm
{
    partial class EditDealerForm
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
            this.distributorDrugDataGridView = new System.Windows.Forms.DataGridView();
            this.drugDataGridView = new System.Windows.Forms.DataGridView();
            this.downDrugNameLab = new System.Windows.Forms.Label();
            this.downComboBox = new System.Windows.Forms.ComboBox();
            this.upDrugLab = new System.Windows.Forms.Label();
            this.upComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.distributorDrugDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // distributorDrugDataGridView
            // 
            this.distributorDrugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distributorDrugDataGridView.Location = new System.Drawing.Point(12, 38);
            this.distributorDrugDataGridView.Name = "distributorDrugDataGridView";
            this.distributorDrugDataGridView.RowTemplate.Height = 23;
            this.distributorDrugDataGridView.Size = new System.Drawing.Size(760, 474);
            this.distributorDrugDataGridView.TabIndex = 0;
            this.distributorDrugDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.distributorDrugDataGridView_CellDoubleClick);
            // 
            // drugDataGridView
            // 
            this.drugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugDataGridView.Location = new System.Drawing.Point(12, 544);
            this.drugDataGridView.Name = "drugDataGridView";
            this.drugDataGridView.RowTemplate.Height = 23;
            this.drugDataGridView.Size = new System.Drawing.Size(760, 475);
            this.drugDataGridView.TabIndex = 1;
            this.drugDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drugDataGridView_CellDoubleClick);
            // 
            // downDrugNameLab
            // 
            this.downDrugNameLab.AutoSize = true;
            this.downDrugNameLab.Location = new System.Drawing.Point(12, 521);
            this.downDrugNameLab.Name = "downDrugNameLab";
            this.downDrugNameLab.Size = new System.Drawing.Size(41, 12);
            this.downDrugNameLab.TabIndex = 11;
            this.downDrugNameLab.Text = "药名：";
            // 
            // downComboBox
            // 
            this.downComboBox.FormattingEnabled = true;
            this.downComboBox.Location = new System.Drawing.Point(59, 518);
            this.downComboBox.Name = "downComboBox";
            this.downComboBox.Size = new System.Drawing.Size(121, 20);
            this.downComboBox.TabIndex = 10;
            this.downComboBox.TextChanged += new System.EventHandler(this.downComboBox_TextChanged);
            // 
            // upDrugLab
            // 
            this.upDrugLab.AutoSize = true;
            this.upDrugLab.Location = new System.Drawing.Point(12, 15);
            this.upDrugLab.Name = "upDrugLab";
            this.upDrugLab.Size = new System.Drawing.Size(41, 12);
            this.upDrugLab.TabIndex = 13;
            this.upDrugLab.Text = "药名：";
            // 
            // upComboBox
            // 
            this.upComboBox.FormattingEnabled = true;
            this.upComboBox.Location = new System.Drawing.Point(59, 12);
            this.upComboBox.Name = "upComboBox";
            this.upComboBox.Size = new System.Drawing.Size(121, 20);
            this.upComboBox.TabIndex = 12;
            this.upComboBox.TextChanged += new System.EventHandler(this.upComboBox_TextChanged);
            // 
            // EditDealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 1031);
            this.Controls.Add(this.upDrugLab);
            this.Controls.Add(this.upComboBox);
            this.Controls.Add(this.downDrugNameLab);
            this.Controls.Add(this.downComboBox);
            this.Controls.Add(this.drugDataGridView);
            this.Controls.Add(this.distributorDrugDataGridView);
            this.Name = "EditDealerForm";
            this.Text = "EditDealerForm";
            this.Load += new System.EventHandler(this.EditDealerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distributorDrugDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView distributorDrugDataGridView;
        private System.Windows.Forms.DataGridView drugDataGridView;
        private System.Windows.Forms.Label downDrugNameLab;
        private System.Windows.Forms.ComboBox downComboBox;
        private System.Windows.Forms.Label upDrugLab;
        private System.Windows.Forms.ComboBox upComboBox;
    }
}