namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    partial class FrmItems
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnStocks = new Button();
            btnAdjustStocks = new Button();
            dgItems = new DataGridView();
            txtSearch = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblRecordCount = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dgWarehouseStocks = new DataGridView();
            groupBox1 = new GroupBox();
            dgStoreStocks = new DataGridView();
            btnUsersHistory = new Button();
            btnRepairsHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)dgItems).BeginInit();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgWarehouseStocks).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStoreStocks).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(988, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(988, 66);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(988, 95);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnStocks
            // 
            btnStocks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStocks.Location = new Point(988, 162);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(98, 23);
            btnStocks.TabIndex = 3;
            btnStocks.Text = "Stocks";
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // btnAdjustStocks
            // 
            btnAdjustStocks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdjustStocks.Location = new Point(988, 191);
            btnAdjustStocks.Name = "btnAdjustStocks";
            btnAdjustStocks.Size = new Size(98, 23);
            btnAdjustStocks.TabIndex = 4;
            btnAdjustStocks.Text = "Adjust Stocks";
            btnAdjustStocks.UseVisualStyleBackColor = true;
            btnAdjustStocks.Click += btnAdjustStocks_Click;
            // 
            // dgItems
            // 
            dgItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItems.Location = new Point(12, 41);
            dgItems.Name = "dgItems";
            dgItems.RowTemplate.Height = 25;
            dgItems.Size = new Size(970, 285);
            dgItems.TabIndex = 5;
            dgItems.SelectionChanged += dgItems_SelectionChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(257, 23);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblRecordCount });
            statusStrip1.Location = new Point(0, 538);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1098, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(52, 17);
            toolStripStatusLabel1.Text = "Records:";
            // 
            // lblRecordCount
            // 
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(13, 17);
            lblRecordCount.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 332);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(970, 203);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgWarehouseStocks);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(488, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 197);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Warehouse Stocks";
            // 
            // dgWarehouseStocks
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgWarehouseStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgWarehouseStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgWarehouseStocks.DefaultCellStyle = dataGridViewCellStyle6;
            dgWarehouseStocks.Dock = DockStyle.Fill;
            dgWarehouseStocks.Location = new Point(3, 19);
            dgWarehouseStocks.Name = "dgWarehouseStocks";
            dgWarehouseStocks.RowTemplate.Height = 25;
            dgWarehouseStocks.Size = new Size(473, 175);
            dgWarehouseStocks.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgStoreStocks);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Branch Stocks";
            // 
            // dgStoreStocks
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgStoreStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgStoreStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgStoreStocks.DefaultCellStyle = dataGridViewCellStyle8;
            dgStoreStocks.Dock = DockStyle.Fill;
            dgStoreStocks.Location = new Point(3, 19);
            dgStoreStocks.Name = "dgStoreStocks";
            dgStoreStocks.RowTemplate.Height = 25;
            dgStoreStocks.Size = new Size(473, 175);
            dgStoreStocks.TabIndex = 0;
            // 
            // btnUsersHistory
            // 
            btnUsersHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUsersHistory.Location = new Point(988, 303);
            btnUsersHistory.Name = "btnUsersHistory";
            btnUsersHistory.Size = new Size(98, 23);
            btnUsersHistory.TabIndex = 10;
            btnUsersHistory.Text = "Users History";
            btnUsersHistory.UseVisualStyleBackColor = true;
            // 
            // btnRepairsHistory
            // 
            btnRepairsHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRepairsHistory.Location = new Point(988, 274);
            btnRepairsHistory.Name = "btnRepairsHistory";
            btnRepairsHistory.Size = new Size(98, 23);
            btnRepairsHistory.TabIndex = 9;
            btnRepairsHistory.Text = "Repairs History";
            btnRepairsHistory.UseVisualStyleBackColor = true;
            btnRepairsHistory.Click += button2_Click;
            // 
            // FrmItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 560);
            Controls.Add(btnUsersHistory);
            Controls.Add(btnRepairsHistory);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(txtSearch);
            Controls.Add(dgItems);
            Controls.Add(btnAdjustStocks);
            Controls.Add(btnStocks);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "FrmItems";
            Text = "Items";
            Load += FrmItems_Load;
            ((System.ComponentModel.ISupportInitialize)dgItems).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgWarehouseStocks).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgStoreStocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnStocks;
        private Button btnAdjustStocks;
        private DataGridView dgItems;
        private TextBox txtSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private DataGridView dgWarehouseStocks;
        private GroupBox groupBox1;
        private DataGridView dgStoreStocks;
        private ToolStripStatusLabel lblRecordCount;
        private Button btnUsersHistory;
        private Button btnRepairsHistory;
    }
}