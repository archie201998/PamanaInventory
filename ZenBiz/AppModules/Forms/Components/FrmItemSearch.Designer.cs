namespace ZenBiz.AppModules.Forms.Components
{
    partial class FrmItemSearch
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
            btnSelect = new Button();
            txtSearch = new TextBox();
            dgItems = new DataGridView();
            cmbStores = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgItems).BeginInit();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(894, 392);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(101, 23);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select Item";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(181, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgItems
            // 
            dgItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItems.Location = new Point(12, 41);
            dgItems.Name = "dgItems";
            dgItems.RowTemplate.Height = 25;
            dgItems.Size = new Size(983, 345);
            dgItems.TabIndex = 2;
            dgItems.CellMouseDoubleClick += dgItems_CellMouseDoubleClick;
            // 
            // cmbStores
            // 
            cmbStores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStores.FormattingEnabled = true;
            cmbStores.Location = new Point(12, 12);
            cmbStores.Name = "cmbStores";
            cmbStores.Size = new Size(163, 23);
            cmbStores.TabIndex = 3;
            cmbStores.SelectedValueChanged += cmbStores_SelectedValueChanged;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 392);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(437, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FrmItemSearch
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 427);
            Controls.Add(btnSearch);
            Controls.Add(progressBar1);
            Controls.Add(cmbStores);
            Controls.Add(dgItems);
            Controls.Add(txtSearch);
            Controls.Add(btnSelect);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmItemSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Item";
            Load += FrmItemSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelect;
        private DataGridView dgItems;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button btnSearch;
        internal TextBox txtSearch;
        internal ComboBox cmbStores;
    }
}