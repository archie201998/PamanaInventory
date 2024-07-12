namespace ZenBiz.AppModules.Forms.Reports
{
    partial class FrmSalesDueReport
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
            panel1 = new Panel();
            cmbMonth = new ComboBox();
            label1 = new Label();
            btnGenerate = new Button();
            nudYear = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 507);
            panel1.TabIndex = 0;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(62, 13);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(173, 23);
            cmbMonth.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Month";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(316, 13);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(241, 13);
            nudYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(69, 23);
            nudYear.TabIndex = 4;
            nudYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // FrmSalesDueReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(nudYear);
            Controls.Add(btnGenerate);
            Controls.Add(label1);
            Controls.Add(cmbMonth);
            Controls.Add(panel1);
            Name = "FrmSalesDueReport";
            Text = "Sales Due Report";
            Load += FrmSalesDueReport_Load;
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbMonth;
        private Label label1;
        private Button btnGenerate;
        private NumericUpDown nudYear;
    }
}