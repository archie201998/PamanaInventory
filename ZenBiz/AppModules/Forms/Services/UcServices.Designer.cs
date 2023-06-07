namespace ZenBiz.AppModules.Forms.Services
{
    partial class UcServices
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
            label2 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            nudFee = new NumericUpDown();
            epName = new ErrorProvider(components);
            epFee = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epFee).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 40);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Fee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 11);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 8);
            txtName.MaxLength = 250;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            txtName.Validated += txtName_Validated;
            // 
            // nudFee
            // 
            nudFee.DecimalPlaces = 2;
            nudFee.Location = new Point(66, 38);
            nudFee.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudFee.Name = "nudFee";
            nudFee.Size = new Size(300, 23);
            nudFee.TabIndex = 1;
            nudFee.ThousandsSeparator = true;
            nudFee.Validating += nudFee_Validating;
            nudFee.Validated += nudFee_Validated;
            // 
            // epName
            // 
            epName.ContainerControl = this;
            // 
            // epFee
            // 
            epFee.ContainerControl = this;
            // 
            // UcServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            Controls.Add(nudFee);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtName);
            Name = "UcServices";
            Size = new Size(387, 70);
            ((System.ComponentModel.ISupportInitialize)nudFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)epName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label5;
        internal TextBox txtName;
        private ErrorProvider epName;
        private ErrorProvider epFee;
        internal NumericUpDown nudFee;
    }
}
