namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    partial class UcItemDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            nudRetailPrice = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            nudWholesalePrice = new NumericUpDown();
            label5 = new Label();
            nudSpecialPrice = new NumericUpDown();
            label6 = new Label();
            nudMinStockThreshold = new NumericUpDown();
            label7 = new Label();
            nudUnitCost = new NumericUpDown();
            cmbCategory = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            cmbUnit = new ComboBox();
            epCode = new ErrorProvider(components);
            epName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudRetailPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWholesalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpecialPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinStockThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epName).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(129, 3);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(300, 23);
            txtCode.TabIndex = 0;
            txtCode.Validating += txtCode_Validating;
            txtCode.Validated += txtCode_Validated;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            txtName.Validated += txtName_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // nudRetailPrice
            // 
            nudRetailPrice.DecimalPlaces = 2;
            nudRetailPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudRetailPrice.Location = new Point(129, 61);
            nudRetailPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudRetailPrice.Name = "nudRetailPrice";
            nudRetailPrice.Size = new Size(300, 23);
            nudRetailPrice.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 63);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Retail Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 92);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 7;
            label4.Text = "Wholesale Price";
            // 
            // nudWholesalePrice
            // 
            nudWholesalePrice.DecimalPlaces = 2;
            nudWholesalePrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudWholesalePrice.Location = new Point(129, 90);
            nudWholesalePrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudWholesalePrice.Name = "nudWholesalePrice";
            nudWholesalePrice.Size = new Size(300, 23);
            nudWholesalePrice.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 121);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 9;
            label5.Text = "Special Price";
            // 
            // nudSpecialPrice
            // 
            nudSpecialPrice.DecimalPlaces = 2;
            nudSpecialPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudSpecialPrice.Location = new Point(129, 119);
            nudSpecialPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudSpecialPrice.Name = "nudSpecialPrice";
            nudSpecialPrice.Size = new Size(300, 23);
            nudSpecialPrice.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 150);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 11;
            label6.Text = "Min. Stock Threshold";
            // 
            // nudMinStockThreshold
            // 
            nudMinStockThreshold.DecimalPlaces = 2;
            nudMinStockThreshold.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudMinStockThreshold.Location = new Point(129, 148);
            nudMinStockThreshold.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMinStockThreshold.Name = "nudMinStockThreshold";
            nudMinStockThreshold.Size = new Size(300, 23);
            nudMinStockThreshold.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 179);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 13;
            label7.Text = "Unit Cost";
            // 
            // nudUnitCost
            // 
            nudUnitCost.DecimalPlaces = 2;
            nudUnitCost.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudUnitCost.Location = new Point(129, 177);
            nudUnitCost.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudUnitCost.Name = "nudUnitCost";
            nudUnitCost.Size = new Size(300, 23);
            nudUnitCost.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(129, 206);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 23);
            cmbCategory.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 209);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 238);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 17;
            label9.Text = "Unit";
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(129, 235);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(300, 23);
            cmbUnit.TabIndex = 8;
            // 
            // epCode
            // 
            epCode.ContainerControl = this;
            // 
            // epName
            // 
            epName.ContainerControl = this;
            // 
            // UcItemDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(cmbUnit);
            Controls.Add(label8);
            Controls.Add(cmbCategory);
            Controls.Add(label7);
            Controls.Add(nudUnitCost);
            Controls.Add(label6);
            Controls.Add(nudMinStockThreshold);
            Controls.Add(label5);
            Controls.Add(nudSpecialPrice);
            Controls.Add(label4);
            Controls.Add(nudWholesalePrice);
            Controls.Add(label3);
            Controls.Add(nudRetailPrice);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "UcItemDetails";
            Size = new Size(461, 275);
            Load += UcItemDetails_Load;
            ((System.ComponentModel.ISupportInitialize)nudRetailPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWholesalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpecialPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinStockThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)epCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)epName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ErrorProvider epCode;
        private ErrorProvider epName;
        internal TextBox txtCode;
        internal TextBox txtName;
        internal NumericUpDown nudRetailPrice;
        internal NumericUpDown nudWholesalePrice;
        internal NumericUpDown nudSpecialPrice;
        internal NumericUpDown nudMinStockThreshold;
        internal NumericUpDown nudUnitCost;
        internal ComboBox cmbCategory;
        internal ComboBox cmbUnit;
    }
}
