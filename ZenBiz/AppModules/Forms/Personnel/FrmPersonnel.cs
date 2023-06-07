using MySql.Data.MySqlClient;
using System.Data;
using ZenBiz.AppModules.Models;

namespace ZenBiz.AppModules.Forms.Personnel
{
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
            Helper.LoadFormIcon(this);
            Helper.DatagridDefaultStyle(dgPersonnel, true);
        }

        private void LoadData()
        {
            dgPersonnel.DataSource = Factory.PersonnelController().Fetch();
            dgPersonnel.Columns["id"].Visible = false;
            dgPersonnel.Columns["name"].HeaderText = "Name";
            dgPersonnel.Columns["contact_info"].HeaderText = "Contact Info";
            dgPersonnel.Columns["address"].HeaderText = "Address";
            dgPersonnel.Columns["designation"].HeaderText = "Designation";
        }


        private void FrmPersonnel_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dgPersonnel.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgPersonnel.SelectedRows.Count == 0) return;

            try
            {
                List<PersonnelModel> personnelModelList = new();
                foreach (DataGridViewRow item in dgPersonnel.SelectedRows)
                    personnelModelList.Add(new PersonnelModel() { Id = Convert.ToInt32(item.Cells["id"].Value) });

                var messageBox = MessageBox.Show("Are you sure you want to delete this data?", "Deleting Personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBox != DialogResult.Yes) return;

                _ = Factory.PersonnelController().Delete(personnelModelList);
                LoadData();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                    Helper.MessageBoxError("Unable to delete the record/s because it is already been referenced to other records.");
                else
                    Helper.MessageBoxError(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using FrmPersonnelAdd form = new();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadData();

            form.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int personnelID = (int)dgPersonnel.SelectedCells[0].Value;
            using FrmPersonnelEdit form = new(personnelID);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                LoadData();

            form.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgPersonnel.DataSource).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", txtSearch.Text);
        }

        private void dgPersonnel_SelectionChanged(object sender, EventArgs e)
        {
            Helper.EnableDisableButtons(dgPersonnel, btnEdit, btnDelete);
        }
    }
}
