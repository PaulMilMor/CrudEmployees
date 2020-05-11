namespace CrudEmployees
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showFields = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.editRecord = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.cancelSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openPayment = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.employeesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hideEmpPanel = new System.Windows.Forms.Button();
            this.hdEPicker = new System.Windows.Forms.DateTimePicker();
            this.addEmployee = new System.Windows.Forms.Button();
            this.genECombo = new System.Windows.Forms.ComboBox();
            this.bdEPicker = new System.Windows.Forms.DateTimePicker();
            this.fnELabel = new System.Windows.Forms.Label();
            this.hdELabel = new System.Windows.Forms.Label();
            this.fnEText = new System.Windows.Forms.TextBox();
            this.lnELabel = new System.Windows.Forms.Label();
            this.lnEText = new System.Windows.Forms.TextBox();
            this.bdELabel = new System.Windows.Forms.Label();
            this.genELabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.employeesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesTable
            // 
            this.employeesTable.AllowUserToAddRows = false;
            this.employeesTable.AllowUserToDeleteRows = false;
            this.employeesTable.AllowUserToResizeColumns = false;
            this.employeesTable.AllowUserToResizeRows = false;
            this.employeesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeesTable.Location = new System.Drawing.Point(0, 289);
            this.employeesTable.MultiSelect = false;
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.ReadOnly = true;
            this.employeesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesTable.Size = new System.Drawing.Size(1350, 440);
            this.employeesTable.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7006F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.Controls.Add(this.showFields, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.search, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchBar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.editRecord, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteRecord, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelSearch, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.openPayment, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label19, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 100);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // showFields
            // 
            this.showFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(255)))), ((int)(((byte)(103)))));
            this.showFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showFields.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFields.Image = global::CrudEmployees.Properties.Resources.plus;
            this.showFields.Location = new System.Drawing.Point(3, 3);
            this.showFields.Name = "showFields";
            this.showFields.Size = new System.Drawing.Size(74, 74);
            this.showFields.TabIndex = 6;
            this.showFields.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(783, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(77, 74);
            this.search.TabIndex = 12;
            this.search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.search.UseVisualStyleBackColor = false;
            // 
            // searchBar
            // 
            this.searchBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.Color.DarkGray;
            this.searchBar.Location = new System.Drawing.Point(164, 51);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(613, 26);
            this.searchBar.TabIndex = 16;
            this.searchBar.Text = "Search by employee number";
            // 
            // editRecord
            // 
            this.editRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.editRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRecord.Image = global::CrudEmployees.Properties.Resources.configuration;
            this.editRecord.Location = new System.Drawing.Point(83, 3);
            this.editRecord.Name = "editRecord";
            this.editRecord.Size = new System.Drawing.Size(75, 74);
            this.editRecord.TabIndex = 5;
            this.editRecord.UseVisualStyleBackColor = false;
            // 
            // deleteRecord
            // 
            this.deleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.deleteRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Image = global::CrudEmployees.Properties.Resources.rubbish;
            this.deleteRecord.Location = new System.Drawing.Point(1258, 3);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(89, 74);
            this.deleteRecord.TabIndex = 6;
            this.deleteRecord.UseVisualStyleBackColor = false;
            // 
            // cancelSearch
            // 
            this.cancelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cancelSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearch.Image = global::CrudEmployees.Properties.Resources.magnifying_lens_with_handle;
            this.cancelSearch.Location = new System.Drawing.Point(866, 3);
            this.cancelSearch.Name = "cancelSearch";
            this.cancelSearch.Size = new System.Drawing.Size(78, 74);
            this.cancelSearch.TabIndex = 17;
            this.cancelSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Edit Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bonus and Deducts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(866, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Clear Search";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1258, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Discharge Employee";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openPayment
            // 
            this.openPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.openPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openPayment.Font = new System.Drawing.Font("Source Serif Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPayment.ForeColor = System.Drawing.Color.White;
            this.openPayment.Location = new System.Drawing.Point(950, 3);
            this.openPayment.Name = "openPayment";
            this.openPayment.Size = new System.Drawing.Size(76, 74);
            this.openPayment.TabIndex = 23;
            this.openPayment.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(950, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "CRUD";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeesPanel
            // 
            this.employeesPanel.ColumnCount = 6;
            this.employeesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.39175F));
            this.employeesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.60825F));
            this.employeesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.employeesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.employeesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.employeesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.employeesPanel.Controls.Add(this.hideEmpPanel, 5, 1);
            this.employeesPanel.Controls.Add(this.hdEPicker, 4, 1);
            this.employeesPanel.Controls.Add(this.addEmployee, 5, 0);
            this.employeesPanel.Controls.Add(this.genECombo, 2, 1);
            this.employeesPanel.Controls.Add(this.bdEPicker, 3, 1);
            this.employeesPanel.Controls.Add(this.fnELabel, 0, 0);
            this.employeesPanel.Controls.Add(this.hdELabel, 4, 0);
            this.employeesPanel.Controls.Add(this.fnEText, 0, 1);
            this.employeesPanel.Controls.Add(this.lnELabel, 1, 0);
            this.employeesPanel.Controls.Add(this.lnEText, 1, 1);
            this.employeesPanel.Controls.Add(this.bdELabel, 3, 0);
            this.employeesPanel.Controls.Add(this.genELabel, 2, 0);
            this.employeesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesPanel.Location = new System.Drawing.Point(0, 100);
            this.employeesPanel.Name = "employeesPanel";
            this.employeesPanel.RowCount = 2;
            this.employeesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.employeesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.employeesPanel.Size = new System.Drawing.Size(1350, 110);
            this.employeesPanel.TabIndex = 25;
            this.employeesPanel.Visible = false;
            // 
            // hideEmpPanel
            // 
            this.hideEmpPanel.BackColor = System.Drawing.Color.Transparent;
            this.hideEmpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hideEmpPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideEmpPanel.Image = global::CrudEmployees.Properties.Resources.toxic;
            this.hideEmpPanel.Location = new System.Drawing.Point(1225, 58);
            this.hideEmpPanel.Name = "hideEmpPanel";
            this.hideEmpPanel.Size = new System.Drawing.Size(122, 49);
            this.hideEmpPanel.TabIndex = 6;
            this.hideEmpPanel.Text = "Cancel";
            this.hideEmpPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hideEmpPanel.UseVisualStyleBackColor = false;
            // 
            // hdEPicker
            // 
            this.hdEPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hdEPicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdEPicker.Location = new System.Drawing.Point(955, 58);
            this.hdEPicker.Name = "hdEPicker";
            this.hdEPicker.Size = new System.Drawing.Size(264, 26);
            this.hdEPicker.TabIndex = 10;
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.Color.Transparent;
            this.addEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.Image = global::CrudEmployees.Properties.Resources.plusmini;
            this.addEmployee.Location = new System.Drawing.Point(1225, 3);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(122, 49);
            this.addEmployee.TabIndex = 5;
            this.addEmployee.Text = "Add";
            this.addEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addEmployee.UseVisualStyleBackColor = false;
            // 
            // genECombo
            // 
            this.genECombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genECombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genECombo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genECombo.FormattingEnabled = true;
            this.genECombo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genECombo.Location = new System.Drawing.Point(542, 58);
            this.genECombo.Name = "genECombo";
            this.genECombo.Size = new System.Drawing.Size(143, 28);
            this.genECombo.TabIndex = 11;
            // 
            // bdEPicker
            // 
            this.bdEPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bdEPicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdEPicker.Location = new System.Drawing.Point(691, 58);
            this.bdEPicker.Name = "bdEPicker";
            this.bdEPicker.Size = new System.Drawing.Size(258, 26);
            this.bdEPicker.TabIndex = 9;
            // 
            // fnELabel
            // 
            this.fnELabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.fnELabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fnELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnELabel.ForeColor = System.Drawing.Color.White;
            this.fnELabel.Location = new System.Drawing.Point(3, 15);
            this.fnELabel.Name = "fnELabel";
            this.fnELabel.Size = new System.Drawing.Size(244, 40);
            this.fnELabel.TabIndex = 0;
            this.fnELabel.Text = "First Name";
            this.fnELabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // hdELabel
            // 
            this.hdELabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.hdELabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hdELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdELabel.ForeColor = System.Drawing.Color.White;
            this.hdELabel.Location = new System.Drawing.Point(955, 15);
            this.hdELabel.Name = "hdELabel";
            this.hdELabel.Size = new System.Drawing.Size(264, 40);
            this.hdELabel.TabIndex = 4;
            this.hdELabel.Text = "Hire Date";
            this.hdELabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fnEText
            // 
            this.fnEText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fnEText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnEText.Location = new System.Drawing.Point(3, 58);
            this.fnEText.Name = "fnEText";
            this.fnEText.Size = new System.Drawing.Size(244, 26);
            this.fnEText.TabIndex = 7;
            // 
            // lnELabel
            // 
            this.lnELabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.lnELabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnELabel.ForeColor = System.Drawing.Color.White;
            this.lnELabel.Location = new System.Drawing.Point(253, 15);
            this.lnELabel.Name = "lnELabel";
            this.lnELabel.Size = new System.Drawing.Size(283, 40);
            this.lnELabel.TabIndex = 1;
            this.lnELabel.Text = "Last Name";
            this.lnELabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lnEText
            // 
            this.lnEText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnEText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnEText.Location = new System.Drawing.Point(253, 58);
            this.lnEText.Name = "lnEText";
            this.lnEText.Size = new System.Drawing.Size(283, 26);
            this.lnEText.TabIndex = 8;
            // 
            // bdELabel
            // 
            this.bdELabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.bdELabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdELabel.ForeColor = System.Drawing.Color.White;
            this.bdELabel.Location = new System.Drawing.Point(691, 15);
            this.bdELabel.Name = "bdELabel";
            this.bdELabel.Size = new System.Drawing.Size(258, 40);
            this.bdELabel.TabIndex = 3;
            this.bdELabel.Text = "Birth Date";
            this.bdELabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // genELabel
            // 
            this.genELabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.genELabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.genELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genELabel.ForeColor = System.Drawing.Color.White;
            this.genELabel.Location = new System.Drawing.Point(542, 15);
            this.genELabel.Name = "genELabel";
            this.genELabel.Size = new System.Drawing.Size(143, 40);
            this.genELabel.TabIndex = 2;
            this.genELabel.Text = "Gender";
            this.genELabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 469F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 663F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 250);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1350, 33);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.employeesPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.employeesTable);
            this.Name = "Payment";
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payment_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.employeesPanel.ResumeLayout(false);
            this.employeesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView employeesTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button showFields;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button editRecord;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button cancelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button openPayment;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel employeesPanel;
        private System.Windows.Forms.Button hideEmpPanel;
        private System.Windows.Forms.DateTimePicker hdEPicker;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.ComboBox genECombo;
        private System.Windows.Forms.DateTimePicker bdEPicker;
        private System.Windows.Forms.Label fnELabel;
        private System.Windows.Forms.Label hdELabel;
        private System.Windows.Forms.TextBox fnEText;
        private System.Windows.Forms.Label lnELabel;
        private System.Windows.Forms.TextBox lnEText;
        private System.Windows.Forms.Label bdELabel;
        private System.Windows.Forms.Label genELabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}