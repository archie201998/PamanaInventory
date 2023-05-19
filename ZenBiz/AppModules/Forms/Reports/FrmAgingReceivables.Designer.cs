namespace ZenBiz.AppModules.Forms.Reports
{
    partial class FrmAgingReceivables
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
            label1 = new Label();
            cmbCustomers = new ComboBox();
            btnGenerate = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 58);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbCustomers);
            panel2.Controls.Add(btnGenerate);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 36);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 12;
            label1.Text = "Customers";
            // 
            // cmbCustomers
            // 
            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(66, 3);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(197, 23);
            cmbCustomers.TabIndex = 11;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(269, 2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(115, 23);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 473);
            panel1.TabIndex = 6;
            // 
            // FrmAgingReceivables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(1000, 600);
            Name = "FrmAgingReceivables";
            Text = "Accounts Receivable Aging Report";
            Load += FrmAgingReceivables_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private Label label1;
        private ComboBox cmbCustomers;
        private Button btnGenerate;
        private Panel panel1;
    }
}