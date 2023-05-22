namespace ZenBiz.AppModules.Forms.Purchases
{
    partial class FrmPurchases
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
            dtpPurchasedDateFrom = new DateTimePicker();
            label1 = new Label();
            dtpPurchasedDateTo = new DateTimePicker();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgPurchasesItems = new DataGridView();
            dgPurchases = new DataGridView();
            btnPayments = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnLoad = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPurchasesItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPurchases).BeginInit();
            SuspendLayout();
            // 
            // dtpPurchasedDateFrom
            // 
            dtpPurchasedDateFrom.Location = new Point(53, 14);
            dtpPurchasedDateFrom.Name = "dtpPurchasedDateFrom";
            dtpPurchasedDateFrom.Size = new Size(210, 23);
            dtpPurchasedDateFrom.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "From";
            // 
            // dtpPurchasedDateTo
            // 
            dtpPurchasedDateTo.Location = new Point(314, 14);
            dtpPurchasedDateTo.Name = "dtpPurchasedDateTo";
            dtpPurchasedDateTo.Size = new Size(209, 23);
            dtpPurchasedDateTo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 18);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 6;
            label2.Text = "To";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 366);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(898, 207);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgPurchasesItems);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(890, 179);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgPurchasesItems
            // 
            dgPurchasesItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPurchasesItems.Dock = DockStyle.Fill;
            dgPurchasesItems.Location = new Point(3, 3);
            dgPurchasesItems.Name = "dgPurchasesItems";
            dgPurchasesItems.RowTemplate.Height = 25;
            dgPurchasesItems.Size = new Size(884, 173);
            dgPurchasesItems.TabIndex = 1;
            // 
            // dgPurchases
            // 
            dgPurchases.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPurchases.Location = new Point(12, 43);
            dgPurchases.Name = "dgPurchases";
            dgPurchases.RowTemplate.Height = 25;
            dgPurchases.Size = new Size(898, 317);
            dgPurchases.TabIndex = 7;
            dgPurchases.SelectionChanged += dgPurchases_SelectionChanged;
            // 
            // btnPayments
            // 
            btnPayments.Location = new Point(916, 142);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(98, 23);
            btnPayments.TabIndex = 12;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(916, 101);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(916, 72);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 23);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(916, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(529, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // FrmPurchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 583);
            Controls.Add(btnLoad);
            Controls.Add(btnPayments);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(tabControl1);
            Controls.Add(dgPurchases);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpPurchasedDateTo);
            Controls.Add(dtpPurchasedDateFrom);
            Name = "FrmPurchases";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchases";
            Load += FrmPurchases_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPurchasesItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPurchases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpPurchasedDateFrom;
        private Label label1;
        private DateTimePicker dtpPurchasedDateTo;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgPurchasesItems;
        private DataGridView dgPurchases;
        private Button btnPayments;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnLoad;
    }
}