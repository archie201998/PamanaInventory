namespace ZenBiz.AppModules.Forms.Inventory.UnitOfMeasurements
{
    partial class UcUnits
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAbbreviation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epAbbreviation = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAbbreviation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.Location = new System.Drawing.Point(86, 3);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.Size = new System.Drawing.Size(300, 23);
            this.txtAbbreviation.TabIndex = 0;
            this.txtAbbreviation.Validating += new System.ComponentModel.CancelEventHandler(this.txtAbbreviation_Validating);
            this.txtAbbreviation.Validated += new System.EventHandler(this.txtAbbreviation_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abbreviation";
            // 
            // epAbbreviation
            // 
            this.epAbbreviation.ContainerControl = this;
            // 
            // UcUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAbbreviation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "UcUnits";
            this.Size = new System.Drawing.Size(412, 70);
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAbbreviation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ErrorProvider epName;
        private Label label2;
        public TextBox txtAbbreviation;
        public TextBox txtName;
        private ErrorProvider epAbbreviation;
    }
}
