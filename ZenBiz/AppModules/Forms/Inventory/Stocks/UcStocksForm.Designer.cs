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
            txtUser = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbxStatus = new ComboBox();
            txtRemarks = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dtpReturnedDate = new DateTimePicker();
            dtpRepairedDate = new DateTimePicker();
            chkRepairedDate = new CheckBox();
            chkReturnedDate = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudStockCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epStockCount).BeginInit();
            SuspendLayout();
            // 
            // cmbStoreWarehouse
            // 
            cmbStoreWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStoreWarehouse.FormattingEnabled = true;
            cmbStoreWarehouse.Location = new Point(92, 4);
            cmbStoreWarehouse.Name = "cmbStoreWarehouse";
            cmbStoreWarehouse.Size = new Size(300, 23);
            cmbStoreWarehouse.TabIndex = 0;
            // 
            // lblStoreWarehouse
            // 
            lblStoreWarehouse.AutoSize = true;
            lblStoreWarehouse.Location = new Point(2, 6);
            lblStoreWarehouse.Name = "lblStoreWarehouse";
            lblStoreWarehouse.Size = new Size(44, 15);
            lblStoreWarehouse.TabIndex = 1;
            lblStoreWarehouse.Text = "Branch";
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
            nudStockCount.Location = new Point(92, 33);
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
            dtpStockDate.Location = new Point(92, 62);
            dtpStockDate.Name = "dtpStockDate";
            dtpStockDate.Size = new Size(300, 23);
            dtpStockDate.TabIndex = 2;
            // 
            // dtpExpiration
            // 
            dtpExpiration.Location = new Point(92, 91);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(300, 23);
            dtpExpiration.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 65);
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
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Expiration";
            // 
            // chkExpiration
            // 
            chkExpiration.AutoSize = true;
            chkExpiration.Location = new Point(398, 95);
            chkExpiration.Name = "chkExpiration";
            chkExpiration.Size = new Size(15, 14);
            chkExpiration.TabIndex = 5;
            chkExpiration.UseVisualStyleBackColor = true;
            chkExpiration.CheckedChanged += chkExpiration_CheckedChanged;
            // 
            // chkStockDate
            // 
            chkStockDate.AutoSize = true;
            chkStockDate.Location = new Point(398, 68);
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
            cmbSupplier.Location = new Point(92, 120);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(300, 23);
            cmbSupplier.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 122);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 9;
            label1.Text = "Supplier";
            // 
            // chkSupplier
            // 
            chkSupplier.AutoSize = true;
            chkSupplier.Location = new Point(398, 124);
            chkSupplier.Name = "chkSupplier";
            chkSupplier.Size = new Size(15, 14);
            chkSupplier.TabIndex = 10;
            chkSupplier.UseVisualStyleBackColor = true;
            chkSupplier.CheckedChanged += chkSupplier_CheckedChanged;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(92, 148);
            txtUser.MaxLength = 45;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 23);
            txtUser.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 149);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 12;
            label5.Text = "User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 178);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 14;
            label6.Text = "Status";
            // 
            // cmbxStatus
            // 
            cmbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxStatus.FormattingEnabled = true;
            cmbxStatus.Items.AddRange(new object[] { "Working", "Defective", "Repaired" });
            cmbxStatus.Location = new Point(92, 177);
            cmbxStatus.Name = "cmbxStatus";
            cmbxStatus.Size = new Size(300, 23);
            cmbxStatus.TabIndex = 15;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(92, 206);
            txtRemarks.MaxLength = 45;
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(300, 46);
            txtRemarks.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 208);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 17;
            label7.Text = "Remarks";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 291);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 21;
            label8.Text = "Returned Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 262);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 20;
            label9.Text = "Repaired Date";
            // 
            // dtpReturnedDate
            // 
            dtpReturnedDate.Location = new Point(92, 287);
            dtpReturnedDate.Name = "dtpReturnedDate";
            dtpReturnedDate.Size = new Size(300, 23);
            dtpReturnedDate.TabIndex = 19;
            // 
            // dtpRepairedDate
            // 
            dtpRepairedDate.Location = new Point(92, 258);
            dtpRepairedDate.Name = "dtpRepairedDate";
            dtpRepairedDate.Size = new Size(300, 23);
            dtpRepairedDate.TabIndex = 18;
            // 
            // chkRepairedDate
            // 
            chkRepairedDate.AutoSize = true;
            chkRepairedDate.Location = new Point(398, 265);
            chkRepairedDate.Name = "chkRepairedDate";
            chkRepairedDate.Size = new Size(15, 14);
            chkRepairedDate.TabIndex = 22;
            chkRepairedDate.UseVisualStyleBackColor = true;
            chkRepairedDate.CheckedChanged += chkRepairedDate_CheckedChanged;
            // 
            // chkReturnedDate
            // 
            chkReturnedDate.AutoSize = true;
            chkReturnedDate.Location = new Point(398, 292);
            chkReturnedDate.Name = "chkReturnedDate";
            chkReturnedDate.Size = new Size(15, 14);
            chkReturnedDate.TabIndex = 23;
            chkReturnedDate.UseVisualStyleBackColor = true;
            chkReturnedDate.CheckedChanged += chkReturnedDate_CheckedChanged;
            // 
            // UcStocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkRepairedDate);
            Controls.Add(chkReturnedDate);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dtpReturnedDate);
            Controls.Add(dtpRepairedDate);
            Controls.Add(txtRemarks);
            Controls.Add(label7);
            Controls.Add(cmbxStatus);
            Controls.Add(label6);
            Controls.Add(txtUser);
            Controls.Add(label5);
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
            Size = new Size(428, 325);
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
        internal TextBox txtUser;
        private Label label5;
        internal ComboBox cmbxStatus;
        private Label label6;
        internal TextBox txtRemarks;
        private Label label7;
        private Label label8;
        private Label label9;
        internal DateTimePicker dtpReturnedDate;
        internal DateTimePicker dtpRepairedDate;
        internal CheckBox chkRepairedDate;
        internal CheckBox chkReturnedDate;
    }
}
