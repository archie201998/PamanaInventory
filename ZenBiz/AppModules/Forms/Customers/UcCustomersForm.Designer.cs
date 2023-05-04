namespace ZenBiz.AppModules.Forms.Customers
{
    partial class UcCustomersForm
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
            txtName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtContactInfo = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            epName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epName).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(85, 3);
            txtName.MaxLength = 99;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 0;
            txtName.Validating += txtFirstName_Validating;
            txtName.Validated += txtFirstName_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 35);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Contact Info";
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(85, 32);
            txtContactInfo.MaxLength = 99;
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(300, 23);
            txtContactInfo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 64);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(85, 61);
            txtAddress.MaxLength = 250;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 23);
            txtAddress.TabIndex = 8;
            // 
            // epName
            // 
            epName.ContainerControl = this;
            // 
            // UcCustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtContactInfo);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "UcCustomersForm";
            Size = new Size(410, 97);
            ((System.ComponentModel.ISupportInitialize)epName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider epName;
        internal TextBox txtName;
        internal TextBox txtMidInitial;
        internal TextBox txtLastName;
        internal TextBox txtContactInfo;
        internal TextBox txtAddress;
    }
}
