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
    public partial class Payment : Form
    {
        Conexion c = null;
        DataSet ds = null;
        //List<String> deptnums;
        Panel[] panels;
        Button[] addButtons;
        DataGridView[] tables;
        public Payment()
        {
            InitializeComponent();
            //Datos del Form y tamaños
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            panels = new Panel[] { employeesPanel, departmentsPanel, managerPanel, deptempPanel, titlesPanel, salariesPanel };
            addButtons = new Button[] { addEmployee, addDepartment, addManager, addDeptEmp, addTitle, addSalary };
            tables = new DataGridView[] { employeesTable, departmentsTable, deptmanagerTable, deptempTable, titlesTable, salariesTable };
            c = new Conexion();
            this.setData(tabControl1.SelectedTab.Name);

            //ds.Dispose();

        }

        private void setData(string table)
        {
            switch (table)
            {
                case "bonus":
                    ds = new DataSet();
                    ds = c.getData(table);
                    employeesTable.DataSource = ds.Tables[table].DefaultView;
                    break;
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
                    showingEmployees.Text = "Showing last 100 hired employees";
                    break;
                case "departments":
                    ds = new DataSet();
                    ds = c.getData(table);
                    departmentsTable.DataSource = ds.Tables[table].DefaultView;
                    departmentsTable.Columns[0].HeaderText = "Department Number";
                    departmentsTable.Columns[1].HeaderText = "Department Name";
                    showingDepartments.Text = "Showing all departments";
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
                    showingManagers.Text = "Showing all managers";
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
                    showingDeptemp.Text = "Showing last 100 department changes";
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
                    showingTitles.Text = "Showing last 100 title changes";
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
                    showingSalaries.Text = "Showing last 100 salary changes";
                    break;
            }
        }

    }
}
