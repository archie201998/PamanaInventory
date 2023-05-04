namespace ZenBiz.AppModules.Forms.Inventory.StockAdjustment
{
    partial class UcStockAdjustments
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
            nudQuantity = new NumericUpDown();
            txtReason = new TextBox();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            epQuantity = new ErrorProvider(components);
            epReason = new ErrorProvider(components);
            lblStoreWarehouse = new Label();
            cmbStoreWarehouse = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epReason).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Quantity";
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 2;
            nudQuantity.Location = new Point(75, 32);
            nudQuantity.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(300, 23);
            nudQuantity.TabIndex = 0;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(75, 90);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(300, 82);
            txtReason.TabIndex = 2;
            txtReason.Validating += txtReason_Validating;
            txtReason.Validated += txtReason_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 93);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Reason";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(75, 61);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(300, 23);
            dtpDate.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // epQuantity
            // 
            epQuantity.ContainerControl = this;
            // 
            // epReason
            // 
            epReason.ContainerControl = this;
            // 
            // lblStoreWarehouse
            // 
            lblStoreWarehouse.AutoSize = true;
            lblStoreWarehouse.Location = new Point(3, 6);
            lblStoreWarehouse.Name = "lblStoreWarehouse";
            lblStoreWarehouse.Size = new Size(98, 15);
            lblStoreWarehouse.TabIndex = 6;
            lblStoreWarehouse.Text = "Store/Warehouse";
            // 
            // cmbStoreWarehouse
            // 
            cmbStoreWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStoreWarehouse.FormattingEnabled = true;
            cmbStoreWarehouse.Location = new Point(75, 3);
            cmbStoreWarehouse.Name = "cmbStoreWarehouse";
            cmbStoreWarehouse.Size = new Size(300, 23);
            cmbStoreWarehouse.TabIndex = 7;
            // 
            // UcStockAdjustments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbStoreWarehouse);
            Controls.Add(lblStoreWarehouse);
            Controls.Add(label3);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(txtReason);
            Controls.Add(nudQuantity);
            Controls.Add(label1);
            Name = "UcStockAdjustments";
            Size = new Size(403, 184);
            Load += UcStockAdjustments_Load;
            Validating += UcStockAdjustments_Validating;
            Validated += UcStockAdjustments_Validated;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)epQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)epReason).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider epQuantity;
        private ErrorProvider epReason;
        internal NumericUpDown nudQuantity;
        internal TextBox txtReason;
        internal DateTimePicker dtpDate;
        private Label lblStoreWarehouse;
        internal ComboBox cmbStoreWarehouse;
    }
}
