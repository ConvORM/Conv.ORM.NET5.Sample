namespace Conv.ORM.NET5.Test.Views
{
    partial class VUserSearch
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTextToSearch = new System.Windows.Forms.TextBox();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.dgvRegisters = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cmbTypeFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterValue = new System.Windows.Forms.Label();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.lblUserIdFilter = new System.Windows.Forms.Label();
            this.pnlDivisory1 = new System.Windows.Forms.Panel();
            this.rbOnlyNotActives = new System.Windows.Forms.RadioButton();
            this.rbOnlyActives = new System.Windows.Forms.RadioButton();
            this.lblActiveFilter = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisters)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "User";
            // 
            // txtTextToSearch
            // 
            this.txtTextToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextToSearch.Location = new System.Drawing.Point(82, 12);
            this.txtTextToSearch.Name = "txtTextToSearch";
            this.txtTextToSearch.Size = new System.Drawing.Size(494, 35);
            this.txtTextToSearch.TabIndex = 1;
            // 
            // panelDivisor
            // 
            this.panelDivisor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDivisor.Location = new System.Drawing.Point(16, 53);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(765, 2);
            this.panelDivisor.TabIndex = 7;
            // 
            // dgvRegisters
            // 
            this.dgvRegisters.AllowUserToAddRows = false;
            this.dgvRegisters.AllowUserToDeleteRows = false;
            this.dgvRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisters.Location = new System.Drawing.Point(16, 122);
            this.dgvRegisters.MultiSelect = false;
            this.dgvRegisters.Name = "dgvRegisters";
            this.dgvRegisters.ReadOnly = true;
            this.dgvRegisters.RowHeadersVisible = false;
            this.dgvRegisters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisters.Size = new System.Drawing.Size(765, 316);
            this.dgvRegisters.TabIndex = 8;
            this.dgvRegisters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegisters_CellContentClick);
            this.dgvRegisters.SelectionChanged += new System.EventHandler(this.dgvRegisters_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::Conv.ORM.NET5.Test.Properties.Resources.deleteRegister;
            this.btnDelete.Location = new System.Drawing.Point(746, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = global::Conv.ORM.NET5.Test.Properties.Resources.editRegister;
            this.btnEdit.Location = new System.Drawing.Point(705, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(35, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Conv.ORM.NET5.Test.Properties.Resources.newRegister;
            this.btnNew.Location = new System.Drawing.Point(664, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(35, 35);
            this.btnNew.TabIndex = 4;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::Conv.ORM.NET5.Test.Properties.Resources.filterActive;
            this.btnFilter.Location = new System.Drawing.Point(623, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(35, 35);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Conv.ORM.NET5.Test.Properties.Resources.searchRegisters;
            this.btnSearch.Location = new System.Drawing.Point(582, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlFilters
            // 
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.btnClearFilters);
            this.pnlFilters.Controls.Add(this.txtFilterValue);
            this.pnlFilters.Controls.Add(this.cmbTypeFilter);
            this.pnlFilters.Controls.Add(this.lblFilterValue);
            this.pnlFilters.Controls.Add(this.lblFilterType);
            this.pnlFilters.Controls.Add(this.lblUserIdFilter);
            this.pnlFilters.Controls.Add(this.pnlDivisory1);
            this.pnlFilters.Controls.Add(this.rbOnlyNotActives);
            this.pnlFilters.Controls.Add(this.rbOnlyActives);
            this.pnlFilters.Controls.Add(this.lblActiveFilter);
            this.pnlFilters.Controls.Add(this.rbAll);
            this.pnlFilters.Location = new System.Drawing.Point(17, 61);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(764, 55);
            this.pnlFilters.TabIndex = 9;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(365, 23);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(47, 23);
            this.btnClearFilters.TabIndex = 10;
            this.btnClearFilters.Text = "Clear";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(221, 25);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(138, 20);
            this.txtFilterValue.TabIndex = 9;
            // 
            // cmbTypeFilter
            // 
            this.cmbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeFilter.FormattingEnabled = true;
            this.cmbTypeFilter.Items.AddRange(new object[] {
            ">",
            ">=",
            "=",
            "!=",
            "<",
            "<="});
            this.cmbTypeFilter.Location = new System.Drawing.Point(90, 25);
            this.cmbTypeFilter.Name = "cmbTypeFilter";
            this.cmbTypeFilter.Size = new System.Drawing.Size(85, 21);
            this.cmbTypeFilter.TabIndex = 8;
            // 
            // lblFilterValue
            // 
            this.lblFilterValue.AutoSize = true;
            this.lblFilterValue.Location = new System.Drawing.Point(181, 28);
            this.lblFilterValue.Name = "lblFilterValue";
            this.lblFilterValue.Size = new System.Drawing.Size(34, 13);
            this.lblFilterValue.TabIndex = 7;
            this.lblFilterValue.Text = "Value";
            // 
            // lblFilterType
            // 
            this.lblFilterType.AutoSize = true;
            this.lblFilterType.Location = new System.Drawing.Point(53, 28);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(31, 13);
            this.lblFilterType.TabIndex = 6;
            this.lblFilterType.Text = "Type";
            // 
            // lblUserIdFilter
            // 
            this.lblUserIdFilter.AutoSize = true;
            this.lblUserIdFilter.Location = new System.Drawing.Point(3, 28);
            this.lblUserIdFilter.Name = "lblUserIdFilter";
            this.lblUserIdFilter.Size = new System.Drawing.Size(38, 13);
            this.lblUserIdFilter.TabIndex = 5;
            this.lblUserIdFilter.Text = "UserId";
            // 
            // pnlDivisory1
            // 
            this.pnlDivisory1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlDivisory1.Location = new System.Drawing.Point(47, 5);
            this.pnlDivisory1.Name = "pnlDivisory1";
            this.pnlDivisory1.Size = new System.Drawing.Size(2, 41);
            this.pnlDivisory1.TabIndex = 4;
            // 
            // rbOnlyNotActives
            // 
            this.rbOnlyNotActives.AutoSize = true;
            this.rbOnlyNotActives.Location = new System.Drawing.Point(184, 3);
            this.rbOnlyNotActives.Name = "rbOnlyNotActives";
            this.rbOnlyNotActives.Size = new System.Drawing.Size(101, 17);
            this.rbOnlyNotActives.TabIndex = 3;
            this.rbOnlyNotActives.Text = "Only not actives";
            this.rbOnlyNotActives.UseVisualStyleBackColor = true;
            // 
            // rbOnlyActives
            // 
            this.rbOnlyActives.AutoSize = true;
            this.rbOnlyActives.Location = new System.Drawing.Point(95, 3);
            this.rbOnlyActives.Name = "rbOnlyActives";
            this.rbOnlyActives.Size = new System.Drawing.Size(83, 17);
            this.rbOnlyActives.TabIndex = 2;
            this.rbOnlyActives.Text = "Only actives";
            this.rbOnlyActives.UseVisualStyleBackColor = true;
            // 
            // lblActiveFilter
            // 
            this.lblActiveFilter.AutoSize = true;
            this.lblActiveFilter.Location = new System.Drawing.Point(3, 5);
            this.lblActiveFilter.Name = "lblActiveFilter";
            this.lblActiveFilter.Size = new System.Drawing.Size(37, 13);
            this.lblActiveFilter.TabIndex = 1;
            this.lblActiveFilter.Text = "Active";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(53, 3);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // VUserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.dgvRegisters);
            this.Controls.Add(this.panelDivisor);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTextToSearch);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VUserSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Search";
            this.Shown += new System.EventHandler(this.VUserSearch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisters)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTextToSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.DataGridView dgvRegisters;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlDivisory1;
        private System.Windows.Forms.RadioButton rbOnlyNotActives;
        private System.Windows.Forms.RadioButton rbOnlyActives;
        private System.Windows.Forms.Label lblActiveFilter;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cmbTypeFilter;
        private System.Windows.Forms.Label lblFilterValue;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.Label lblUserIdFilter;
        private System.Windows.Forms.Button btnClearFilters;
    }
}