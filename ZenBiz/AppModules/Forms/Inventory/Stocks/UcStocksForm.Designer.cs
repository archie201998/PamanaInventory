namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    partial class UcStocksForm
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
            cmbStoreWarehouse = new ComboBox();
            lblStoreWarehouse = new Label();
            label2 = new Label();
            nudStockCount = new NumericUpDown();
            epStockCount = new ErrorProvider(components);
            dtpStockDate = new DateTimePicker();
            dtpExpiration = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            chkExpiration = new CheckBox();
            chkStockDate = new CheckBox();
            cmbSupplier = new ComboBox();
            label1 = new Label();
            chkSupplier = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudStockCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epStockCount).BeginInit();
            SuspendLayout();
            // 
            // cmbStoreWarehouse
            // 
            cmbStoreWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStoreWarehouse.FormattingEnabled = true;
            cmbStoreWarehouse.Location = new Point(85, 3);
            cmbStoreWarehouse.Name = "cmbStoreWarehouse";
            cmbStoreWarehouse.Size = new Size(300, 23);
            cmbStoreWarehouse.TabIndex = 0;
            // 
            // lblStoreWarehouse
            // 
            lblStoreWarehouse.AutoSize = true;
            lblStoreWarehouse.Location = new Point(2, 6);
            lblStoreWarehouse.Name = "lblStoreWarehouse";
            lblStoreWarehouse.Size = new Size(34, 15);
            lblStoreWarehouse.TabIndex = 1;
            lblStoreWarehouse.Text = "Store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 34);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Stocks Count";
            // 
            // nudStockCount
            // 
            nudStockCount.DecimalPlaces = 2;
            nudStockCount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudStockCount.Location = new Point(85, 32);
            nudStockCount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStockCount.Name = "nudStockCount";
            nudStockCount.Size = new Size(300, 23);
            nudStockCount.TabIndex = 1;
            nudStockCount.Validating += nudStockCount_Validating;
            nudStockCount.Validated += nudStockCount_Validated;
            // 
            // epStockCount
            // 
            epStockCount.ContainerControl = this;
            // 
            // dtpStockDate
            // 
            dtpStockDate.Location = new Point(85, 61);
            dtpStockDate.Name = "dtpStockDate";
            dtpStockDate.Size = new Size(300, 23);
            dtpStockDate.TabIndex = 2;
            // 
            // dtpExpiration
            // 
            dtpExpiration.Location = new Point(85, 90);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(300, 23);
            dtpExpiration.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 65);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Stock Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 94);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Expiration";
            // 
            // chkExpiration
            // 
            chkExpiration.AutoSize = true;
            chkExpiration.Location = new Point(391, 94);
            chkExpiration.Name = "chkExpiration";
            chkExpiration.Size = new Size(15, 14);
            chkExpiration.TabIndex = 5;
            chkExpiration.UseVisualStyleBackColor = true;
            chkExpiration.CheckedChanged += chkExpiration_CheckedChanged;
            // 
            // chkStockDate
            // 
            chkStockDate.AutoSize = true;
            chkStockDate.Location = new Point(391, 67);
            chkStockDate.Name = "chkStockDate";
            chkStockDate.Size = new Size(15, 14);
            chkStockDate.TabIndex = 3;
            chkStockDate.UseVisualStyleBackColor = true;
            chkStockDate.CheckedChanged += chkStockDate_CheckedChanged;
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(85, 119);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(300, 23);
            cmbSupplier.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 122);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 9;
            label1.Text = "Supplier";
            // 
            // chkSupplier
            // 
            chkSupplier.AutoSize = true;
            chkSupplier.Location = new Point(391, 123);
            chkSupplier.Name = "chkSupplier";
            chkSupplier.Size = new Size(15, 14);
            chkSupplier.TabIndex = 10;
            chkSupplier.UseVisualStyleBackColor = true;
            chkSupplier.CheckedChanged += chkSupplier_CheckedChanged;
            // 
            // UcStocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkSupplier);
            Controls.Add(label1);
            Controls.Add(cmbSupplier);
            Controls.Add(chkStockDate);
            Controls.Add(chkExpiration);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpExpiration);
            Controls.Add(dtpStockDate);
            Controls.Add(nudStockCount);
            Controls.Add(label2);
            Controls.Add(lblStoreWarehouse);
            Controls.Add(cmbStoreWarehouse);
            Name = "UcStocksForm";
            Size = new Size(428, 161);
            Load += UcStoreStocks_Load;
            ((System.ComponentModel.ISupportInitialize)nudStockCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)epStockCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStoreWarehouse;
        private Label label2;
        private ErrorProvider epStockCount;
        private Label label4;
        private Label label3;
        internal ComboBox cmbStoreWarehouse;
        internal NumericUpDown nudStockCount;
        internal CheckBox chkExpiration;
        internal DateTimePicker dtpExpiration;
        internal DateTimePicker dtpStockDate;
        internal CheckBox chkStockDate;
        internal CheckBox chkSupplier;
        private Label label1;
        internal ComboBox cmbSupplier;
    }
}
