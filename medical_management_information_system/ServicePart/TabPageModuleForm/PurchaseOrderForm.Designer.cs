namespace medical_management_information_system.ServicePart.TabPageModuleForm
{
    partial class PurchaseOrderForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sortByTimeTabPage = new System.Windows.Forms.TabPage();
            this.sortByTimeTreeView = new System.Windows.Forms.TreeView();
            this.sortByCompletionTabPage = new System.Windows.Forms.TabPage();
            this.sortByCompletionTreeView = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.printingBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.sortByTimeTabPage.SuspendLayout();
            this.sortByCompletionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.sortByTimeTabPage);
            this.tabControl.Controls.Add(this.sortByCompletionTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(221, 437);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // sortByTimeTabPage
            // 
            this.sortByTimeTabPage.Controls.Add(this.sortByTimeTreeView);
            this.sortByTimeTabPage.Location = new System.Drawing.Point(4, 22);
            this.sortByTimeTabPage.Name = "sortByTimeTabPage";
            this.sortByTimeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sortByTimeTabPage.Size = new System.Drawing.Size(213, 411);
            this.sortByTimeTabPage.TabIndex = 0;
            this.sortByTimeTabPage.Text = "按发起时间排序";
            this.sortByTimeTabPage.UseVisualStyleBackColor = true;
            // 
            // sortByTimeTreeView
            // 
            this.sortByTimeTreeView.Location = new System.Drawing.Point(6, 6);
            this.sortByTimeTreeView.Name = "sortByTimeTreeView";
            this.sortByTimeTreeView.Size = new System.Drawing.Size(201, 399);
            this.sortByTimeTreeView.TabIndex = 0;
            // 
            // sortByCompletionTabPage
            // 
            this.sortByCompletionTabPage.Controls.Add(this.sortByCompletionTreeView);
            this.sortByCompletionTabPage.Location = new System.Drawing.Point(4, 22);
            this.sortByCompletionTabPage.Name = "sortByCompletionTabPage";
            this.sortByCompletionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sortByCompletionTabPage.Size = new System.Drawing.Size(213, 411);
            this.sortByCompletionTabPage.TabIndex = 1;
            this.sortByCompletionTabPage.Text = "按完成时间排序";
            this.sortByCompletionTabPage.UseVisualStyleBackColor = true;
            // 
            // sortByCompletionTreeView
            // 
            this.sortByCompletionTreeView.Location = new System.Drawing.Point(6, 6);
            this.sortByCompletionTreeView.Name = "sortByCompletionTreeView";
            this.sortByCompletionTreeView.Size = new System.Drawing.Size(180, 388);
            this.sortByCompletionTreeView.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(235, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(537, 411);
            this.dataGridView.TabIndex = 1;
            // 
            // printingBtn
            // 
            this.printingBtn.Location = new System.Drawing.Point(697, 5);
            this.printingBtn.Name = "printingBtn";
            this.printingBtn.Size = new System.Drawing.Size(75, 23);
            this.printingBtn.TabIndex = 2;
            this.printingBtn.Text = "打印";
            this.printingBtn.UseVisualStyleBackColor = true;
            this.printingBtn.Click += new System.EventHandler(this.printingBtn_Click);
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.printingBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tabControl);
            this.Name = "PurchaseOrderForm";
            this.Text = "PurchaseOrderForm";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            this.SizeChanged += new System.EventHandler(this.PurchaseOrderForm_SizeChanged);
            this.tabControl.ResumeLayout(false);
            this.sortByTimeTabPage.ResumeLayout(false);
            this.sortByCompletionTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage sortByTimeTabPage;
        private System.Windows.Forms.TreeView sortByTimeTreeView;
        private System.Windows.Forms.TabPage sortByCompletionTabPage;
        private System.Windows.Forms.TreeView sortByCompletionTreeView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button printingBtn;
    }
}