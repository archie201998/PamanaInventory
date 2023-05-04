namespace ZenBiz.AppModules.Forms.Inventory.Suppliers
{
    partial class UcSupplier
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
            txtName = new TextBox();
            txtAddress = new TextBox();
            label2 = new Label();
            txtContactInfo = new TextBox();
            label3 = new Label();
            epName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epName).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 3);
            txtName.MaxLength = 99;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            txtName.Validated += txtName_Validated;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(87, 32);
            txtAddress.MaxLength = 99;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 23);
            txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(87, 61);
            txtContactInfo.MaxLength = 99;
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(300, 23);
            txtContactInfo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 64);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Contact Info";
            // 
            // epName
            // 
            epName.ContainerControl = this;
            // 
            // UcSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtContactInfo);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "UcSupplier";
            Size = new Size(412, 96);
            ((System.ComponentModel.ISupportInitialize)epName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider epName;
        internal TextBox txtName;
        internal TextBox txtAddress;
        internal TextBox txtContactInfo;
    }
}
