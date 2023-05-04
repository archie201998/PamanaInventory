namespace ZenBiz.AppModules.Forms.Reports
{
    partial class FrmStockAdjustmentsReport
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
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            label3 = new Label();
            dtpTo = new DateTimePicker();
            label2 = new Label();
            dtpFrom = new DateTimePicker();
            btnGenerate = new Button();
            lblStoreWarehouseComboBoxText = new Label();
            cmbStoreWarehouse = new ComboBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(899, 58);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dtpTo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpFrom);
            panel2.Controls.Add(btnGenerate);
            panel2.Controls.Add(lblStoreWarehouseComboBoxText);
            panel2.Controls.Add(cmbStoreWarehouse);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(893, 36);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 6);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 10;
            label3.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(537, 3);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 6);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(291, 3);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 7;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(743, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(115, 23);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblStoreWarehouseComboBoxText
            // 
            lblStoreWarehouseComboBoxText.AutoSize = true;
            lblStoreWarehouseComboBoxText.Location = new Point(4, 6);
            lblStoreWarehouseComboBoxText.Name = "lblStoreWarehouseComboBoxText";
            lblStoreWarehouseComboBoxText.Size = new Size(66, 15);
            lblStoreWarehouseComboBoxText.TabIndex = 2;
            lblStoreWarehouseComboBoxText.Text = "Warehouse";
            // 
            // cmbStoreWarehouse
            // 
            cmbStoreWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStoreWarehouse.FormattingEnabled = true;
            cmbStoreWarehouse.Location = new Point(76, 3);
            cmbStoreWarehouse.Name = "cmbStoreWarehouse";
            cmbStoreWarehouse.Size = new Size(155, 23);
            cmbStoreWarehouse.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 492);
            panel1.TabIndex = 4;
            // 
            // FrmStockAdjustmentsReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 580);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(1121, 619);
            Name = "FrmStockAdjustmentsReport";
            Text = "Stock Adjustmnet Report";
            Load += FrmStockAdjustmentsReport_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private Label label3;
        private DateTimePicker dtpTo;
        private Label label2;
        private DateTimePicker dtpFrom;
        private Button btnGenerate;
        private Label lblStoreWarehouseComboBoxText;
        private ComboBox cmbStoreWarehouse;
        private Panel panel1;
    }
}