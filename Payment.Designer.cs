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
            this.paymentTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showFields = new System.Windows.Forms.Button();
            this.deptPCombo = new System.Windows.Forms.ComboBox();
            this.loadDepartment = new System.Windows.Forms.Button();
            this.departmentPLabel = new System.Windows.Forms.Label();
            this.editDetails = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.registerPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openCrud = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.paydetailsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sdPLabel = new System.Windows.Forms.Label();
            this.addPDetail = new System.Windows.Forms.Button();
            this.sdPPicker = new System.Windows.Forms.DateTimePicker();
            this.atPCombo = new System.Windows.Forms.ComboBox();
            this.enPLabel = new System.Windows.Forms.Label();
            this.enPText = new System.Windows.Forms.TextBox();
            this.atPLabel = new System.Windows.Forms.Label();
            this.baPText = new System.Windows.Forms.TextBox();
            this.baPLabel = new System.Windows.Forms.Label();
            this.bnPLabel = new System.Windows.Forms.Label();
            this.rnPLabel = new System.Windows.Forms.Label();
            this.rnPText = new System.Windows.Forms.TextBox();
            this.bnPText = new System.Windows.Forms.TextBox();
            this.ptPLabel = new System.Windows.Forms.Label();
            this.ptPCombo = new System.Windows.Forms.ComboBox();
            this.hidePPanel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.paydetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentTable
            // 
            this.paymentTable.AllowUserToAddRows = false;
            this.paymentTable.AllowUserToDeleteRows = false;
            this.paymentTable.AllowUserToResizeColumns = false;
            this.paymentTable.AllowUserToResizeRows = false;
            this.paymentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymentTable.Location = new System.Drawing.Point(0, 354);
            this.paymentTable.MultiSelect = false;
            this.paymentTable.Name = "paymentTable";
            this.paymentTable.ReadOnly = true;
            this.paymentTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.paymentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentTable.Size = new System.Drawing.Size(1350, 375);
            this.paymentTable.TabIndex = 23;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.showFields, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deptPCombo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.loadDepartment, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.departmentPLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.editDetails, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteRecord, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.registerPayment, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.openCrud, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label19, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 114);
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
            this.showFields.Size = new System.Drawing.Size(70, 75);
            this.showFields.TabIndex = 6;
            this.showFields.UseVisualStyleBackColor = false;
            this.showFields.Click += new System.EventHandler(this.ShowFields_Click);
            // 
            // deptPCombo
            // 
            this.deptPCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deptPCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptPCombo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptPCombo.FormattingEnabled = true;
            this.deptPCombo.Location = new System.Drawing.Point(155, 84);
            this.deptPCombo.Name = "deptPCombo";
            this.deptPCombo.Size = new System.Drawing.Size(613, 28);
            this.deptPCombo.TabIndex = 16;
            this.deptPCombo.SelectedIndexChanged += new System.EventHandler(this.DeptPCombo_SelectedIndexChanged);
            // 
            // loadDepartment
            // 
            this.loadDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.loadDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadDepartment.Enabled = false;
            this.loadDepartment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDepartment.Location = new System.Drawing.Point(774, 3);
            this.loadDepartment.Name = "loadDepartment";
            this.loadDepartment.Size = new System.Drawing.Size(77, 75);
            this.loadDepartment.TabIndex = 12;
            this.loadDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadDepartment.UseVisualStyleBackColor = false;
            this.loadDepartment.Click += new System.EventHandler(this.LoadEmployees_Click);
            // 
            // departmentPLabel
            // 
            this.departmentPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.departmentPLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.departmentPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentPLabel.ForeColor = System.Drawing.Color.White;
            this.departmentPLabel.Location = new System.Drawing.Point(155, 48);
            this.departmentPLabel.Name = "departmentPLabel";
            this.departmentPLabel.Size = new System.Drawing.Size(613, 33);
            this.departmentPLabel.TabIndex = 15;
            this.departmentPLabel.Text = "Department";
            this.departmentPLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // editDetails
            // 
            this.editDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.editDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDetails.Image = global::CrudEmployees.Properties.Resources.configuration;
            this.editDetails.Location = new System.Drawing.Point(79, 3);
            this.editDetails.Name = "editDetails";
            this.editDetails.Size = new System.Drawing.Size(70, 75);
            this.editDetails.TabIndex = 5;
            this.editDetails.UseVisualStyleBackColor = false;
            this.editDetails.Click += new System.EventHandler(this.EditDetails_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.deleteRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Image = global::CrudEmployees.Properties.Resources.rubbish;
            this.deleteRecord.Location = new System.Drawing.Point(1249, 3);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(98, 75);
            this.deleteRecord.TabIndex = 6;
            this.deleteRecord.UseVisualStyleBackColor = false;
            this.deleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // registerPayment
            // 
            this.registerPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(255)))), ((int)(((byte)(103)))));
            this.registerPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPayment.Image = global::CrudEmployees.Properties.Resources.magnifying_lens_with_handle;
            this.registerPayment.Location = new System.Drawing.Point(857, 3);
            this.registerPayment.Name = "registerPayment";
            this.registerPayment.Size = new System.Drawing.Size(78, 74);
            this.registerPayment.TabIndex = 17;
            this.registerPayment.UseVisualStyleBackColor = false;
            this.registerPayment.Click += new System.EventHandler(this.RegisterPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "Edit Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(774, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Load Department";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(857, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 33);
            this.label8.TabIndex = 21;
            this.label8.Text = "Register Payment";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1249, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 33);
            this.label14.TabIndex = 22;
            this.label14.Text = "Discharge Employee";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openCrud
            // 
            this.openCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.openCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openCrud.Font = new System.Drawing.Font("Source Serif Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCrud.ForeColor = System.Drawing.Color.White;
            this.openCrud.Location = new System.Drawing.Point(941, 3);
            this.openCrud.Name = "openCrud";
            this.openCrud.Size = new System.Drawing.Size(76, 75);
            this.openCrud.TabIndex = 23;
            this.openCrud.UseVisualStyleBackColor = false;
            this.openCrud.Click += new System.EventHandler(this.OpenCrud_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(941, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 33);
            this.label19.TabIndex = 24;
            this.label19.Text = "CRUD";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paydetailsPanel
            // 
            this.paydetailsPanel.ColumnCount = 5;
            this.paydetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paydetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paydetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.paydetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.paydetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.paydetailsPanel.Controls.Add(this.sdPLabel, 1, 0);
            this.paydetailsPanel.Controls.Add(this.addPDetail, 4, 0);
            this.paydetailsPanel.Controls.Add(this.sdPPicker, 1, 1);
            this.paydetailsPanel.Controls.Add(this.atPCombo, 3, 3);
            this.paydetailsPanel.Controls.Add(this.enPLabel, 0, 0);
            this.paydetailsPanel.Controls.Add(this.enPText, 0, 1);
            this.paydetailsPanel.Controls.Add(this.atPLabel, 3, 2);
            this.paydetailsPanel.Controls.Add(this.baPText, 2, 3);
            this.paydetailsPanel.Controls.Add(this.baPLabel, 2, 2);
            this.paydetailsPanel.Controls.Add(this.bnPLabel, 1, 2);
            this.paydetailsPanel.Controls.Add(this.rnPLabel, 0, 2);
            this.paydetailsPanel.Controls.Add(this.rnPText, 0, 3);
            this.paydetailsPanel.Controls.Add(this.bnPText, 1, 3);
            this.paydetailsPanel.Controls.Add(this.ptPLabel, 3, 0);
            this.paydetailsPanel.Controls.Add(this.ptPCombo, 3, 1);
            this.paydetailsPanel.Controls.Add(this.hidePPanel, 4, 2);
            this.paydetailsPanel.Location = new System.Drawing.Point(0, 135);
            this.paydetailsPanel.Name = "paydetailsPanel";
            this.paydetailsPanel.RowCount = 4;
            this.paydetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paydetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.paydetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paydetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.paydetailsPanel.Size = new System.Drawing.Size(1350, 148);
            this.paydetailsPanel.TabIndex = 25;
            this.paydetailsPanel.Visible = false;
            // 
            // sdPLabel
            // 
            this.sdPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.sdPLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sdPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdPLabel.ForeColor = System.Drawing.Color.White;
            this.sdPLabel.Location = new System.Drawing.Point(314, 0);
            this.sdPLabel.Name = "sdPLabel";
            this.sdPLabel.Size = new System.Drawing.Size(305, 39);
            this.sdPLabel.TabIndex = 1;
            this.sdPLabel.Text = "Start Date";
            this.sdPLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // addPDetail
            // 
            this.addPDetail.BackColor = System.Drawing.Color.Transparent;
            this.addPDetail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPDetail.Image = global::CrudEmployees.Properties.Resources.plusmini;
            this.addPDetail.Location = new System.Drawing.Point(1247, 3);
            this.addPDetail.Name = "addPDetail";
            this.addPDetail.Size = new System.Drawing.Size(100, 33);
            this.addPDetail.TabIndex = 5;
            this.addPDetail.Text = "Add";
            this.addPDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPDetail.UseVisualStyleBackColor = false;
            this.addPDetail.Click += new System.EventHandler(this.AddPDetail_Click);
            // 
            // sdPPicker
            // 
            this.sdPPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdPPicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdPPicker.Location = new System.Drawing.Point(314, 42);
            this.sdPPicker.Name = "sdPPicker";
            this.sdPPicker.Size = new System.Drawing.Size(305, 26);
            this.sdPPicker.TabIndex = 10;
            // 
            // atPCombo
            // 
            this.atPCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atPCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atPCombo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atPCombo.FormattingEnabled = true;
            this.atPCombo.Items.AddRange(new object[] {
            "Checking Account",
            "Savings Account",
            "IB Checking Account",
            "MM Account",
            "Retirement Account",
            "Brokerage Account"});
            this.atPCombo.Location = new System.Drawing.Point(936, 115);
            this.atPCombo.Name = "atPCombo";
            this.atPCombo.Size = new System.Drawing.Size(305, 28);
            this.atPCombo.TabIndex = 11;
            // 
            // enPLabel
            // 
            this.enPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.enPLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.enPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enPLabel.ForeColor = System.Drawing.Color.White;
            this.enPLabel.Location = new System.Drawing.Point(3, 0);
            this.enPLabel.Name = "enPLabel";
            this.enPLabel.Size = new System.Drawing.Size(305, 39);
            this.enPLabel.TabIndex = 0;
            this.enPLabel.Text = "Employee Number";
            this.enPLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // enPText
            // 
            this.enPText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enPText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enPText.Location = new System.Drawing.Point(3, 42);
            this.enPText.Name = "enPText";
            this.enPText.Size = new System.Drawing.Size(305, 26);
            this.enPText.TabIndex = 8;
            this.enPText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numText_KeyPress);
            // 
            // atPLabel
            // 
            this.atPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.atPLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.atPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atPLabel.ForeColor = System.Drawing.Color.White;
            this.atPLabel.Location = new System.Drawing.Point(936, 73);
            this.atPLabel.Name = "atPLabel";
            this.atPLabel.Size = new System.Drawing.Size(305, 39);
            this.atPLabel.TabIndex = 12;
            this.atPLabel.Text = "Account Type";
            this.atPLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // baPText
            // 
            this.baPText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baPText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baPText.Location = new System.Drawing.Point(625, 115);
            this.baPText.Name = "baPText";
            this.baPText.Size = new System.Drawing.Size(305, 26);
            this.baPText.TabIndex = 7;
            // 
            // baPLabel
            // 
            this.baPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.baPLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baPLabel.ForeColor = System.Drawing.Color.White;
            this.baPLabel.Location = new System.Drawing.Point(625, 73);
            this.baPLabel.Name = "baPLabel";
            this.baPLabel.Size = new System.Drawing.Size(305, 39);
            this.baPLabel.TabIndex = 2;
            this.baPLabel.Text = "Bank Address";
            this.baPLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bnPLabel
            // 
            this.bnPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.bnPLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPLabel.ForeColor = System.Drawing.Color.White;
            this.bnPLabel.Location = new System.Drawing.Point(314, 73);
            this.bnPLabel.Name = "bnPLabel";
            this.bnPLabel.Size = new System.Drawing.Size(305, 39);
            this.bnPLabel.TabIndex = 3;
            this.bnPLabel.Text = "Bank Name";
            this.bnPLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // rnPLabel
            // 
            this.rnPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.rnPLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rnPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnPLabel.ForeColor = System.Drawing.Color.White;
            this.rnPLabel.Location = new System.Drawing.Point(3, 77);
            this.rnPLabel.Name = "rnPLabel";
            this.rnPLabel.Size = new System.Drawing.Size(305, 35);
            this.rnPLabel.TabIndex = 14;
            this.rnPLabel.Text = "Routing Number";
            this.rnPLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // rnPText
            // 
            this.rnPText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rnPText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnPText.Location = new System.Drawing.Point(3, 115);
            this.rnPText.MaxLength = 9;
            this.rnPText.Name = "rnPText";
            this.rnPText.Size = new System.Drawing.Size(305, 26);
            this.rnPText.TabIndex = 15;
            this.rnPText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numText_KeyPress);
            // 
            // bnPText
            // 
            this.bnPText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnPText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPText.Location = new System.Drawing.Point(314, 115);
            this.bnPText.Name = "bnPText";
            this.bnPText.Size = new System.Drawing.Size(305, 26);
            this.bnPText.TabIndex = 16;
            // 
            // ptPLabel
            // 
            this.ptPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.ptPLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ptPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptPLabel.ForeColor = System.Drawing.Color.White;
            this.ptPLabel.Location = new System.Drawing.Point(936, 0);
            this.ptPLabel.Name = "ptPLabel";
            this.ptPLabel.Size = new System.Drawing.Size(305, 39);
            this.ptPLabel.TabIndex = 4;
            this.ptPLabel.Text = "Pay Type";
            this.ptPLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ptPCombo
            // 
            this.ptPCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptPCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ptPCombo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptPCombo.FormattingEnabled = true;
            this.ptPCombo.Location = new System.Drawing.Point(936, 42);
            this.ptPCombo.Name = "ptPCombo";
            this.ptPCombo.Size = new System.Drawing.Size(305, 28);
            this.ptPCombo.TabIndex = 13;
            // 
            // hidePPanel
            // 
            this.hidePPanel.BackColor = System.Drawing.Color.Transparent;
            this.hidePPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidePPanel.Image = global::CrudEmployees.Properties.Resources.toxic;
            this.hidePPanel.Location = new System.Drawing.Point(1247, 76);
            this.hidePPanel.Name = "hidePPanel";
            this.hidePPanel.Size = new System.Drawing.Size(100, 33);
            this.hidePPanel.TabIndex = 6;
            this.hidePPanel.Text = "Cancel";
            this.hidePPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hidePPanel.UseVisualStyleBackColor = false;
            this.hidePPanel.Click += new System.EventHandler(this.HidePPanel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 315);
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
            this.Controls.Add(this.paydetailsPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.paymentTable);
            this.Name = "Payment";
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payment_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.paymentTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.paydetailsPanel.ResumeLayout(false);
            this.paydetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView paymentTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button showFields;
        private System.Windows.Forms.Button editDetails;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button registerPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button openCrud;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel paydetailsPanel;
        private System.Windows.Forms.Button hidePPanel;
        private System.Windows.Forms.DateTimePicker sdPPicker;
        private System.Windows.Forms.ComboBox atPCombo;
        private System.Windows.Forms.Label enPLabel;
        private System.Windows.Forms.Label ptPLabel;
        private System.Windows.Forms.TextBox baPText;
        private System.Windows.Forms.Label sdPLabel;
        private System.Windows.Forms.TextBox enPText;
        private System.Windows.Forms.Label bnPLabel;
        private System.Windows.Forms.Label baPLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addPDetail;
        private System.Windows.Forms.Label atPLabel;
        private System.Windows.Forms.Label rnPLabel;
        private System.Windows.Forms.TextBox rnPText;
        private System.Windows.Forms.TextBox bnPText;
        private System.Windows.Forms.ComboBox ptPCombo;
        private System.Windows.Forms.ComboBox deptPCombo;
        private System.Windows.Forms.Label departmentPLabel;
        private System.Windows.Forms.Button loadDepartment;
    }
}