namespace ZenBiz.AppModules.Forms.Inventory.StockAdjustment
{
    partial class FrmStockAdjustmentEdit
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
            ucStockAdjustments1 = new UcStockAdjustments();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ucStockAdjustments1
            // 
            ucStockAdjustments1.Location = new Point(12, 12);
            ucStockAdjustments1.Name = "ucStockAdjustments1";
            ucStockAdjustments1.Size = new Size(400, 191);
            ucStockAdjustments1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 209);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(415, 30);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(337, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(256, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmStockAdjustmentEdit
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            CancelButton = btnCancel;
            ClientSize = new Size(415, 239);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ucStockAdjustments1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStockAdjustmentEdit";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Stock Adjustment";
            Load += FrmStockAdjustmentEdit_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UcStockAdjustments ucStockAdjustments1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnSave;
    }
}