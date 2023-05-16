namespace ZenBiz.AppModules.Forms.Components
{
    partial class FrmSupplierSearch
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
            btnSupplierAdd = new Button();
            btnSelectSupplier = new Button();
            dgSuppliers = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgSuppliers).BeginInit();
            SuspendLayout();
            // 
            // btnSupplierAdd
            // 
            btnSupplierAdd.Location = new Point(12, 415);
            btnSupplierAdd.Name = "btnSupplierAdd";
            btnSupplierAdd.Size = new Size(114, 23);
            btnSupplierAdd.TabIndex = 7;
            btnSupplierAdd.Text = "Add Supplier";
            btnSupplierAdd.UseVisualStyleBackColor = true;
            btnSupplierAdd.Click += btnSupplierAdd_Click;
            // 
            // btnSelectSupplier
            // 
            btnSelectSupplier.Location = new Point(749, 415);
            btnSelectSupplier.Name = "btnSelectSupplier";
            btnSelectSupplier.Size = new Size(75, 23);
            btnSelectSupplier.TabIndex = 6;
            btnSelectSupplier.Text = "Select";
            btnSelectSupplier.UseVisualStyleBackColor = true;
            btnSelectSupplier.Click += btnSelectSupplier_Click;
            // 
            // dgSuppliers
            // 
            dgSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSuppliers.Location = new Point(12, 41);
            dgSuppliers.Name = "dgSuppliers";
            dgSuppliers.RowTemplate.Height = 25;
            dgSuppliers.Size = new Size(812, 368);
            dgSuppliers.TabIndex = 5;
            dgSuppliers.CellMouseDoubleClick += dgSuppliers_CellMouseDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FrmSupplierSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(btnSupplierAdd);
            Controls.Add(btnSelectSupplier);
            Controls.Add(dgSuppliers);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmSupplierSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Supplier";
            Load += FrmSupplierSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSupplierAdd;
        private Button btnSelectSupplier;
        private DataGridView dgSuppliers;
        private TextBox txtSearch;
    }
}