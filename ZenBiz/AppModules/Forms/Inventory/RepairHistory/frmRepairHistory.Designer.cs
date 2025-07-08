namespace PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory
{
    partial class frmRepairHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepairHistory));
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            dgRepairHistory = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAddStoreStock = new ToolStripButton();
            btnEditStoreStock = new ToolStripButton();
            btnDeleteStoreStock = new ToolStripButton();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRepairHistory).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(panel2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(934, 460);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Repair History";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgRepairHistory);
            panel2.Controls.Add(toolStrip1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 438);
            panel2.TabIndex = 21;
            // 
            // dgRepairHistory
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgRepairHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgRepairHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgRepairHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgRepairHistory.Dock = DockStyle.Fill;
            dgRepairHistory.Location = new Point(0, 25);
            dgRepairHistory.Name = "dgRepairHistory";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgRepairHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgRepairHistory.RowTemplate.Height = 25;
            dgRepairHistory.Size = new Size(928, 413);
            dgRepairHistory.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddStoreStock, btnEditStoreStock, btnDeleteStoreStock });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(928, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddStoreStock
            // 
            btnAddStoreStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddStoreStock.Image = (Image)resources.GetObject("btnAddStoreStock.Image");
            btnAddStoreStock.ImageTransparentColor = Color.Magenta;
            btnAddStoreStock.Name = "btnAddStoreStock";
            btnAddStoreStock.Size = new Size(23, 22);
            btnAddStoreStock.Text = "Add";
            btnAddStoreStock.Click += btnAddStoreStock_Click;
            // 
            // btnEditStoreStock
            // 
            btnEditStoreStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditStoreStock.Image = (Image)resources.GetObject("btnEditStoreStock.Image");
            btnEditStoreStock.ImageTransparentColor = Color.Magenta;
            btnEditStoreStock.Name = "btnEditStoreStock";
            btnEditStoreStock.Size = new Size(23, 22);
            btnEditStoreStock.Text = "Edit";
            btnEditStoreStock.Click += btnEditStoreStock_Click;
            // 
            // btnDeleteStoreStock
            // 
            btnDeleteStoreStock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteStoreStock.Image = (Image)resources.GetObject("btnDeleteStoreStock.Image");
            btnDeleteStoreStock.ImageTransparentColor = Color.Magenta;
            btnDeleteStoreStock.Name = "btnDeleteStoreStock";
            btnDeleteStoreStock.Size = new Size(23, 22);
            btnDeleteStoreStock.Text = "Delete";
            // 
            // frmRepairHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 499);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            Name = "frmRepairHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Repair History";
            Load += frmRepairHistory_Load;
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgRepairHistory).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Panel panel2;
        public DataGridView dgRepairHistory;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddStoreStock;
        private ToolStripButton btnEditStoreStock;
        private ToolStripButton btnDeleteStoreStock;
    }
}