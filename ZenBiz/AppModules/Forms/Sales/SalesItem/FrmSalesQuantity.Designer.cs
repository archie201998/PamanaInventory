namespace ZenBiz.AppModules.Forms.Sales
{
    partial class FrmSalesQuantity
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
            label1 = new Label();
            nudPrice = new NumericUpDown();
            radRetailPrice = new RadioButton();
            radWholesalePrice = new RadioButton();
            radSpecialPrice = new RadioButton();
            nudQuantity = new NumericUpDown();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Price";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(73, 37);
            nudPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(250, 23);
            nudPrice.TabIndex = 3;
            // 
            // radRetailPrice
            // 
            radRetailPrice.AutoSize = true;
            radRetailPrice.Checked = true;
            radRetailPrice.Location = new Point(73, 12);
            radRetailPrice.Name = "radRetailPrice";
            radRetailPrice.Size = new Size(54, 19);
            radRetailPrice.TabIndex = 0;
            radRetailPrice.TabStop = true;
            radRetailPrice.Text = "Retail";
            radRetailPrice.UseVisualStyleBackColor = true;
            radRetailPrice.CheckedChanged += radRetailPrice_CheckedChanged;
            // 
            // radWholesalePrice
            // 
            radWholesalePrice.AutoSize = true;
            radWholesalePrice.Location = new Point(133, 12);
            radWholesalePrice.Name = "radWholesalePrice";
            radWholesalePrice.Size = new Size(79, 19);
            radWholesalePrice.TabIndex = 1;
            radWholesalePrice.Text = "Wholesale";
            radWholesalePrice.UseVisualStyleBackColor = true;
            radWholesalePrice.CheckedChanged += radWholesalePrice_CheckedChanged;
            // 
            // radSpecialPrice
            // 
            radSpecialPrice.AutoSize = true;
            radSpecialPrice.Location = new Point(218, 12);
            radSpecialPrice.Name = "radSpecialPrice";
            radSpecialPrice.Size = new Size(62, 19);
            radSpecialPrice.TabIndex = 2;
            radSpecialPrice.Text = "Special";
            radSpecialPrice.UseVisualStyleBackColor = true;
            radSpecialPrice.CheckedChanged += radSpecialPrice_CheckedChanged;
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 2;
            nudQuantity.Location = new Point(73, 66);
            nudQuantity.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(250, 23);
            nudQuantity.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(360, 30);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(282, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(201, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmSalesQuantity
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(360, 143);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(nudQuantity);
            Controls.Add(label2);
            Controls.Add(radSpecialPrice);
            Controls.Add(radWholesalePrice);
            Controls.Add(radRetailPrice);
            Controls.Add(nudPrice);
            Controls.Add(label1);
            Name = "FrmSalesQuantity";
            Text = "Enter Price & Quantity";
            Load += FrmSalesQuantity_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudPrice;
        private RadioButton radRetailPrice;
        private RadioButton radWholesalePrice;
        private RadioButton radSpecialPrice;
        private NumericUpDown nudQuantity;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnSave;
    }
}