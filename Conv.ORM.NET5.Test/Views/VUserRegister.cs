using Conv.ORM.NET5.Test.Views.Entities;
using System.Windows.Forms;

namespace Conv.ORM.NET5.Test.Views
{
    public partial class VUserRegister : Form
    {
        public UserEntity User { get; set; }

        public VUserRegister()
        {
            InitializeComponent();
        }

        private void LoadValuesFromEntity()
        {
            txtId.Text = User.UserId.ToString();
            ckbActive.Checked = User.Active;
            txtName.Text = User.Name;
            txtLogin.Text = User.Login;
            txtPassword.Text = User.Password;

            if (!ckbActive.Enabled)
                ckbActive.Enabled = true;
        }

        private void VUserRegister_Shown(object sender, System.EventArgs e)
        {
            if (User == null)
            {
                ckbActive.Checked = true;
                ckbActive.Enabled = false;
                txtId.Text = "0";
            }
            else
                LoadValuesFromEntity();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if(User == null)
                User = new UserEntity();

            User.UserId = int.Parse(txtId.Text);
            User.Name = txtName.Text;
            User.Login = txtLogin.Text;
            User.Password = txtPassword.Text;
            User.Active = ckbActive.Checked;

            User = User.Save();

            if (User != null)
            {
                MessageBox.Show("Success!", "Yeah", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadValuesFromEntity();
            }
            else
                MessageBox.Show("Error!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
