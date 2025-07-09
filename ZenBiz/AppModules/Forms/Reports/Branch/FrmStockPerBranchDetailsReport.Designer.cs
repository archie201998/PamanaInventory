namespace ZenBiz.AppModules.Forms.Reports.Store
{
    partial class FrmStockPerBranchDetailsReport
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
            btnGenerate = new Button();
            label1 = new Label();
            cmbBranches = new ComboBox();
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
            groupBox1.Size = new Size(577, 58);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGenerate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbBranches);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 36);
            panel2.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(252, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(115, 23);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "Branches";
            // 
            // cmbBranches
            // 
            cmbBranches.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranches.FormattingEnabled = true;
            cmbBranches.Location = new Point(65, 3);
            cmbBranches.Name = "cmbBranches";
            cmbBranches.Size = new Size(181, 23);
            cmbBranches.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 491);
            panel1.TabIndex = 3;
            // 
            // FrmStockPerBranchDetailsReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 580);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(1121, 619);
            Name = "FrmStockPerBranchDetailsReport";
            Text = "Branch Stock Details";
            Load += FrmStockAdjustmentStoreReport_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private Button btnGenerate;
        private Label label1;
        private ComboBox cmbBranches;
        private Panel panel1;
    }
}