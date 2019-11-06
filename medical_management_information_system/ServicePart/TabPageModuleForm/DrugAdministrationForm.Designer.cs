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
            this.editBtn = new System.Windows.Forms.Button();
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
            // 
            // printingBtn
            // 
            this.printingBtn.Location = new System.Drawing.Point(697, 12);
            this.printingBtn.Name = "printingBtn";
            this.printingBtn.Size = new System.Drawing.Size(75, 23);
            this.printingBtn.TabIndex = 1;
            this.printingBtn.Text = "打印";
            this.printingBtn.UseVisualStyleBackColor = true;
            // 
            // generatePurchaseOrderBtn
            // 
            this.generatePurchaseOrderBtn.Location = new System.Drawing.Point(454, 12);
            this.generatePurchaseOrderBtn.Name = "generatePurchaseOrderBtn";
            this.generatePurchaseOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.generatePurchaseOrderBtn.TabIndex = 2;
            this.generatePurchaseOrderBtn.Text = "采购";
            this.generatePurchaseOrderBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(535, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "添加新药品";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(616, 12);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "编辑药品";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // DrugAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.editBtn);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button printingBtn;
        private System.Windows.Forms.Button generatePurchaseOrderBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
    }
}