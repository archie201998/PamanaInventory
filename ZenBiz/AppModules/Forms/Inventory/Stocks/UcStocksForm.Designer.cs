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
            cmbBranch = new ComboBox();
            lblStoreWarehouse = new Label();
            epStockCount = new ErrorProvider(components);
            dtpDateAcquired = new DateTimePicker();
            label3 = new Label();
            cmbSupplier = new ComboBox();
            label1 = new Label();
            txtUser = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbxStatus = new ComboBox();
            txtRemarks = new TextBox();
            label7 = new Label();
            label9 = new Label();
            dtpRepairedDate = new DateTimePicker();
            chkRepairedDate = new CheckBox();
            txtSerialNumber = new TextBox();
            label2 = new Label();
            txtOS = new TextBox();
            label10 = new Label();
            txtModel = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtRAM = new TextBox();
            txtSophosTamper = new TextBox();
            label13 = new Label();
            txtComputerName = new TextBox();
            label14 = new Label();
            nudUnitCost = new NumericUpDown();
            label15 = new Label();
            chkUser = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)epStockCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).BeginInit();
            SuspendLayout();
            // 
            // cmbBranch
            // 
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(111, 4);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(300, 23);
            cmbBranch.TabIndex = 0;
            // 
            // lblStoreWarehouse
            // 
            lblStoreWarehouse.AutoSize = true;
            lblStoreWarehouse.Location = new Point(5, 7);
            lblStoreWarehouse.Name = "lblStoreWarehouse";
            lblStoreWarehouse.Size = new Size(44, 15);
            lblStoreWarehouse.TabIndex = 1;
            lblStoreWarehouse.Text = "Branch";
            // 
            // epStockCount
            // 
            epStockCount.ContainerControl = this;
            // 
            // dtpDateAcquired
            // 
            dtpDateAcquired.Location = new Point(111, 207);
            dtpDateAcquired.Name = "dtpDateAcquired";
            dtpDateAcquired.Size = new Size(300, 23);
            dtpDateAcquired.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 211);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Date Acquired";
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(111, 294);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(300, 23);
            cmbSupplier.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 297);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 9;
            label1.Text = "Supplier";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(111, 322);
            txtUser.MaxLength = 45;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 23);
            txtUser.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 324);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 12;
            label5.Text = "User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 267);
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
            cmbxStatus.Location = new Point(111, 265);
            cmbxStatus.Name = "cmbxStatus";
            cmbxStatus.Size = new Size(300, 23);
            cmbxStatus.TabIndex = 15;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(111, 380);
            txtRemarks.MaxLength = 45;
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(300, 46);
            txtRemarks.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 383);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 17;
            label7.Text = "Remarks";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 356);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 20;
            label9.Text = "Repaired date";
            // 
            // dtpRepairedDate
            // 
            dtpRepairedDate.Location = new Point(111, 351);
            dtpRepairedDate.Name = "dtpRepairedDate";
            dtpRepairedDate.Size = new Size(300, 23);
            dtpRepairedDate.TabIndex = 18;
            // 
            // chkRepairedDate
            // 
            chkRepairedDate.AutoSize = true;
            chkRepairedDate.Location = new Point(417, 358);
            chkRepairedDate.Name = "chkRepairedDate";
            chkRepairedDate.Size = new Size(15, 14);
            chkRepairedDate.TabIndex = 22;
            chkRepairedDate.UseVisualStyleBackColor = true;
            chkRepairedDate.CheckedChanged += chkRepairedDate_CheckedChanged;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(111, 33);
            txtSerialNumber.MaxLength = 45;
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(300, 23);
            txtSerialNumber.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 35);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 25;
            label2.Text = "Serial Number";
            // 
            // txtOS
            // 
            txtOS.Location = new Point(111, 91);
            txtOS.MaxLength = 45;
            txtOS.Name = "txtOS";
            txtOS.Size = new Size(300, 23);
            txtOS.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 95);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 27;
            label10.Text = "OS";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(111, 62);
            txtModel.MaxLength = 45;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(300, 23);
            txtModel.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 64);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 29;
            label11.Text = "Model";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 124);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 27;
            label12.Text = "RAM";
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(111, 120);
            txtRAM.MaxLength = 45;
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(300, 23);
            txtRAM.TabIndex = 26;
            // 
            // txtSophosTamper
            // 
            txtSophosTamper.Location = new Point(111, 178);
            txtSophosTamper.MaxLength = 45;
            txtSophosTamper.Name = "txtSophosTamper";
            txtSophosTamper.Size = new Size(300, 23);
            txtSophosTamper.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 182);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 32;
            label13.Text = "Sophos Tamper";
            // 
            // txtComputerName
            // 
            txtComputerName.Location = new Point(111, 149);
            txtComputerName.MaxLength = 45;
            txtComputerName.Name = "txtComputerName";
            txtComputerName.Size = new Size(300, 23);
            txtComputerName.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 153);
            label14.Name = "label14";
            label14.Size = new Size(99, 15);
            label14.TabIndex = 33;
            label14.Text = "Computer Name ";
            // 
            // nudUnitCost
            // 
            nudUnitCost.DecimalPlaces = 2;
            nudUnitCost.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudUnitCost.Location = new Point(111, 236);
            nudUnitCost.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudUnitCost.Name = "nudUnitCost";
            nudUnitCost.Size = new Size(300, 23);
            nudUnitCost.TabIndex = 35;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 239);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 34;
            label15.Text = "Unit Cost";
            // 
            // chkUser
            // 
            chkUser.AutoSize = true;
            chkUser.Location = new Point(417, 326);
            chkUser.Name = "chkUser";
            chkUser.Size = new Size(15, 14);
            chkUser.TabIndex = 10;
            chkUser.UseVisualStyleBackColor = true;
            chkUser.CheckedChanged += chkSupplier_CheckedChanged;
            // 
            // UcStocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nudUnitCost);
            Controls.Add(label15);
            Controls.Add(txtSophosTamper);
            Controls.Add(label13);
            Controls.Add(txtComputerName);
            Controls.Add(label14);
            Controls.Add(txtModel);
            Controls.Add(label11);
            Controls.Add(txtRAM);
            Controls.Add(label12);
            Controls.Add(txtOS);
            Controls.Add(label10);
            Controls.Add(txtSerialNumber);
            Controls.Add(label2);
            Controls.Add(chkRepairedDate);
            Controls.Add(label9);
            Controls.Add(dtpRepairedDate);
            Controls.Add(txtRemarks);
            Controls.Add(label7);
            Controls.Add(cmbxStatus);
            Controls.Add(label6);
            Controls.Add(txtUser);
            Controls.Add(label5);
            Controls.Add(chkUser);
            Controls.Add(label1);
            Controls.Add(cmbSupplier);
            Controls.Add(label3);
            Controls.Add(dtpDateAcquired);
            Controls.Add(lblStoreWarehouse);
            Controls.Add(cmbBranch);
            Name = "UcStocksForm";
            Size = new Size(442, 435);
            Load += UcStoreStocks_Load;
            ((System.ComponentModel.ISupportInitialize)epStockCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStoreWarehouse;
        private ErrorProvider epStockCount;
        private Label label3;
        internal ComboBox cmbBranch;
        internal DateTimePicker dtpDateAcquired;
        private Label label1;
        internal ComboBox cmbSupplier;
        internal TextBox txtUser;
        private Label label5;
        internal ComboBox cmbxStatus;
        private Label label6;
        internal TextBox txtRemarks;
        private Label label7;
        private Label label9;
        internal DateTimePicker dtpRepairedDate;
        internal CheckBox chkRepairedDate;
        internal TextBox txtSerialNumber;
        private Label label2;
        internal TextBox txtModel;
        private Label label11;
        internal TextBox txtOS;
        private Label label10;
        internal TextBox txtRAM;
        private Label label12;
        internal TextBox txtSophosTamper;
        private Label label13;
        internal TextBox txtComputerName;
        private Label label14;
        private Label label15;
        internal CheckBox chkUser;
        internal NumericUpDown nudUnitCost;
    }
}
