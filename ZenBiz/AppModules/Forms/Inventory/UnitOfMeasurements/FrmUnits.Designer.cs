namespace ZenBiz.AppModules.Forms.Inventory.UnitOfMeasurements
{
    partial class FrmUnits
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgUnit = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblRecordCount = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgUnit).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(589, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(589, 41);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
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
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgUnit
            // 
            dgUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUnit.Location = new Point(12, 12);
            dgUnit.Name = "dgUnit";
            dgUnit.RowTemplate.Height = 25;
            dgUnit.Size = new Size(571, 325);
            dgUnit.TabIndex = 3;
            dgUnit.SelectionChanged += dgUnit_SelectionChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblRecordCount });
            statusStrip1.Location = new Point(0, 340);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(676, 22);
            statusStrip1.TabIndex = 4;
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
            // FrmUnits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 362);
            Controls.Add(statusStrip1);
            Controls.Add(dgUnit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            MinimumSize = new Size(692, 401);
            Name = "FrmUnits";
            Text = "Units of Measurement";
            Load += FrmUnits_Load;
            ((System.ComponentModel.ISupportInitialize)dgUnit).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgUnit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblRecordCount;
    }
}