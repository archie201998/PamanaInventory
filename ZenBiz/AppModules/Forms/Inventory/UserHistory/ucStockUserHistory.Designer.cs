namespace PamanaWaterInventory.AppModules.Forms.Inventory.UserHistory
{
    partial class ucStockUserHistory
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
            txtUser = new TextBox();
            label2 = new Label();
            dtpDateAssigned = new DateTimePicker();
            label1 = new Label();
            dtpDateReturned = new DateTimePicker();
            label3 = new Label();
            cmbBranch = new ComboBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            checkBox1 = new CheckBox();
            cbxCurrentUser = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(104, 39);
            txtUser.MaxLength = 45;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 23);
            txtUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 27;
            label2.Text = "User";
            // 
            // dtpDateAssigned
            // 
            dtpDateAssigned.Format = DateTimePickerFormat.Short;
            dtpDateAssigned.Location = new Point(104, 72);
            dtpDateAssigned.Name = "dtpDateAssigned";
            dtpDateAssigned.Size = new Size(300, 23);
            dtpDateAssigned.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 27;
            label1.Text = "Date Assigned";
            // 
            // dtpDateReturned
            // 
            dtpDateReturned.Enabled = false;
            dtpDateReturned.Format = DateTimePickerFormat.Short;
            dtpDateReturned.Location = new Point(104, 101);
            dtpDateReturned.Name = "dtpDateReturned";
            dtpDateReturned.Size = new Size(300, 23);
            dtpDateReturned.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 29;
            label3.Text = "Date Returned";
            // 
            // cmbBranch
            // 
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(104, 10);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(300, 23);
            cmbBranch.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 10);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 33;
            label4.Text = "Branch";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(410, 106);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 34;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbxCurrentUser
            // 
            cbxCurrentUser.AutoSize = true;
            cbxCurrentUser.Location = new Point(104, 130);
            cbxCurrentUser.Name = "cbxCurrentUser";
            cbxCurrentUser.Size = new Size(92, 19);
            cbxCurrentUser.TabIndex = 35;
            cbxCurrentUser.Text = "Current User";
            cbxCurrentUser.UseVisualStyleBackColor = true;
            cbxCurrentUser.CheckedChanged += cbxCurrentUser_CheckedChanged;
            // 
            // ucStockUserHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbxCurrentUser);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(cmbBranch);
            Controls.Add(dtpDateReturned);
            Controls.Add(label3);
            Controls.Add(dtpDateAssigned);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ucStockUserHistory";
            Size = new Size(430, 155);
            Load += ucStockUserHistory_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox txtUser;
        private Label label2;
        private Label label1;
        private Label label3;
        internal ComboBox cmbBranch;
        private Label label4;
        private ErrorProvider errorProvider1;
        internal DateTimePicker dtpDateAssigned;
        internal DateTimePicker dtpDateReturned;
        internal CheckBox checkBox1;
        internal CheckBox cbxCurrentUser;
    }
}
