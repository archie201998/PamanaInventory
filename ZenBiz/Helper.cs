using Org.BouncyCastle.Math.EC.Multiplier;
using System.Text;
using ZenBiz.AppModules;

namespace ZenBiz
{
    internal class Helper
    {
        internal static string LoggedInUserFullName = string.Empty;
        internal static string UserType = string.Empty;
        internal static sbyte UserId = 1;

        public static void LoadFormIcon(Form form)
        {
            using (var ms = new MemoryStream(PamanaWaterInventory.Properties.Resources.pamana_icon))
            {
                form.Icon = new Icon(ms);
            }
        }

        public static void DatagridDefaultStyle(DataGridView dgv, bool Fill = false, bool IsReadOnly = true)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromKnownColor(KnownColor.Control);
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.White);
            dgv.RowTemplate.Height = 20;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.White);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption);
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.White);
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.RowHeadersWidth = 25;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Outset;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.ReadOnly = IsReadOnly;
            if (Fill == true) dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void FormDialogDefaults(Form form, bool showIcon = true, bool showInTaskbar = false)
        {
            form.ShowInTaskbar = showInTaskbar;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            LoadFormIcon(form);
            form.ShowIcon = showIcon;
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void FormFixedToolWindowDefaults(Form form)
        {
            form.ShowInTaskbar = false;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            LoadFormIcon(form);
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        #region MessageBoxes
        public static void MessageBoxSuccess(string message)
        {
            _ = MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MessageBoxError(string message)
        {
            _ = MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MessageBoxInformation(string message)
        {
            _ = MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MessageBoxWarning(string message)
        {
            _ = MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool MessageBoxConfirmDelete(int rowCount)
        {
            string message = string.Empty;

            if (rowCount == 1)
                message = "Are you sure you want to delete a record?";
            else if (rowCount > 1)
                message = $"Are you sure you want to delete {rowCount} records?";

            if (MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                return true;

            return false;
        }
        #endregion

        #region EnableDisableButtons
        public static void EnableDisableButtons(DataGridView dgv, Button btnEdit, Button btnDelete)
        {
            int SelectedRows = dgv.SelectedRows.Count;
            if (SelectedRows == 1)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnDelete.Text = "Delete (" + SelectedRows + ")";

            }
            else if (SelectedRows > 1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnDelete.Text = "Delete (" + SelectedRows + ")";
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnDelete.Text = "Delete";
            }
        }


        public static void EnableDisableToolStripButtons_Repair_User_History(DataGridView dgv, ToolStripButton tsBtnEdit, ToolStripButton tsBtnDelete)
        {
            int SelectedRows = dgv.SelectedRows.Count;
            if (SelectedRows == 1)
            {
                tsBtnEdit.Enabled = true;
                tsBtnDelete.Enabled = true;

            }
            else if (SelectedRows > 1)
            {
                tsBtnEdit.Enabled = false;
                tsBtnDelete.Enabled = true;
            }
            else
            {
                tsBtnEdit.Enabled = false;
                tsBtnDelete.Enabled = false;
            }

        }
        public static void EnableDisableToolStripButtons(DataGridView dgv, ToolStripButton tsBtnEdit, ToolStripButton tsBtnDelete)
        {
            int SelectedRows = dgv.SelectedRows.Count;
            if (SelectedRows == 1)
            {
                tsBtnEdit.Enabled = true;
                tsBtnDelete.Enabled = true;
                tsBtnDelete.Text = "Delete (" + SelectedRows + ")";

            }
            else if (SelectedRows > 1)
            {
                tsBtnEdit.Enabled = false;
                tsBtnDelete.Enabled = true;
                tsBtnDelete.Text = "Delete (" + SelectedRows + ")";
            }
            else
            {
                tsBtnEdit.Enabled = false;
                tsBtnDelete.Enabled = false;
                tsBtnDelete.Text = "Delete";
            }
        }

        #endregion

        private static string GetFirstLetter(string word)
        {
            return word.Substring(0, 1);
        }

        #region ErrorProviders on Controls

        public static string ErrorMessageForEmpty(string fieldName)
        {
            if (GetFirstLetter(fieldName) == "a" || GetFirstLetter(fieldName) == "e" || GetFirstLetter(fieldName) == "i" || GetFirstLetter(fieldName) == "o" || GetFirstLetter(fieldName) == "u")
                return $"Please enter an {fieldName}";
            else
                return $"Please enter a {fieldName}";
        }

        public static bool ShowErrorTextBoxEmpty(ErrorProvider ep, TextBox txtBox, string fieldName = "Field")
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text.Trim()))
            {
                ep.SetError(txtBox, $"{ErrorMessageForEmpty(fieldName)}");
                return true;

            }

            return false;
        }

        public static bool ShowErrorRichTextBoxEmpty(ErrorProvider ep, RichTextBox richTxtBox, string fieldName = "Field")
        {
            if (string.IsNullOrWhiteSpace(richTxtBox.Text.Trim()))
            {
                ep.SetError(richTxtBox, $"{ErrorMessageForEmpty(fieldName)}");
                return true;
            }

            return false;
        }

        public static bool ShowErrorComboBoxEmpty(ErrorProvider ep, ComboBox cmbBox, string fieldName = "Field")
        {
            if (string.IsNullOrWhiteSpace(cmbBox.Text))
            {
                ep.SetError(cmbBox, $"{ErrorMessageForEmpty(fieldName)}");
                return true;
            }

            return false;
        }

        public static bool ShowErrorNumericUpDownEmpty(ErrorProvider ep, NumericUpDown numUpDown, string fieldName = "Field")
        {
            if (numUpDown.Value == 0 || string.IsNullOrWhiteSpace(numUpDown.Text))
            {
                ep.SetError(numUpDown, $"{ErrorMessageForEmpty(fieldName)}");
                return true;
            }

            return false;
        }

        public static bool ShowErrorCheckedListBox(ErrorProvider ep, CheckedListBox chklstBox, string fieldName = "Field")
        {
            if (chklstBox.CheckedIndices.Count == 0)
            {
                ep.SetError(chklstBox, $"{fieldName} is required");
                return true;
            }

            return false;
        }

        public static bool ShowErrorDatagridView(ErrorProvider ep, DataGridView dgView, string fieldName = "Field")
        {
            if (dgView.Rows.Count == 0)
            {
                ep.SetError(dgView, $"{fieldName} is required");
                return true;
            }

            return false;
        }

        public static bool ShowMaskedTextboxError(ErrorProvider ep, MaskedTextBox maskedTextBox, string fieldName)
        {
            if (!maskedTextBox.MaskCompleted)
            {
                ep.SetError(maskedTextBox, $"{fieldName} is required");
                return true;
            }
            return false;
        }

        public static void ClearErrorNumericUpDown(ErrorProvider ep, NumericUpDown numUpDown)
        {
            ep.SetError(numUpDown, string.Empty);
        }

        public static void ClearErrorComboBox(ErrorProvider ep, ComboBox cmbBox)
        {
            ep.SetError(cmbBox, string.Empty);
        }

        public static void ClearErrorTextBox(ErrorProvider ep, TextBox txtBox)
        {
            ep.SetError(txtBox, string.Empty);
        }

        public static void ClearErrorRichTextBox(ErrorProvider ep, RichTextBox richtxtBox)
        {
            ep.SetError(richtxtBox, string.Empty);
        }

        public static void ClearErrorCheckedListBox(ErrorProvider ep, CheckedListBox chklstBox)
        {
            ep.SetError(chklstBox, string.Empty);
        }

        public static void ClearErrorDatagridView(ErrorProvider ep, DataGridView dgView)
        {
            ep.SetError(dgView, string.Empty);
        }

        public static void ClearMaskedTextboxError(ErrorProvider ep, MaskedTextBox maskedTextBox)
        {
            ep.SetError(maskedTextBox, string.Empty);
        }
        #endregion

        public static string GenerateFormErrorMessage(Array errors)
        {
            StringBuilder sb = new($"Please correct the following errors and try again. {Environment.NewLine} {Environment.NewLine}");

            foreach (var error in errors)
            {
                if (!string.IsNullOrWhiteSpace(error.ToString()))
                    sb.AppendLine($"- {error}");
            }

            return sb.ToString();
        }

        public static void LoadCategories(ComboBox combobox)
        {
            combobox.DataSource = Factory.CategoriesController().Fetch();
            combobox.DisplayMember = "name";
            combobox.ValueMember = "id";
        }


        public static void LoadUnit(ComboBox combobox)
        {
            combobox.DataSource = Factory.UnitsOfMeasurementsController().Fetch();
            combobox.DisplayMember = "name";
            combobox.ValueMember = "id";
        }

        public static void LoadBranches(ComboBox combobox)
        {
            combobox.DataSource = Factory.BranchesController().Fetch();
            combobox.DisplayMember = "name";
            combobox.ValueMember = "id";
        }

        public static void LoadSuppliers(ComboBox combobox)
        {
            combobox.DataSource = Factory.SuppliersController().Fetch();
            combobox.DisplayMember = "name";
            combobox.ValueMember = "id";
        }
    }
}
