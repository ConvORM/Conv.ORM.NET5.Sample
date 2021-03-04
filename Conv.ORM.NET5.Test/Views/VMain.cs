using Conv.ORM.Connection;
using Conv.ORM.Connection.Enums;
using Conv.ORM.Connection.Parameters;
using Conv.ORM.Exceptions;
using System;
using System.Windows.Forms;

namespace Conv.ORM.NET5.Test.Views
{
    public partial class VMain : Form
    {
        private Connection.Connection _connection;

        public VMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            try 
            {

                if (ckbUseConnectionFile.Checked)
                    _connection = ConnectionFactory.GetConnection();
                else
                {
                    var connectionParameters = GetConnectionParameters();
                    if (connectionParameters != null)
                    {
                        _connection = ConnectionFactory.GetConnection(connectionParameters);
                    }
                    else
                    {
                        MessageBox.Show("Please select a Driver Connection Type or check to use the Connection File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                        
                }

                if (_connection.Connected)
                    lblStatus.Text = "Connected";
                else
                    lblStatus.Text = "Not Connected";
            }
            catch(ConnectionException ex)
            {
                MessageBox.Show("ErrorCode: " + ex.ErrorCode + Environment.NewLine + "Message: " + ex.Message + Environment.NewLine + "Possibles Solutions: " + Environment.NewLine + ex.PossiblesSolutions, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EConnectionDriverTypes GetDriverConnection()
        {
            switch (cbConectionDrivers.SelectedIndex)
            {
                case 0:
                    return EConnectionDriverTypes.ecdtFirebird;
                case 1:
                    return EConnectionDriverTypes.ecdtMySql;
                case 2:
                    return EConnectionDriverTypes.ecdtPostgreeSQL;
                case 3:
                    return EConnectionDriverTypes.ecdtSQLServer;
                default:
                    return 0;
            }
        }

        private void ckbUseConnectionFile_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUseConnectionFile.Checked)
            {
                cbConectionDrivers.Enabled = false;
                txtHost.Enabled = false;
                txtPort.Enabled = false;
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                txtDatabase.Enabled = false;
            }
            else
            {
                cbConectionDrivers.Enabled = true;
                txtHost.Enabled = true;
                txtPort.Enabled = true;
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
                txtDatabase.Enabled = true;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var form = new VUserSearch();
            form.ShowDialog();
        }

        private void cbConectionDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConectionDrivers.SelectedIndex == 0)
            {
                ckbIntegratedSecurity.Enabled = false;
                txtHost.Text = "";
                txtPort.Text = "";
            }
            if (cbConectionDrivers.SelectedIndex == 1)
            {
                ckbIntegratedSecurity.Enabled = false;
                txtHost.Text = "127.0.0.1";
                txtPort.Text = "3306";
            }
            if (cbConectionDrivers.SelectedIndex == 2)
            {
                ckbIntegratedSecurity.Enabled = false;
                txtHost.Text = "";
                txtPort.Text = "";
            }
            if (cbConectionDrivers.SelectedIndex == 3)
            {
                ckbIntegratedSecurity.Enabled = true;
                txtHost.Text = "127.0.0.1";
                txtPort.Text = "1433";
            }
                
        }

        private void ckbIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = !ckbIntegratedSecurity.Checked;
            txtPassword.Enabled = !ckbIntegratedSecurity.Checked;

        }

        private ConnectionParameters GetConnectionParameters()
        {
            var driverConnection = GetDriverConnection();

            switch (driverConnection)
            {
                case EConnectionDriverTypes.ecdtFirebird:
                    return null;
                case EConnectionDriverTypes.ecdtMySql:
                    return new ConnectionParameters("Default", driverConnection, txtHost.Text, txtPort.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
                case EConnectionDriverTypes.ecdtPostgreeSQL:
                    return null;
                case EConnectionDriverTypes.ecdtSQLServer:
                    return new ConnectionParameters("Default", driverConnection, txtHost.Text, txtPort.Text, txtDatabase.Text, ckbIntegratedSecurity.Checked , ckbIntegratedSecurity.Checked ? null : txtUser.Text, ckbIntegratedSecurity.Checked ? null : txtPassword.Text);
                case EConnectionDriverTypes.ecdtNone:
                    return null;
                default:
                    return null;
            }

        }


    }
}
