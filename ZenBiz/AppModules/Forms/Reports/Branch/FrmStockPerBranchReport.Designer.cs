namespace ZenBiz.AppModules.Forms.Reports
{
    partial class FrmStockPerBranchReport
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
            cmbStores = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            btnGenerate = new Button();
            label2 = new Label();
            cmbCategories = new ComboBox();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 491);
            panel1.TabIndex = 0;
            // 
            // cmbStores
            // 
            cmbStores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStores.FormattingEnabled = true;
            cmbStores.Location = new Point(48, 3);
            cmbStores.Name = "cmbStores";
            cmbStores.Size = new Size(155, 23);
            cmbStores.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Store";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 58);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGenerate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbCategories);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbStores);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 36);
            panel2.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(445, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(115, 23);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 6);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(284, 3);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(155, 23);
            cmbCategories.TabIndex = 4;
            // 
            // FrmStockPerBranchReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 579);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(1179, 618);
            Name = "FrmStockPerBranchReport";
            Text = "Branch Stocks Report";
            Load += FrmStockPerStoreReport_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cmbStores;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label2;
        private ComboBox cmbCategories;
        private Button btnGenerate;
    }
}