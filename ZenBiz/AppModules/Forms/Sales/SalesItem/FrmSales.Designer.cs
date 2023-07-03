namespace ZenBiz.AppModules.Forms.Sales
{
    partial class FrmSales
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
            dgSales = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dtpTransactionDate = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgSalesItems = new DataGridView();
            tabPage2 = new TabPage();
            dgSalesServices = new DataGridView();
            label1 = new Label();
            txtTotalSales = new TextBox();
            btnPayments = new Button();
            txtCollectibles = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgSales).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSalesItems).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSalesServices).BeginInit();
            SuspendLayout();
            // 
            // dgSales
            // 
            dgSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSales.Location = new Point(12, 41);
            dgSales.Name = "dgSales";
            dgSales.RowTemplate.Height = 25;
            dgSales.Size = new Size(898, 317);
            dgSales.TabIndex = 0;
            dgSales.DataBindingComplete += dgSales_DataBindingComplete;
            dgSales.SelectionChanged += dgSales_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(916, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(916, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(916, 99);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpTransactionDate
            // 
            dtpTransactionDate.Location = new Point(12, 12);
            dtpTransactionDate.Name = "dtpTransactionDate";
            dtpTransactionDate.Size = new Size(200, 23);
            dtpTransactionDate.TabIndex = 4;
            dtpTransactionDate.ValueChanged += dtpTransactionDate_ValueChanged;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 364);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(898, 207);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgSalesItems);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(890, 179);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgSalesItems
            // 
            dgSalesItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSalesItems.Dock = DockStyle.Fill;
            dgSalesItems.Location = new Point(3, 3);
            dgSalesItems.Name = "dgSalesItems";
            dgSalesItems.RowTemplate.Height = 25;
            dgSalesItems.Size = new Size(884, 173);
            dgSalesItems.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgSalesServices);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(890, 179);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Services";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgSalesServices
            // 
            dgSalesServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSalesServices.Dock = DockStyle.Fill;
            dgSalesServices.Location = new Point(3, 3);
            dgSalesServices.Name = "dgSalesServices";
            dgSalesServices.RowTemplate.Height = 25;
            dgSalesServices.Size = new Size(884, 173);
            dgSalesServices.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(559, 15);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 6;
            label1.Text = "Total Sales";
            // 
            // txtTotalSales
            // 
            txtTotalSales.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalSales.Location = new Point(626, 12);
            txtTotalSales.Name = "txtTotalSales";
            txtTotalSales.ReadOnly = true;
            txtTotalSales.Size = new Size(98, 23);
            txtTotalSales.TabIndex = 7;
            txtTotalSales.Text = "10,000,000.00";
            txtTotalSales.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPayments
            // 
            btnPayments.Location = new Point(916, 140);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(98, 23);
            btnPayments.TabIndex = 8;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // txtCollectibles
            // 
            txtCollectibles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCollectibles.Location = new Point(812, 12);
            txtCollectibles.Name = "txtCollectibles";
            txtCollectibles.ReadOnly = true;
            txtCollectibles.Size = new Size(98, 23);
            txtCollectibles.TabIndex = 10;
            txtCollectibles.Text = "10,000,000.00";
            txtCollectibles.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(738, 15);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "Collectibles";
            // 
            // FrmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 583);
            Controls.Add(txtCollectibles);
            Controls.Add(label2);
            Controls.Add(btnPayments);
            Controls.Add(txtTotalSales);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(dtpTransactionDate);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgSales);
            Name = "FrmSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales";
            Load += FrmSales_Load;
            ((System.ComponentModel.ISupportInitialize)dgSales).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSalesItems).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSalesServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgSales;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DateTimePicker dtpTransactionDate;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgSalesItems;
        private Label label1;
        private TextBox txtTotalSales;
        private Button btnPayments;
        private TextBox txtCollectibles;
        private Label label2;
        private TabPage tabPage2;
        private DataGridView dgSalesServices;
    }
}