namespace ZenBiz.AppModules.Forms.Purchases
{
    partial class FrmPurchasesItemsSearch
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
            if (disposing && (components != null))
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
            btnSearch = new Button();
            dgItems = new DataGridView();
            txtSearch = new TextBox();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgItems).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(268, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgItems
            // 
            dgItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItems.Location = new Point(12, 41);
            dgItems.Name = "dgItems";
            dgItems.RowTemplate.Height = 25;
            dgItems.Size = new Size(983, 345);
            dgItems.TabIndex = 7;
            dgItems.CellMouseDoubleClick += dgItems_CellMouseDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 6;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(894, 392);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(101, 23);
            btnSelect.TabIndex = 10;
            btnSelect.Text = "Select Item";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // FrmPurchasesItemsSearch
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 427);
            Controls.Add(btnSelect);
            Controls.Add(btnSearch);
            Controls.Add(dgItems);
            Controls.Add(txtSearch);
            Name = "FrmPurchasesItemsSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Item";
            Load += FrmPurchasesItemsSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dgItems;
        internal TextBox txtSearch;
        private Button btnSelect;
    }
}