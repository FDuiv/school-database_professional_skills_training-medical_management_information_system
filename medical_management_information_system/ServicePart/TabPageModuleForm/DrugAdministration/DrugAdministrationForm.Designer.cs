namespace medical_management_information_system.ServicePart.TabPageModuleForm
{
    partial class DrugAdministrationForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.printingBtn = new System.Windows.Forms.Button();
            this.generatePurchaseOrderBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.flashBtn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.drugNameLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(760, 408);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseUp);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // printingBtn
            // 
            this.printingBtn.Location = new System.Drawing.Point(697, 12);
            this.printingBtn.Name = "printingBtn";
            this.printingBtn.Size = new System.Drawing.Size(75, 23);
            this.printingBtn.TabIndex = 1;
            this.printingBtn.Text = "打印";
            this.printingBtn.UseVisualStyleBackColor = true;
            this.printingBtn.Click += new System.EventHandler(this.printingBtn_Click);
            // 
            // generatePurchaseOrderBtn
            // 
            this.generatePurchaseOrderBtn.Location = new System.Drawing.Point(535, 12);
            this.generatePurchaseOrderBtn.Name = "generatePurchaseOrderBtn";
            this.generatePurchaseOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.generatePurchaseOrderBtn.TabIndex = 2;
            this.generatePurchaseOrderBtn.Text = "采购";
            this.generatePurchaseOrderBtn.UseVisualStyleBackColor = true;
            this.generatePurchaseOrderBtn.Click += new System.EventHandler(this.generatePurchaseOrderBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(184, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(265, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // flashBtn
            // 
            this.flashBtn.Location = new System.Drawing.Point(616, 12);
            this.flashBtn.Name = "flashBtn";
            this.flashBtn.Size = new System.Drawing.Size(75, 23);
            this.flashBtn.TabIndex = 6;
            this.flashBtn.Text = "刷新";
            this.flashBtn.UseVisualStyleBackColor = true;
            this.flashBtn.Click += new System.EventHandler(this.flashBtn_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(57, 14);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 20);
            this.comboBox.TabIndex = 7;
            this.comboBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // drugNameLab
            // 
            this.drugNameLab.AutoSize = true;
            this.drugNameLab.Location = new System.Drawing.Point(10, 17);
            this.drugNameLab.Name = "drugNameLab";
            this.drugNameLab.Size = new System.Drawing.Size(41, 12);
            this.drugNameLab.TabIndex = 9;
            this.drugNameLab.Text = "药名：";
            // 
            // DrugAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.drugNameLab);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.flashBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.generatePurchaseOrderBtn);
            this.Controls.Add(this.printingBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "DrugAdministrationForm";
            this.Text = "DrugAdministrationForm";
            this.Load += new System.EventHandler(this.DrugAdministrationForm_Load);
            this.SizeChanged += new System.EventHandler(this.DrugAdministrationForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button printingBtn;
        private System.Windows.Forms.Button generatePurchaseOrderBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button flashBtn;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label drugNameLab;
    }
}