namespace ZenBiz.AppModules.Forms.Personnel
{
    partial class UcPersonnel
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
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtContactInfo = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            txtDesignation = new TextBox();
            label2 = new Label();
            epName = new ErrorProvider(components);
            epDesignation = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epDesignation).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 66);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 2;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(85, 63);
            txtAddress.MaxLength = 250;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 23);
            txtAddress.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 37);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 1;
            label4.Text = "Contact Info";
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(85, 34);
            txtContactInfo.MaxLength = 99;
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(300, 23);
            txtContactInfo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 8);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(85, 5);
            txtName.MaxLength = 99;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            txtName.Validated += txtName_Validated;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(85, 92);
            txtDesignation.MaxLength = 250;
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(300, 23);
            txtDesignation.TabIndex = 3;
            txtDesignation.Validating += txtDesignation_Validating;
            txtDesignation.Validated += txtDesignation_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 95);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Designation";
            // 
            // epName
            // 
            epName.ContainerControl = this;
            // 
            // epDesignation
            // 
            epDesignation.ContainerControl = this;
            // 
            // UcPersonnel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtDesignation);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtContactInfo);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "UcPersonnel";
            Size = new Size(412, 120);
            ((System.ComponentModel.ISupportInitialize)epName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epDesignation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        internal TextBox txtAddress;
        private Label label4;
        internal TextBox txtContactInfo;
        private Label label1;
        internal TextBox txtName;
        internal TextBox txtDesignation;
        private Label label2;
        private ErrorProvider epName;
        private ErrorProvider epDesignation;
    }
}
