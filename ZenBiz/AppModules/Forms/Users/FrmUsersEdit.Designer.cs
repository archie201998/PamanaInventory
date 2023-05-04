namespace ZenBiz.AppModules.Forms.Users
{
    partial class FrmUsersEdit
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
            ucUsers1 = new UcUsers();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ucUsers1
            // 
            ucUsers1.Location = new Point(12, 12);
            ucUsers1.Name = "ucUsers1";
            ucUsers1.Size = new Size(442, 199);
            ucUsers1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 225);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(460, 30);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(382, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(301, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmUsersEdit
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            CancelButton = btnCancel;
            ClientSize = new Size(460, 255);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ucUsers1);
            Name = "FrmUsersEdit";
            Text = "FrmUsersEdit";
            Load += FrmUsersEdit_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UcUsers ucUsers1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnSave;
    }
}