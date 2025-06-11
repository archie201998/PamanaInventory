namespace ZenBiz.AppModules.Forms.Inventory.Items
{
    partial class UcItemDetails
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
            txtCode = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            cmbCategory = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            cmbUnit = new ComboBox();
            epCode = new ErrorProvider(components);
            epName = new ErrorProvider(components);
            epCategory = new ErrorProvider(components);
            epUOM = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epUOM).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(129, 3);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(300, 23);
            txtCode.TabIndex = 0;
            txtCode.Validating += txtCode_Validating;
            txtCode.Validated += txtCode_Validated;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            txtName.Validated += txtName_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(129, 61);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 23);
            cmbCategory.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 64);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 93);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 17;
            label9.Text = "Unit";
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(129, 90);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(300, 23);
            cmbUnit.TabIndex = 8;
            // 
            // epCode
            // 
            epCode.ContainerControl = this;
            // 
            // epName
            // 
            epName.ContainerControl = this;
            // 
            // epCategory
            // 
            epCategory.ContainerControl = this;
            // 
            // epUOM
            // 
            epUOM.ContainerControl = this;
            // 
            // UcItemDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(cmbUnit);
            Controls.Add(label8);
            Controls.Add(cmbCategory);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "UcItemDetails";
            Size = new Size(461, 122);
            Load += UcItemDetails_Load;
            ((System.ComponentModel.ISupportInitialize)epCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)epName).EndInit();
            ((System.ComponentModel.ISupportInitialize)epCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)epUOM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label8;
        private Label label9;
        private ErrorProvider epCode;
        private ErrorProvider epName;
        internal TextBox txtCode;
        internal TextBox txtName;
        internal ComboBox cmbCategory;
        internal ComboBox cmbUnit;
        private ErrorProvider epCategory;
        private ErrorProvider epUOM;
    }
}
