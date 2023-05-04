namespace ZenBiz.AppModules.Forms.Inventory.Stocks
{
    partial class UcStocks
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
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Quantity";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(107, 3);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(300, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Stock Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(107, 61);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Expiration";
            // 
            // UcStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "UcStocks";
            Size = new Size(513, 155);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
    }
}
