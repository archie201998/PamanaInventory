namespace ZenBiz.AppModules.Inventory.Categories
{
    partial class FrmCategories
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
            dgCategories = new DataGridView();
            btnAdd = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            LblRecordsCount = new ToolStripStatusLabel();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgCategories
            // 
            dgCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategories.Location = new Point(12, 12);
            dgCategories.Name = "dgCategories";
            dgCategories.RowTemplate.Height = 25;
            dgCategories.Size = new Size(571, 325);
            dgCategories.TabIndex = 0;
            dgCategories.SelectionChanged += dgCategories_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(589, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, LblRecordsCount });
            statusStrip1.Location = new Point(0, 340);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(676, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(52, 17);
            toolStripStatusLabel1.Text = "Records:";
            // 
            // LblRecordsCount
            // 
            LblRecordsCount.Name = "LblRecordsCount";
            LblRecordsCount.Size = new Size(13, 17);
            LblRecordsCount.Text = "0";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(589, 41);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(589, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 362);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(statusStrip1);
            Controls.Add(btnAdd);
            Controls.Add(dgCategories);
            MinimumSize = new Size(692, 401);
            Name = "FrmCategories";
            Text = "Categories";
            Load += FrmCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCategories;
        private Button btnAdd;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel LblRecordsCount;
        private Button btnEdit;
        private Button btnDelete;
    }
}