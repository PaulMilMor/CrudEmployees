namespace CrudEmployees
{
    partial class Tables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.employeesPanel = new System.Windows.Forms.Panel();
            this.genECombo = new System.Windows.Forms.ComboBox();
            this.hdEPicker = new System.Windows.Forms.DateTimePicker();
            this.bdEPicker = new System.Windows.Forms.DateTimePicker();
            this.lnEText = new System.Windows.Forms.TextBox();
            this.fnEText = new System.Windows.Forms.TextBox();
            this.hideFields = new System.Windows.Forms.Button();
            this.addRecord = new System.Windows.Forms.Button();
            this.hdELabel = new System.Windows.Forms.Label();
            this.bdELabel = new System.Windows.Forms.Label();
            this.genELabel = new System.Windows.Forms.Label();
            this.lnELabel = new System.Windows.Forms.Label();
            this.fnELabel = new System.Windows.Forms.Label();
            this.showFields = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.editRecord = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchInfo = new System.Windows.Forms.Label();
            this.lnSearch = new System.Windows.Forms.Label();
            this.lnSText = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.showSearch = new System.Windows.Forms.Button();
            this.fnSearch = new System.Windows.Forms.Label();
            this.fnSText = new System.Windows.Forms.TextBox();
            this.enSText = new System.Windows.Forms.TextBox();
            this.enSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            this.employeesPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.searchPanel.SuspendLayout();
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
            this.employeesTable.Location = new System.Drawing.Point(42, 203);
            this.employeesTable.MultiSelect = false;
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.employeesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesTable.Size = new System.Drawing.Size(799, 162);
            this.employeesTable.TabIndex = 0;
            // 
            // employeesPanel
            // 
            this.employeesPanel.Controls.Add(this.genECombo);
            this.employeesPanel.Controls.Add(this.hdEPicker);
            this.employeesPanel.Controls.Add(this.bdEPicker);
            this.employeesPanel.Controls.Add(this.lnEText);
            this.employeesPanel.Controls.Add(this.fnEText);
            this.employeesPanel.Controls.Add(this.hideFields);
            this.employeesPanel.Controls.Add(this.addRecord);
            this.employeesPanel.Controls.Add(this.hdELabel);
            this.employeesPanel.Controls.Add(this.bdELabel);
            this.employeesPanel.Controls.Add(this.genELabel);
            this.employeesPanel.Controls.Add(this.lnELabel);
            this.employeesPanel.Controls.Add(this.fnELabel);
            this.employeesPanel.Location = new System.Drawing.Point(42, 79);
            this.employeesPanel.Name = "employeesPanel";
            this.employeesPanel.Size = new System.Drawing.Size(799, 106);
            this.employeesPanel.TabIndex = 1;
            // 
            // genECombo
            // 
            this.genECombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genECombo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genECombo.FormattingEnabled = true;
            this.genECombo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genECombo.Location = new System.Drawing.Point(220, 63);
            this.genECombo.Name = "genECombo";
            this.genECombo.Size = new System.Drawing.Size(39, 28);
            this.genECombo.TabIndex = 11;
            // 
            // hdEPicker
            // 
            this.hdEPicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdEPicker.Location = new System.Drawing.Point(410, 65);
            this.hdEPicker.Name = "hdEPicker";
            this.hdEPicker.Size = new System.Drawing.Size(51, 26);
            this.hdEPicker.TabIndex = 10;
            // 
            // bdEPicker
            // 
            this.bdEPicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdEPicker.Location = new System.Drawing.Point(302, 64);
            this.bdEPicker.Name = "bdEPicker";
            this.bdEPicker.Size = new System.Drawing.Size(51, 26);
            this.bdEPicker.TabIndex = 9;
            // 
            // lnEText
            // 
            this.lnEText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnEText.Location = new System.Drawing.Point(120, 65);
            this.lnEText.Name = "lnEText";
            this.lnEText.Size = new System.Drawing.Size(54, 26);
            this.lnEText.TabIndex = 8;
            // 
            // fnEText
            // 
            this.fnEText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnEText.Location = new System.Drawing.Point(19, 62);
            this.fnEText.Name = "fnEText";
            this.fnEText.Size = new System.Drawing.Size(54, 26);
            this.fnEText.TabIndex = 7;
            // 
            // hideFields
            // 
            this.hideFields.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideFields.Location = new System.Drawing.Point(686, 62);
            this.hideFields.Name = "hideFields";
            this.hideFields.Size = new System.Drawing.Size(75, 23);
            this.hideFields.TabIndex = 6;
            this.hideFields.Text = "Cancel";
            this.hideFields.UseVisualStyleBackColor = true;
            this.hideFields.Click += new System.EventHandler(this.hideFields_Click);
            // 
            // addRecord
            // 
            this.addRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecord.Location = new System.Drawing.Point(686, 22);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(75, 23);
            this.addRecord.TabIndex = 5;
            this.addRecord.Text = "Add";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // hdELabel
            // 
            this.hdELabel.AutoSize = true;
            this.hdELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdELabel.Location = new System.Drawing.Point(407, 22);
            this.hdELabel.Name = "hdELabel";
            this.hdELabel.Size = new System.Drawing.Size(75, 18);
            this.hdELabel.TabIndex = 4;
            this.hdELabel.Text = "Hire Date";
            // 
            // bdELabel
            // 
            this.bdELabel.AutoSize = true;
            this.bdELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdELabel.Location = new System.Drawing.Point(299, 22);
            this.bdELabel.Name = "bdELabel";
            this.bdELabel.Size = new System.Drawing.Size(78, 18);
            this.bdELabel.TabIndex = 3;
            this.bdELabel.Text = "Birth Date";
            // 
            // genELabel
            // 
            this.genELabel.AutoSize = true;
            this.genELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genELabel.Location = new System.Drawing.Point(217, 22);
            this.genELabel.Name = "genELabel";
            this.genELabel.Size = new System.Drawing.Size(60, 18);
            this.genELabel.TabIndex = 2;
            this.genELabel.Text = "Gender";
            // 
            // lnELabel
            // 
            this.lnELabel.AutoSize = true;
            this.lnELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnELabel.Location = new System.Drawing.Point(117, 22);
            this.lnELabel.Name = "lnELabel";
            this.lnELabel.Size = new System.Drawing.Size(84, 18);
            this.lnELabel.TabIndex = 1;
            this.lnELabel.Text = "Last Name";
            // 
            // fnELabel
            // 
            this.fnELabel.AutoSize = true;
            this.fnELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnELabel.Location = new System.Drawing.Point(16, 22);
            this.fnELabel.Name = "fnELabel";
            this.fnELabel.Size = new System.Drawing.Size(85, 18);
            this.fnELabel.TabIndex = 0;
            this.fnELabel.Text = "First Name";
            // 
            // showFields
            // 
            this.showFields.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFields.Location = new System.Drawing.Point(370, 48);
            this.showFields.Name = "showFields";
            this.showFields.Size = new System.Drawing.Size(75, 23);
            this.showFields.TabIndex = 6;
            this.showFields.Text = "Add";
            this.showFields.UseVisualStyleBackColor = true;
            this.showFields.Click += new System.EventHandler(this.showFields_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showSearch);
            this.panel2.Controls.Add(this.deleteRecord);
            this.panel2.Controls.Add(this.showFields);
            this.panel2.Controls.Add(this.editRecord);
            this.panel2.Location = new System.Drawing.Point(42, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 106);
            this.panel2.TabIndex = 12;
            // 
            // deleteRecord
            // 
            this.deleteRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Location = new System.Drawing.Point(506, 48);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(75, 23);
            this.deleteRecord.TabIndex = 6;
            this.deleteRecord.Text = "Delete";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // editRecord
            // 
            this.editRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRecord.Location = new System.Drawing.Point(220, 48);
            this.editRecord.Name = "editRecord";
            this.editRecord.Size = new System.Drawing.Size(75, 23);
            this.editRecord.TabIndex = 5;
            this.editRecord.Text = "Edit";
            this.editRecord.UseVisualStyleBackColor = true;
            this.editRecord.Click += new System.EventHandler(this.EditRecord_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.enSearch);
            this.searchPanel.Controls.Add(this.enSText);
            this.searchPanel.Controls.Add(this.search);
            this.searchPanel.Controls.Add(this.fnSText);
            this.searchPanel.Controls.Add(this.lnSText);
            this.searchPanel.Controls.Add(this.lnSearch);
            this.searchPanel.Controls.Add(this.fnSearch);
            this.searchPanel.Controls.Add(this.searchInfo);
            this.searchPanel.Location = new System.Drawing.Point(857, 85);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(261, 280);
            this.searchPanel.TabIndex = 13;
            // 
            // searchInfo
            // 
            this.searchInfo.AutoSize = true;
            this.searchInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInfo.Location = new System.Drawing.Point(21, 16);
            this.searchInfo.Name = "searchInfo";
            this.searchInfo.Size = new System.Drawing.Size(145, 18);
            this.searchInfo.TabIndex = 12;
            this.searchInfo.Text = "Fill at least one field";
            // 
            // lnSearch
            // 
            this.lnSearch.AutoSize = true;
            this.lnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnSearch.Location = new System.Drawing.Point(21, 44);
            this.lnSearch.Name = "lnSearch";
            this.lnSearch.Size = new System.Drawing.Size(84, 18);
            this.lnSearch.TabIndex = 14;
            this.lnSearch.Text = "Last Name";
            // 
            // lnSText
            // 
            this.lnSText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnSText.Location = new System.Drawing.Point(25, 74);
            this.lnSText.Name = "lnSText";
            this.lnSText.Size = new System.Drawing.Size(128, 26);
            this.lnSText.TabIndex = 12;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(183, 74);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 12;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // showSearch
            // 
            this.showSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearch.Location = new System.Drawing.Point(99, 48);
            this.showSearch.Name = "showSearch";
            this.showSearch.Size = new System.Drawing.Size(75, 23);
            this.showSearch.TabIndex = 13;
            this.showSearch.Text = "Search";
            this.showSearch.UseVisualStyleBackColor = true;
            this.showSearch.Click += new System.EventHandler(this.ShowSearch_Click);
            // 
            // fnSearch
            // 
            this.fnSearch.AutoSize = true;
            this.fnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnSearch.Location = new System.Drawing.Point(21, 118);
            this.fnSearch.Name = "fnSearch";
            this.fnSearch.Size = new System.Drawing.Size(85, 18);
            this.fnSearch.TabIndex = 13;
            this.fnSearch.Text = "First Name";
            // 
            // fnSText
            // 
            this.fnSText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnSText.Location = new System.Drawing.Point(25, 149);
            this.fnSText.Name = "fnSText";
            this.fnSText.Size = new System.Drawing.Size(128, 26);
            this.fnSText.TabIndex = 15;
            // 
            // enSText
            // 
            this.enSText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enSText.Location = new System.Drawing.Point(25, 210);
            this.enSText.Name = "enSText";
            this.enSText.Size = new System.Drawing.Size(128, 26);
            this.enSText.TabIndex = 16;
            // 
            // enSearch
            // 
            this.enSearch.AutoSize = true;
            this.enSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enSearch.Location = new System.Drawing.Point(22, 189);
            this.enSearch.Name = "enSearch";
            this.enSearch.Size = new System.Drawing.Size(63, 18);
            this.enSearch.TabIndex = 17;
            this.enSearch.Text = "Number";
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 485);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.employeesPanel);
            this.Controls.Add(this.employeesTable);
            this.Name = "Tables";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.employeesPanel.ResumeLayout(false);
            this.employeesPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesTable;
        private System.Windows.Forms.Panel employeesPanel;
        private System.Windows.Forms.ComboBox genECombo;
        private System.Windows.Forms.DateTimePicker hdEPicker;
        private System.Windows.Forms.DateTimePicker bdEPicker;
        private System.Windows.Forms.TextBox lnEText;
        private System.Windows.Forms.TextBox fnEText;
        private System.Windows.Forms.Button hideFields;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Label hdELabel;
        private System.Windows.Forms.Label bdELabel;
        private System.Windows.Forms.Label genELabel;
        private System.Windows.Forms.Label lnELabel;
        private System.Windows.Forms.Label fnELabel;
        private System.Windows.Forms.Button showFields;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button editRecord;
        private System.Windows.Forms.Button showSearch;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox lnSText;
        private System.Windows.Forms.Label lnSearch;
        private System.Windows.Forms.Label searchInfo;
        private System.Windows.Forms.Label enSearch;
        private System.Windows.Forms.TextBox enSText;
        private System.Windows.Forms.TextBox fnSText;
        private System.Windows.Forms.Label fnSearch;
    }
}

