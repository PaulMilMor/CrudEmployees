﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEmployees
{
    public partial class Tables : Form
    {
        Conexion c = null;
        DataSet ds = null;
        Panel[] panels;
        Button[] addButtons;
        public Tables()
        {
            InitializeComponent();
            //Datos del Form y tamaños
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            /*employeesTable.Width = this.Width - this.Width/28;
            employeesTable.Height = this.Height / 3;
            employeesTable.Location = new Point(this.Width/56,this.Height*2/5);*/

            //Datos del registro de empleados
            /*employeesPanel.Visible = false;
            employeesPanel.Width = this.Width - this.Width / 27;
            employeesPanel.Height = this.Height / 5;
            employeesPanel.Location = new Point(this.Width / 54, this.Height / 5);
            fnEText.Width = employeesPanel.Width / 7;
            lnEText.Width = employeesPanel.Width / 7;
            genECombo.Width = employeesPanel.Width / 7;
            bdEPicker.Width = employeesPanel.Width / 7;
            hdEPicker.Width = employeesPanel.Width / 7;
            addRecord.Width = employeesPanel.Width / 7;
            addRecord.Height = employeesPanel.Height / 3;
            hideFields.Height = employeesPanel.Height / 3;
            hideFields.Width = employeesPanel.Width / 7;
            fnELabel.Location = new Point(employeesPanel.Width / 49, 0);
            fnEText.Location = new Point(employeesPanel.Width / 49, fnELabel.Height*16/3);
            lnELabel.Location = new Point(employeesPanel.Width *9/ 49, 0 );
            lnEText.Location = new Point(employeesPanel.Width *9/ 49, lnELabel.Height * 16 / 3);
            genELabel.Location = new Point(employeesPanel.Width *17/ 49, 0);
            genECombo.Location = new Point(employeesPanel.Width*17 / 49, genELabel.Height * 16 / 3);
            bdELabel.Location = new Point(employeesPanel.Width *25/ 49, 0);
            bdEPicker.Location = new Point(employeesPanel.Width *25/ 49, bdELabel.Height * 16 / 3);
            hdELabel.Location = new Point(employeesPanel.Width *33/ 49, 0);
            hdEPicker.Location = new Point(employeesPanel.Width *33/ 49, hdELabel.Height * 16 / 3);
            addRecord.Location = new Point(employeesPanel.Width * 41 / 49, 0);
            hideFields.Location = new Point(employeesPanel.Width * 41 / 49, hdELabel.Height * 16 / 3);*/

            //Datos del panel de Búsqueda
            /*searchPanel.Visible = false;
            searchPanel.Width = this.Width - this.Width / 27;
            searchPanel.Height = this.Height / 5;
            searchPanel.Location = new Point(this.Width / 54, this.Height / 5);
            enSText.Width = searchPanel.Width / 5;
            fnSText.Width = searchPanel.Width / 5;
            lnSText.Width = searchPanel.Width / 5;
            search.Width = searchPanel.Width / 5;
            searchInfo.Location = new Point(0, 0);
            enSearch.Location = new Point(0, searchInfo.Height * 17 / 15);
            enSText.Location = new Point(0, enSearch.Location.Y + enSearch.Height * 17 / 15);
            */



            //Datos del panel de control
            /*panel2.Width = this.Width - this.Width / 27;
            panel2.Height = this.Height / 5;
            panel2.Location = new Point(this.Width / 54, this.Height*4 / 5);
            showFields.Height = panel2.Height / 3;
            showFields.Width = panel2.Width / 7;
            deleteRecord.Height = panel2.Height / 3;
            deleteRecord.Width = panel2.Width / 7;
            editRecord.Height = panel2.Height / 3;
            editRecord.Width = panel2.Width / 7;
            showSearch.Height = panel2.Height / 3;
            showSearch.Width = panel2.Width / 7;
            showSearch.Location = new Point(0,0);
            showFields.Location = new Point(showSearch.Width + showSearch.Width / 2 , 0);
            editRecord.Location = new Point(showFields.Location.X + showFields.Width*3/2, 0);
            deleteRecord.Location = new Point(panel2.Width-deleteRecord.Width, 0);*/
            panels = new Panel[]{employeesPanel, departmentsPanel, managerPanel, deptempPanel, titlesPanel, salariesPanel };
            addButtons = new Button[] {addEmployee,addDepartment,addManager,addDeptEmp,addTitle,addSalary };

            c = new Conexion();
            this.setData("employees");

            ds.Dispose();
        }
        private void setData(string table)
        {
            switch (table)
            {
                case "employees":
                    ds = new DataSet();
                    ds = c.getData(table);

                    employeesTable.DataSource = ds.Tables[table].DefaultView;
                    employeesTable.Columns[0].HeaderText = "Employee Number";
                    employeesTable.Columns[1].HeaderText = "First Name";
                    employeesTable.Columns[2].HeaderText = "Last Name";
                    employeesTable.Columns[3].HeaderText = "Gender";
                    employeesTable.Columns[4].HeaderText = "Birth Date";
                    employeesTable.Columns[5].HeaderText = "Hire Date";
                    break;
                case "departments":
                    ds = new DataSet();
                    ds = c.getData(table);
                    departmentsTable.DataSource = ds.Tables[table].DefaultView;
                    departmentsTable.Columns[0].HeaderText = "Department Number";
                    departmentsTable.Columns[1].HeaderText = "Department Name";
                    break;
                case "dept_manager":
                    ds = new DataSet();
                    ds = c.getData(table);
                    deptmanagerTable.DataSource = ds.Tables[table].DefaultView;
                    deptmanagerTable.Columns[0].HeaderText = "Employee Number";
                    deptmanagerTable.Columns[1].HeaderText = "First Name";
                    deptmanagerTable.Columns[2].HeaderText = "Last Name";
                    deptmanagerTable.Columns[3].HeaderText = "Department Number";
                    deptmanagerTable.Columns[4].HeaderText = "From Date";
                    deptmanagerTable.Columns[5].HeaderText = "To Date";
                    break;
                case "dept_emp":
                    ds = new DataSet();
                    ds = c.getData(table);
                    deptempTable.DataSource = ds.Tables[table].DefaultView;
                    deptempTable.Columns[0].HeaderText = "Employee Number";
                    deptempTable.Columns[1].HeaderText = "First Name";
                    deptempTable.Columns[2].HeaderText = "Last Name";
                    deptempTable.Columns[3].HeaderText = "Department Number";
                    deptempTable.Columns[4].HeaderText = "From Date";
                    deptempTable.Columns[5].HeaderText = "To Date";
                    break;
                case "titles":
                    ds = new DataSet();
                    ds = c.getData(table);
                    titlesTable.DataSource = ds.Tables[table].DefaultView;
                    titlesTable.Columns[0].HeaderText = "Employee Number";
                    titlesTable.Columns[1].HeaderText = "First Name";
                    titlesTable.Columns[2].HeaderText = "Last Name";
                    titlesTable.Columns[3].HeaderText = "Title";
                    titlesTable.Columns[4].HeaderText = "From Date";
                    titlesTable.Columns[5].HeaderText = "To Date";
                    break;
                case "salaries":
                    ds = new DataSet();
                    ds = c.getData(table);
                    salariesTable.DataSource = ds.Tables[table].DefaultView;
                    salariesTable.Columns[0].HeaderText = "Employee Number";
                    salariesTable.Columns[1].HeaderText = "First Name";
                    salariesTable.Columns[2].HeaderText = "Last Name";
                    salariesTable.Columns[3].HeaderText = "Salary";
                    salariesTable.Columns[4].HeaderText = "From Date";
                    salariesTable.Columns[5].HeaderText = "To Date";
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showFields_Click(object sender, EventArgs e)
        {
            //employeesPanel.Visible = true;
            int index = tabControl1.SelectedIndex;
            panels[index].Visible = true;
            addButtons[index].Text = "Add";
        }

        private void hideFields_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            panels[index].Visible = false;
            fnEText.Text = "";
            lnEText.Text = "";
            genECombo.SelectedIndex = -1;
            bdEPicker.Value = DateTime.Now;
            hdEPicker.Value = DateTime.Now;
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            if (addEmployee.Text.Equals("Add"))
            {
                Object[] row = new object[5];


                row[0] = fnEText.Text;
                row[1] = lnEText.Text;
                row[2] = genECombo.SelectedItem.ToString();
                row[3] = bdEPicker.Value;
                row[4] = hdEPicker.Value;
                for (int i = 0; i < row.Length; i++)
                {
                    Console.WriteLine(row[i].GetType());
                }
                c.Insert("employees", row);
                ds = new DataSet();
                ds = c.getData("employees");
                employeesTable.DataSource = ds.Tables["employees"].DefaultView;
                employeesTable.Refresh();
                ds.Dispose();
                fnEText.Text = "";
                lnEText.Text = "";
                genECombo.SelectedIndex = -1;
                bdEPicker.Value = DateTime.Now;
                hdEPicker.Value = DateTime.Now;
            }
            else
            {
                if (employeesTable.SelectedCells.Count > 0)
                {
                    Object[] row = new object[6];
                    int selectedrowindex = employeesTable.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = employeesTable.Rows[selectedrowindex];
                    row[0] = Convert.ToInt32(selectedRow.Cells[0].Value);

                    row[1] = fnEText.Text;
                    row[2] = lnEText.Text;
                    row[3] = genECombo.SelectedItem.ToString();
                    row[4] = bdEPicker.Value;
                    row[5] = hdEPicker.Value;
                    for (int i = 0; i < row.Length; i++)
                    {
                        Console.WriteLine(row[i].GetType());
                    }
                    c.Edit("employees", row);
                    ds = new DataSet();
                    ds = c.getData("employees");
                    employeesTable.DataSource = ds.Tables["employees"].DefaultView;
                    employeesTable.Refresh();
                    ds.Dispose();
                    fnEText.Text = "";
                    lnEText.Text = "";
                    genECombo.SelectedIndex = -1;
                    bdEPicker.Value = DateTime.Now;
                    hdEPicker.Value = DateTime.Now;
                }
                    
            }

            addEmployee.Text = "Add";
            employeesPanel.Visible = false;
            
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            if (employeesTable.SelectedCells.Count > 0)
            {
                int selectedrowindex = employeesTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = employeesTable.Rows[selectedrowindex];
                int empno = Convert.ToInt32(selectedRow.Cells[0].Value);
                c.Delete("employees", empno);
                ds = new DataSet();
                ds = c.getData("employees");
                employeesTable.DataSource = ds.Tables["employees"].DefaultView;
                employeesTable.Refresh();
                ds.Dispose();

            }
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            Object[] row = new object[6];
            if (employeesTable.SelectedCells.Count > 0)
            {
                int selectedrowindex = employeesTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = employeesTable.Rows[selectedrowindex];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    switch(i)
                    {
                        

                        case 1:
                            fnEText.Text = Convert.ToString(selectedRow.Cells[i].Value);
                            break;

                        case 2:
                            lnEText.Text = Convert.ToString(selectedRow.Cells[i].Value);
                            break;

                        case 3:
                            string selectedgender = Convert.ToString(selectedRow.Cells[i].Value);
                            if (selectedgender.Equals("M"))
                            {
                                genECombo.SelectedIndex = 0;
                            }
                            else
                            {
                                genECombo.SelectedIndex = 1;
                            }

                            break;

                        case 4:
                            bdEPicker.Value = Convert.ToDateTime(selectedRow.Cells[i].Value);
                            break;

                        case 5:
                            hdEPicker.Value = Convert.ToDateTime(selectedRow.Cells[i].Value);
                            break;


                    }
                    
                }
                string a = Convert.ToString(selectedRow.Cells[0].Value);

            }
            int index = tabControl1.SelectedIndex;
           addButtons[index].Text = "Edit";
            panels[index].Visible = true;
            
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string tableName = tabControl1.SelectedTab.Name;
            this.setData(tableName);
        }
    }
}