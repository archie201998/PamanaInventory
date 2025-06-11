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
            epStockCount = new ErrorProvider(components);
            dtpStockDate = new DateTimePicker();
            label3 = new Label();
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
            label9 = new Label();
            dtpRepairedDate = new DateTimePicker();
            chkRepairedDate = new CheckBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox6 = new TextBox();
            label14 = new Label();
            numericUpDown1 = new NumericUpDown();
            label15 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)epStockCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cmbStoreWarehouse
            // 
            cmbStoreWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStoreWarehouse.FormattingEnabled = true;
            cmbStoreWarehouse.Location = new Point(111, 4);
            cmbStoreWarehouse.Name = "cmbStoreWarehouse";
            cmbStoreWarehouse.Size = new Size(300, 23);
            cmbStoreWarehouse.TabIndex = 0;
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
            // dtpStockDate
            // 
            dtpStockDate.Location = new Point(111, 207);
            dtpStockDate.Name = "dtpStockDate";
            dtpStockDate.Size = new Size(300, 23);
            dtpStockDate.TabIndex = 2;
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
            // chkStockDate
            // 
            chkStockDate.AutoSize = true;
            chkStockDate.Location = new Point(417, 213);
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
            // chkSupplier
            // 
            chkSupplier.AutoSize = true;
            chkSupplier.Location = new Point(417, 298);
            chkSupplier.Name = "chkSupplier";
            chkSupplier.Size = new Size(15, 14);
            chkSupplier.TabIndex = 10;
            chkSupplier.UseVisualStyleBackColor = true;
            chkSupplier.CheckedChanged += chkSupplier_CheckedChanged;
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
            // textBox1
            // 
            textBox1.Location = new Point(111, 33);
            textBox1.MaxLength = 45;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 24;
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
            // textBox2
            // 
            textBox2.Location = new Point(111, 91);
            textBox2.MaxLength = 45;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 23);
            textBox2.TabIndex = 26;
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
            // textBox3
            // 
            textBox3.Location = new Point(111, 62);
            textBox3.MaxLength = 45;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 23);
            textBox3.TabIndex = 28;
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
            // textBox4
            // 
            textBox4.Location = new Point(111, 120);
            textBox4.MaxLength = 45;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 23);
            textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(111, 178);
            textBox5.MaxLength = 45;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 23);
            textBox5.TabIndex = 30;
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
            // textBox6
            // 
            textBox6.Location = new Point(111, 149);
            textBox6.MaxLength = 45;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(300, 23);
            textBox6.TabIndex = 31;
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
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(111, 236);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(300, 23);
            numericUpDown1.TabIndex = 35;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(417, 326);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 10;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += chkSupplier_CheckedChanged;
            // 
            // UcStocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numericUpDown1);
            Controls.Add(label15);
            Controls.Add(textBox5);
            Controls.Add(label13);
            Controls.Add(textBox6);
            Controls.Add(label14);
            Controls.Add(textBox3);
            Controls.Add(label11);
            Controls.Add(textBox4);
            Controls.Add(label12);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(textBox1);
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
            Controls.Add(checkBox1);
            Controls.Add(chkSupplier);
            Controls.Add(label1);
            Controls.Add(cmbSupplier);
            Controls.Add(chkStockDate);
            Controls.Add(label3);
            Controls.Add(dtpStockDate);
            Controls.Add(lblStoreWarehouse);
            Controls.Add(cmbStoreWarehouse);
            Name = "UcStocksForm";
            Size = new Size(442, 435);
            Load += UcStoreStocks_Load;
            ((System.ComponentModel.ISupportInitialize)epStockCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStoreWarehouse;
        private ErrorProvider epStockCount;
        private Label label3;
        internal ComboBox cmbStoreWarehouse;
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
        private Label label9;
        internal DateTimePicker dtpRepairedDate;
        internal CheckBox chkRepairedDate;
        internal TextBox textBox1;
        private Label label2;
        internal TextBox textBox3;
        private Label label11;
        internal TextBox textBox2;
        private Label label10;
        internal TextBox textBox4;
        private Label label12;
        internal TextBox textBox5;
        private Label label13;
        internal TextBox textBox6;
        private Label label14;
        private NumericUpDown numericUpDown1;
        private Label label15;
        internal CheckBox checkBox1;
    }
}
