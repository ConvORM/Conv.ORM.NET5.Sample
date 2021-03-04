namespace Conv.ORM.NET5.Test.Views
{
    partial class VMain
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
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.ckbUseConnectionFile = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnectionDriver = new System.Windows.Forms.Label();
            this.cbConectionDrivers = new System.Windows.Forms.ComboBox();
            this.gbEntites = new System.Windows.Forms.GroupBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.ckbIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.gbConnection.SuspendLayout();
            this.gbParameters.SuspendLayout();
            this.gbEntites.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.ckbUseConnectionFile);
            this.gbConnection.Controls.Add(this.lblStatus);
            this.gbConnection.Controls.Add(this.lblStatusTitle);
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Controls.Add(this.gbParameters);
            this.gbConnection.Controls.Add(this.lblConnectionDriver);
            this.gbConnection.Controls.Add(this.cbConectionDrivers);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(170, 439);
            this.gbConnection.TabIndex = 1;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // ckbUseConnectionFile
            // 
            this.ckbUseConnectionFile.AutoSize = true;
            this.ckbUseConnectionFile.Location = new System.Drawing.Point(6, 19);
            this.ckbUseConnectionFile.Name = "ckbUseConnectionFile";
            this.ckbUseConnectionFile.Size = new System.Drawing.Size(117, 17);
            this.ckbUseConnectionFile.TabIndex = 6;
            this.ckbUseConnectionFile.Text = "Use connection file";
            this.ckbUseConnectionFile.UseVisualStyleBackColor = true;
            this.ckbUseConnectionFile.CheckedChanged += new System.EventHandler(this.ckbUseConnectionFile_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(15, 359);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(154, 29);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Wait...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.Location = new System.Drawing.Point(12, 336);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(158, 23);
            this.lblStatusTitle.TabIndex = 4;
            this.lblStatusTitle.Text = "Status";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 406);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(154, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.ckbIntegratedSecurity);
            this.gbParameters.Controls.Add(this.txtDatabase);
            this.gbParameters.Controls.Add(this.lblDatabase);
            this.gbParameters.Controls.Add(this.txtPassword);
            this.gbParameters.Controls.Add(this.lblPassword);
            this.gbParameters.Controls.Add(this.txtUser);
            this.gbParameters.Controls.Add(this.lblUser);
            this.gbParameters.Controls.Add(this.txtPort);
            this.gbParameters.Controls.Add(this.lblPort);
            this.gbParameters.Controls.Add(this.txtHost);
            this.gbParameters.Controls.Add(this.label1);
            this.gbParameters.Location = new System.Drawing.Point(9, 82);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(154, 251);
            this.gbParameters.TabIndex = 2;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parameters";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(11, 110);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(134, 20);
            this.txtDatabase.TabIndex = 9;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(8, 94);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Database";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(11, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 204);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(11, 181);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(134, 20);
            this.txtUser.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(8, 165);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(9, 71);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(134, 20);
            this.txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(6, 55);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(9, 32);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(134, 20);
            this.txtHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // lblConnectionDriver
            // 
            this.lblConnectionDriver.AutoSize = true;
            this.lblConnectionDriver.Location = new System.Drawing.Point(6, 39);
            this.lblConnectionDriver.Name = "lblConnectionDriver";
            this.lblConnectionDriver.Size = new System.Drawing.Size(35, 13);
            this.lblConnectionDriver.TabIndex = 1;
            this.lblConnectionDriver.Text = "Driver";
            // 
            // cbConectionDrivers
            // 
            this.cbConectionDrivers.FormattingEnabled = true;
            this.cbConectionDrivers.Items.AddRange(new object[] {
            "Firebird",
            "MySql",
            "PostgreeSql",
            "SQLServer"});
            this.cbConectionDrivers.Location = new System.Drawing.Point(6, 55);
            this.cbConectionDrivers.Name = "cbConectionDrivers";
            this.cbConectionDrivers.Size = new System.Drawing.Size(158, 21);
            this.cbConectionDrivers.TabIndex = 0;
            this.cbConectionDrivers.SelectedIndexChanged += new System.EventHandler(this.cbConectionDrivers_SelectedIndexChanged);
            // 
            // gbEntites
            // 
            this.gbEntites.Controls.Add(this.btnUser);
            this.gbEntites.Location = new System.Drawing.Point(188, 12);
            this.gbEntites.Name = "gbEntites";
            this.gbEntites.Size = new System.Drawing.Size(167, 409);
            this.gbEntites.TabIndex = 2;
            this.gbEntites.TabStop = false;
            this.gbEntites.Text = "Entities";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(6, 19);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(155, 23);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // ckbIntegratedSecurity
            // 
            this.ckbIntegratedSecurity.AutoSize = true;
            this.ckbIntegratedSecurity.Enabled = false;
            this.ckbIntegratedSecurity.Location = new System.Drawing.Point(11, 137);
            this.ckbIntegratedSecurity.Name = "ckbIntegratedSecurity";
            this.ckbIntegratedSecurity.Size = new System.Drawing.Size(115, 17);
            this.ckbIntegratedSecurity.TabIndex = 10;
            this.ckbIntegratedSecurity.Text = "Integrated Security";
            this.ckbIntegratedSecurity.UseVisualStyleBackColor = true;
            this.ckbIntegratedSecurity.CheckedChanged += new System.EventHandler(this.ckbIntegratedSecurity_CheckedChanged);
            // 
            // VMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 463);
            this.Controls.Add(this.gbEntites);
            this.Controls.Add(this.gbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test - Simple ORM";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            this.gbEntites.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnectionDriver;
        private System.Windows.Forms.ComboBox cbConectionDrivers;
        private System.Windows.Forms.CheckBox ckbUseConnectionFile;
        private System.Windows.Forms.GroupBox gbEntites;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.CheckBox ckbIntegratedSecurity;
    }
}

