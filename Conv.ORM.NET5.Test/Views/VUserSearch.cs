using Conv.ORM.Connection.Classes.QueryBuilders;
using Conv.ORM.Connection.Enums;
using Conv.ORM.Connection.Helpers;
using Conv.ORM.NET5.Test.Views.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Conv.ORM.NET5.Test.Views
{
    public partial class VUserSearch : Form
    {
        public VUserSearch()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var userRegister = new VUserRegister();
            userRegister.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var userEntity = new UserEntity();

            var queryConditions = new QueryConditionsBuilder();

            if (txtTextToSearch.Text != "")
            {
                queryConditions.AddQueryCondition("name", EConditionTypes.Like, new object[] {"%" + txtTextToSearch.Text + "%"});
            }

            if (!rbAll.Checked)
                queryConditions.AddQueryCondition("active", EConditionTypes.Equals, new object[] { rbOnlyActives.Checked ? 1 : 0 });

            if ((cmbTypeFilter.SelectedIndex != -1) && (txtFilterValue.Text != ""))
            {
                EConditionTypes conditionType;

                if ((string)cmbTypeFilter.SelectedItem == ">")
                    conditionType = EConditionTypes.MoreThan;
                else if ((string)cmbTypeFilter.SelectedItem == ">=")
                    conditionType = EConditionTypes.MoreThanOrEquals;
                else if ((string)cmbTypeFilter.SelectedItem == "=")
                    conditionType = EConditionTypes.Equals;
                else if ((string)cmbTypeFilter.SelectedItem == "!=")
                    conditionType = EConditionTypes.Not;
                else if ((string)cmbTypeFilter.SelectedItem == "<")
                    conditionType = EConditionTypes.LessThan;
                else if ((string)cmbTypeFilter.SelectedItem == ">=")
                    conditionType = EConditionTypes.LessThanOrEquals;
                else
                    conditionType = EConditionTypes.Equals;

                queryConditions.AddQueryCondition("userId", conditionType, new object[] { txtFilterValue.Text });
            }
        
            dgvRegisters.DataSource = ConvORMHelper.ConvertListToDataTable(userEntity.Find(queryConditions));
            dgvRegisters.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvRegisters_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = btnDelete.Enabled = dgvRegisters.SelectedRows.Count > 0;
        }

        private void dgvRegisters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRegisters.SelectedRows.Count != 0)
            {
                var userEntity = new UserEntity(); 

                var userRegister = new VUserRegister();
                userRegister.User = userEntity.Find((int)dgvRegisters.SelectedRows[0].Cells[0].Value);
                userRegister.ShowDialog();
                btnSearch.PerformClick();
            }                

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (pnlFilters.Visible)
            {
                pnlFilters.Visible = false;
                dgvRegisters.Location = new Point(16,61);
                dgvRegisters.Height = 377;
            }
            else
            {
                pnlFilters.Visible = true;
                dgvRegisters.Location = new Point(16,122);
                dgvRegisters.Height = 316;

            }
        }

        private void VUserSearch_Shown(object sender, EventArgs e)
        {
            pnlFilters.Visible = false;
            dgvRegisters.Location = new Point(16, 61);
            dgvRegisters.Height = 377;
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            cmbTypeFilter.SelectedIndex = -1;
        }
    }
}
