namespace ZenBiz.AppModules.Forms.Payments
{
    partial class UcPayments
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
            label2 = new Label();
            cmbPaymentType = new ComboBox();
            nudAmountPaid = new NumericUpDown();
            txtReferenceCode = new TextBox();
            dtpPaymentDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            epAmount = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudAmountPaid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Payment Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Reference Code";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(98, 3);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(280, 23);
            cmbPaymentType.TabIndex = 0;
            // 
            // nudAmountPaid
            // 
            nudAmountPaid.DecimalPlaces = 2;
            nudAmountPaid.Location = new Point(99, 61);
            nudAmountPaid.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudAmountPaid.Name = "nudAmountPaid";
            nudAmountPaid.Size = new Size(279, 23);
            nudAmountPaid.TabIndex = 2;
            nudAmountPaid.Validating += nudAmountPaid_Validating;
            nudAmountPaid.Validated += nudAmountPaid_Validated;
            // 
            // txtReferenceCode
            // 
            txtReferenceCode.Location = new Point(99, 32);
            txtReferenceCode.Name = "txtReferenceCode";
            txtReferenceCode.Size = new Size(279, 23);
            txtReferenceCode.TabIndex = 1;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Location = new Point(98, 90);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(280, 23);
            dtpPaymentDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 63);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Date";
            // 
            // epAmount
            // 
            epAmount.ContainerControl = this;
            // 
            // UcPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpPaymentDate);
            Controls.Add(txtReferenceCode);
            Controls.Add(nudAmountPaid);
            Controls.Add(cmbPaymentType);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UcPayments";
            Size = new Size(404, 124);
            Load += UcPayments_Load;
            ((System.ComponentModel.ISupportInitialize)nudAmountPaid).EndInit();
            ((System.ComponentModel.ISupportInitialize)epAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ErrorProvider epAmount;
        internal ComboBox cmbPaymentType;
        internal NumericUpDown nudAmountPaid;
        internal TextBox txtReferenceCode;
        internal DateTimePicker dtpPaymentDate;
    }
}
