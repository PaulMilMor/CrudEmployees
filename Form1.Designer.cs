namespace CrudEmployees
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gender = new System.Windows.Forms.ComboBox();
            this.hireDate = new System.Windows.Forms.DateTimePicker();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.hideFields = new System.Windows.Forms.Button();
            this.addRecord = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showFields = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.editRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.hireDate);
            this.panel1.Controls.Add(this.birthDate);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.hideFields);
            this.panel1.Controls.Add(this.addRecord);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 106);
            this.panel1.TabIndex = 1;
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.gender.Location = new System.Drawing.Point(220, 63);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(39, 28);
            this.gender.TabIndex = 11;
            // 
            // hireDate
            // 
            this.hireDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireDate.Location = new System.Drawing.Point(410, 65);
            this.hireDate.Name = "hireDate";
            this.hireDate.Size = new System.Drawing.Size(51, 26);
            this.hireDate.TabIndex = 10;
            // 
            // birthDate
            // 
            this.birthDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.Location = new System.Drawing.Point(302, 64);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(51, 26);
            this.birthDate.TabIndex = 9;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(120, 65);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(54, 26);
            this.lastName.TabIndex = 8;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(19, 62);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(54, 26);
            this.firstName.TabIndex = 7;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hire Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employeesTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.DateTimePicker hireDate;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button hideFields;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showFields;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button editRecord;
    }
}

