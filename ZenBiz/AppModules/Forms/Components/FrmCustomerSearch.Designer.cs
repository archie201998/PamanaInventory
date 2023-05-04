namespace ZenBiz.AppModules.Forms.Components
{
    partial class FrmCustomerSearch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            dgCustomers = new DataGridView();
            btnSelectCustomer = new Button();
            btnCustomerAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgCustomers
            // 
            dgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomers.Location = new Point(12, 41);
            dgCustomers.Name = "dgCustomers";
            dgCustomers.RowTemplate.Height = 25;
            dgCustomers.Size = new Size(812, 368);
            dgCustomers.TabIndex = 1;
            dgCustomers.CellMouseDoubleClick += dgCustomers_CellMouseDoubleClick;
            // 
            // btnSelectCustomer
            // 
            btnSelectCustomer.Location = new Point(749, 415);
            btnSelectCustomer.Name = "btnSelectCustomer";
            btnSelectCustomer.Size = new Size(75, 23);
            btnSelectCustomer.TabIndex = 2;
            btnSelectCustomer.Text = "Select";
            btnSelectCustomer.UseVisualStyleBackColor = true;
            btnSelectCustomer.Click += btnSelectCustomer_Click;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new Point(12, 415);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(114, 23);
            btnCustomerAdd.TabIndex = 3;
            btnCustomerAdd.Text = "Add Customer";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // FrmCustomerSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(btnCustomerAdd);
            Controls.Add(btnSelectCustomer);
            Controls.Add(dgCustomers);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmCustomerSearch";
            Text = "Search Customer";
            Load += FrmCustomerSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgCustomers;
        private Button btnSelectCustomer;
        private Button btnCustomerAdd;
    }
}