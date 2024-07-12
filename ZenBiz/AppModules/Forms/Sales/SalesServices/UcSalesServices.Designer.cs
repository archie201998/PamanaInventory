namespace ZenBiz.AppModules.Forms.Sales.SalesServices
{
    partial class UcSalesServices
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
            cmbServices = new ComboBox();
            label1 = new Label();
            cmbPersonnel = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            nudFee = new NumericUpDown();
            epServices = new ErrorProvider(components);
            epPersonnel = new ErrorProvider(components);
            epFee = new ErrorProvider(components);
            cmbStores = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epPersonnel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epFee).BeginInit();
            SuspendLayout();
            // 
            // cmbServices
            // 
            cmbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(74, 32);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(320, 23);
            cmbServices.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Services";
            // 
            // cmbPersonnel
            // 
            cmbPersonnel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonnel.FormattingEnabled = true;
            cmbPersonnel.Location = new Point(74, 61);
            cmbPersonnel.Name = "cmbPersonnel";
            cmbPersonnel.Size = new Size(320, 23);
            cmbPersonnel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 64);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Personnel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 92);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 1;
            label3.Text = "Fee";
            // 
            // nudFee
            // 
            nudFee.DecimalPlaces = 2;
            nudFee.Location = new Point(74, 90);
            nudFee.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudFee.Name = "nudFee";
            nudFee.Size = new Size(320, 23);
            nudFee.TabIndex = 2;
            nudFee.ThousandsSeparator = true;
            // 
            // epServices
            // 
            epServices.ContainerControl = this;
            // 
            // epPersonnel
            // 
            epPersonnel.ContainerControl = this;
            // 
            // epFee
            // 
            epFee.ContainerControl = this;
            // 
            // cmbStores
            // 
            cmbStores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStores.FormattingEnabled = true;
            cmbStores.Location = new Point(74, 3);
            cmbStores.Name = "cmbStores";
            cmbStores.Size = new Size(320, 23);
            cmbStores.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 6);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Store";
            // 
            // UcSalesServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(cmbStores);
            Controls.Add(nudFee);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPersonnel);
            Controls.Add(cmbServices);
            Name = "UcSalesServices";
            Size = new Size(415, 123);
            Load += UcSalesServices_Load;
            ((System.ComponentModel.ISupportInitialize)nudFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)epServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)epPersonnel).EndInit();
            ((System.ComponentModel.ISupportInitialize)epFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider epServices;
        private ErrorProvider epPersonnel;
        private ErrorProvider epFee;
        internal ComboBox cmbServices;
        internal ComboBox cmbPersonnel;
        internal NumericUpDown nudFee;
        private Label label4;
        internal ComboBox cmbStores;
    }
}
