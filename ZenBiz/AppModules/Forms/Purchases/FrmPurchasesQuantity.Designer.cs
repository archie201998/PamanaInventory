namespace ZenBiz.AppModules.Forms.Purchases
{
    partial class FrmPurchasesQuantity
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
            btnSave = new Button();
            btnCancel = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radSpecialPrice = new RadioButton();
            radWholesalePrice = new RadioButton();
            radRetailPrice = new RadioButton();
            nudQuantity = new NumericUpDown();
            label2 = new Label();
            nudPrice = new NumericUpDown();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
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
            // btnCancel
            // 
            btnCancel.Location = new Point(282, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(360, 30);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // radSpecialPrice
            // 
            radSpecialPrice.AutoSize = true;
            radSpecialPrice.Location = new Point(219, 12);
            radSpecialPrice.Name = "radSpecialPrice";
            radSpecialPrice.Size = new Size(62, 19);
            radSpecialPrice.TabIndex = 5;
            radSpecialPrice.Text = "Special";
            radSpecialPrice.UseVisualStyleBackColor = true;
            radSpecialPrice.CheckedChanged += radSpecialPrice_CheckedChanged;
            // 
            // radWholesalePrice
            // 
            radWholesalePrice.AutoSize = true;
            radWholesalePrice.Location = new Point(134, 12);
            radWholesalePrice.Name = "radWholesalePrice";
            radWholesalePrice.Size = new Size(79, 19);
            radWholesalePrice.TabIndex = 4;
            radWholesalePrice.Text = "Wholesale";
            radWholesalePrice.UseVisualStyleBackColor = true;
            radWholesalePrice.CheckedChanged += radWholesalePrice_CheckedChanged;
            // 
            // radRetailPrice
            // 
            radRetailPrice.AutoSize = true;
            radRetailPrice.Checked = true;
            radRetailPrice.Location = new Point(74, 12);
            radRetailPrice.Name = "radRetailPrice";
            radRetailPrice.Size = new Size(54, 19);
            radRetailPrice.TabIndex = 3;
            radRetailPrice.TabStop = true;
            radRetailPrice.Text = "Retail";
            radRetailPrice.UseVisualStyleBackColor = true;
            radRetailPrice.CheckedChanged += radRetailPrice_CheckedChanged;
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 2;
            nudQuantity.Location = new Point(74, 66);
            nudQuantity.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(250, 23);
            nudQuantity.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 68);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 9;
            label2.Text = "Quantity";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(74, 37);
            nudPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(250, 23);
            nudPrice.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 39);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 6;
            label1.Text = "Price";
            // 
            // FrmPurchasesQuantity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 143);
            Controls.Add(nudQuantity);
            Controls.Add(label2);
            Controls.Add(nudPrice);
            Controls.Add(label1);
            Controls.Add(radSpecialPrice);
            Controls.Add(radWholesalePrice);
            Controls.Add(radRetailPrice);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmPurchasesQuantity";
            Text = "Enter Price & Quantity";
            Load += FrmPurchasesQuantity_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radSpecialPrice;
        private RadioButton radWholesalePrice;
        private RadioButton radRetailPrice;
        private NumericUpDown nudQuantity;
        private Label label2;
        private NumericUpDown nudPrice;
        private Label label1;
    }
}