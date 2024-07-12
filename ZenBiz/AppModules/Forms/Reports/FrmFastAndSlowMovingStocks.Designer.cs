namespace ZenBiz.AppModules.Forms.Reports
{
    partial class FrmFastAndSlowMovingStocks
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
            label1 = new Label();
            cmbStores = new ComboBox();
            btnGenerate = new Button();
            panel1 = new Panel();
            radFastMoving = new RadioButton();
            radSlowMoving = new RadioButton();
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
            groupBox1.Size = new Size(940, 88);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parameters";
            // 
            // panel2
            // 
            panel2.Controls.Add(radSlowMoving);
            panel2.Controls.Add(radFastMoving);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dtpTo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpFrom);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbStores);
            panel2.Controls.Add(btnGenerate);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 66);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 7);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 16;
            label3.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(480, 4);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 7);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 14;
            label2.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(249, 4);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 12;
            label1.Text = "Store";
            // 
            // cmbStores
            // 
            cmbStores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStores.FormattingEnabled = true;
            cmbStores.Location = new Point(43, 3);
            cmbStores.Name = "cmbStores";
            cmbStores.Size = new Size(155, 23);
            cmbStores.TabIndex = 11;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(686, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(115, 23);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 443);
            panel1.TabIndex = 6;
            // 
            // radFastMoving
            // 
            radFastMoving.AutoSize = true;
            radFastMoving.Checked = true;
            radFastMoving.Location = new Point(3, 32);
            radFastMoving.Name = "radFastMoving";
            radFastMoving.Size = new Size(90, 19);
            radFastMoving.TabIndex = 17;
            radFastMoving.TabStop = true;
            radFastMoving.Tag = "DESC";
            radFastMoving.Text = "Fast moving";
            radFastMoving.UseVisualStyleBackColor = true;
            // 
            // radSlowMoving
            // 
            radSlowMoving.AutoSize = true;
            radSlowMoving.Location = new Point(99, 32);
            radSlowMoving.Name = "radSlowMoving";
            radSlowMoving.Size = new Size(94, 19);
            radSlowMoving.TabIndex = 18;
            radSlowMoving.Tag = "ASC";
            radSlowMoving.Text = "Slow moving";
            radSlowMoving.UseVisualStyleBackColor = true;
            // 
            // FrmFastAndSlowMovingStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FrmFastAndSlowMovingStocks";
            Text = "Fast & Slow Moving Stocks";
            Load += FrmFastAndSlowMovingStocks_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private Label label1;
        private ComboBox cmbStores;
        private Button btnGenerate;
        private Panel panel1;
        private Label label3;
        private DateTimePicker dtpTo;
        private Label label2;
        private DateTimePicker dtpFrom;
        private RadioButton radSlowMoving;
        private RadioButton radFastMoving;
    }
}