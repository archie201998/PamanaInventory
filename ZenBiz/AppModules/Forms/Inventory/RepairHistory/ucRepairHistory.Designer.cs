namespace PamanaWaterInventory.AppModules.Forms.Inventory.RepairHistory
{
    partial class ucRepairHistory
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
            label15 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            dtpDateRepaired = new DateTimePicker();
            nudRepairCost = new NumericUpDown();
            label2 = new Label();
            txtOtherDetails = new TextBox();
            label4 = new Label();
            txtIssueDescription = new TextBox();
            txtReportedBy = new TextBox();
            txtRepairAction = new TextBox();
            txtRepairedBy = new TextBox();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudRepairCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 24);
            label15.Name = "label15";
            label15.Size = new Size(96, 15);
            label15.TabIndex = 42;
            label15.Text = "Issue Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 174);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 41;
            label6.Text = "Repair Action";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 148);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 39;
            label1.Text = "Repaired Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 87);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 35;
            label3.Text = "Reported By";
            // 
            // dtpDateRepaired
            // 
            dtpDateRepaired.Location = new Point(130, 142);
            dtpDateRepaired.Name = "dtpDateRepaired";
            dtpDateRepaired.Size = new Size(300, 23);
            dtpDateRepaired.TabIndex = 36;
            // 
            // nudRepairCost
            // 
            nudRepairCost.DecimalPlaces = 2;
            nudRepairCost.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudRepairCost.Location = new Point(130, 200);
            nudRepairCost.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudRepairCost.Name = "nudRepairCost";
            nudRepairCost.Size = new Size(300, 23);
            nudRepairCost.TabIndex = 43;
            nudRepairCost.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 202);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 44;
            label2.Text = "Cost";
            // 
            // txtOtherDetails
            // 
            txtOtherDetails.Location = new Point(130, 229);
            txtOtherDetails.MaxLength = 99;
            txtOtherDetails.Multiline = true;
            txtOtherDetails.Name = "txtOtherDetails";
            txtOtherDetails.Size = new Size(300, 64);
            txtOtherDetails.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 232);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 45;
            label4.Text = "Other Details";
            // 
            // txtIssueDescription
            // 
            txtIssueDescription.Location = new Point(130, 21);
            txtIssueDescription.MaxLength = 99;
            txtIssueDescription.Multiline = true;
            txtIssueDescription.Name = "txtIssueDescription";
            txtIssueDescription.Size = new Size(300, 55);
            txtIssueDescription.TabIndex = 48;
            // 
            // txtReportedBy
            // 
            txtReportedBy.Location = new Point(130, 84);
            txtReportedBy.MaxLength = 99;
            txtReportedBy.Name = "txtReportedBy";
            txtReportedBy.Size = new Size(300, 23);
            txtReportedBy.TabIndex = 49;
            // 
            // txtRepairAction
            // 
            txtRepairAction.Location = new Point(130, 171);
            txtRepairAction.MaxLength = 99;
            txtRepairAction.Name = "txtRepairAction";
            txtRepairAction.Size = new Size(300, 23);
            txtRepairAction.TabIndex = 49;
            // 
            // txtRepairedBy
            // 
            txtRepairedBy.Location = new Point(130, 113);
            txtRepairedBy.MaxLength = 99;
            txtRepairedBy.Name = "txtRepairedBy";
            txtRepairedBy.Size = new Size(300, 23);
            txtRepairedBy.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 116);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 50;
            label5.Text = "Repaired By";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ucRepairHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtRepairedBy);
            Controls.Add(label5);
            Controls.Add(txtRepairAction);
            Controls.Add(txtReportedBy);
            Controls.Add(txtIssueDescription);
            Controls.Add(txtOtherDetails);
            Controls.Add(label4);
            Controls.Add(nudRepairCost);
            Controls.Add(label2);
            Controls.Add(label15);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dtpDateRepaired);
            Name = "ucRepairHistory";
            Size = new Size(465, 303);
            Load += ucRepairHistory_Load;
            ((System.ComponentModel.ISupportInitialize)nudRepairCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label15;
        private Label label6;
        private Label label1;
        private Label label3;
        internal DateTimePicker dtpDateRepaired;
        internal NumericUpDown nudRepairCost;
        private Label label2;
        internal TextBox txtOtherDetails;
        private Label label4;
        internal TextBox txtIssueDescription;
        internal TextBox txtReportedBy;
        internal TextBox txtRepairAction;
        internal TextBox txtRepairedBy;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}
