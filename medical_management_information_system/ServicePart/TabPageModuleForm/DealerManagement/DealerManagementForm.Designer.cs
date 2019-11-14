namespace medical_management_information_system.ServicePart.TabPageModuleForm
{
    partial class DealerManagementForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.printingBtn = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.flashBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(218, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(554, 408);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.DataSourceChanged += new System.EventHandler(this.dataGridView_DataSourceChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(218, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // printingBtn
            // 
            this.printingBtn.Location = new System.Drawing.Point(697, 12);
            this.printingBtn.Name = "printingBtn";
            this.printingBtn.Size = new System.Drawing.Size(75, 23);
            this.printingBtn.TabIndex = 4;
            this.printingBtn.Text = "打印";
            this.printingBtn.UseVisualStyleBackColor = true;
            this.printingBtn.Click += new System.EventHandler(this.printingBtn_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(200, 437);
            this.treeView.TabIndex = 5;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(299, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // flashBtn
            // 
            this.flashBtn.Location = new System.Drawing.Point(616, 12);
            this.flashBtn.Name = "flashBtn";
            this.flashBtn.Size = new System.Drawing.Size(75, 23);
            this.flashBtn.TabIndex = 7;
            this.flashBtn.Text = "刷新";
            this.flashBtn.UseVisualStyleBackColor = true;
            this.flashBtn.Click += new System.EventHandler(this.flashBtn_Click);
            // 
            // DealerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.flashBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.printingBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "DealerManagementForm";
            this.Text = "DealerManagement";
            this.Load += new System.EventHandler(this.DealerManagementForm_Load);
            this.SizeChanged += new System.EventHandler(this.DealerManagementForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button printingBtn;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button flashBtn;
    }
}