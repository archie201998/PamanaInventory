namespace ZenBiz.AppModules.Forms.Inventory.Suppliers
{
    partial class FrmSuppliersAdd
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
            ucSupplier1 = new UcSupplier();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ucSupplier1
            // 
            ucSupplier1.Location = new Point(12, 12);
            ucSupplier1.Name = "ucSupplier1";
            ucSupplier1.Size = new Size(412, 96);
            ucSupplier1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 124);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(435, 30);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(357, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(276, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmSuppliersAdd
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            CancelButton = btnCancel;
            ClientSize = new Size(435, 154);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ucSupplier1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSuppliersAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Supplier";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UcSupplier ucSupplier1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnSave;
    }
}