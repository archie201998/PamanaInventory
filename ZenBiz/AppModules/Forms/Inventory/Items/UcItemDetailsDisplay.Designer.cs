namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    partial class UcItemDetailsDisplay
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
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            txtMinStockThreshold = new TextBox();
            label7 = new Label();
            txtUnitCost = new TextBox();
            label5 = new Label();
            txtUnit = new TextBox();
            label4 = new Label();
            txtCategory = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtCode = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(853, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMinStockThreshold);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtUnitCost);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUnit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCode);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 166);
            panel1.TabIndex = 0;
            // 
            // txtMinStockThreshold
            // 
            txtMinStockThreshold.Location = new Point(523, 6);
            txtMinStockThreshold.Name = "txtMinStockThreshold";
            txtMinStockThreshold.ReadOnly = true;
            txtMinStockThreshold.Size = new Size(297, 23);
            txtMinStockThreshold.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 9);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 34;
            label7.Text = "Min. Stock Threshold";
            // 
            // txtUnitCost
            // 
            txtUnitCost.Location = new Point(66, 119);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.ReadOnly = true;
            txtUnitCost.Size = new Size(297, 23);
            txtUnitCost.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 122);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 26;
            label5.Text = "Unit Cost";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(66, 90);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(297, 23);
            txtUnit.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 93);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 24;
            label4.Text = "Unit";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(66, 61);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(297, 23);
            txtCategory.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 64);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 22;
            label3.Text = "Category";
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 32);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(297, 23);
            txtName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(66, 3);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(297, 23);
            txtCode.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 18;
            label1.Text = "Code";
            // 
            // UcItemDetailsDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UcItemDetailsDisplay";
            Size = new Size(856, 194);
            Load += UcItemDetailsDisplay_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox txtMinStockThreshold;
        private Label label7;
        private TextBox txtUnitCost;
        private Label label5;
        private TextBox txtUnit;
        private Label label4;
        private TextBox txtCategory;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtCode;
        private Label label1;
    }
}
