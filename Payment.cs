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
            tables = new DataGridView[] { bonusTable, deductionsTable, holidayTable, sickleaveTable, paydetailsTable, payhistoryTable };
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
                    bonusTable.DataSource = ds.Tables[table].DefaultView;
                    break;
                case "deduction":
                    ds = new DataSet();
                    ds = c.getData(table);
                    deductionsTable.DataSource = ds.Tables[table].DefaultView;
                    break;
                case "holiday":
                    ds = new DataSet();
                    ds = c.getData(table);
                    holidayTable.DataSource = ds.Tables[table].DefaultView;
                    break;
                case "sickleave":
                    ds = new DataSet();
                    ds = c.getData(table);
                    sickleaveTable.DataSource = ds.Tables[table].DefaultView;
                    break;
                case "paydetails":
                    ds = new DataSet();
                    ds = c.getData(table);
                    paydetailsTable.DataSource = ds.Tables[table].DefaultView;
                    break;
                case "payhistory":
                    ds = new DataSet();
                    ds = c.getData(table);
                    payhistoryTable.DataSource = ds.Tables[table].DefaultView;
                    break;
                case "employees":
                    ds = new DataSet();
                    ds = c.getData(table);

                    bonusTable.DataSource = ds.Tables[table].DefaultView;
                    bonusTable.Columns[0].HeaderText = "Employee Number";
                    bonusTable.Columns[1].HeaderText = "First Name";
                    bonusTable.Columns[2].HeaderText = "Last Name";
                    bonusTable.Columns[3].HeaderText = "Gender";
                    bonusTable.Columns[4].HeaderText = "Birth Date";
                    bonusTable.Columns[5].HeaderText = "Hire Date";
                    showingEmployees.Text = "Showing last 100 hired employees";
                    break;
                case "departments":
                    ds = new DataSet();
                    ds = c.getData(table);
                    deductionsTable.DataSource = ds.Tables[table].DefaultView;
                    deductionsTable.Columns[0].HeaderText = "Department Number";
                    deductionsTable.Columns[1].HeaderText = "Department Name";
                    showingDepartments.Text = "Showing all departments";
                    break;
                case "dept_manager":
                    ds = new DataSet();
                    ds = c.getData(table);
                    holidayTable.DataSource = ds.Tables[table].DefaultView;
                    holidayTable.Columns[0].HeaderText = "Employee Number";
                    holidayTable.Columns[1].HeaderText = "First Name";
                    holidayTable.Columns[2].HeaderText = "Last Name";
                    holidayTable.Columns[3].HeaderText = "Department Number";
                    holidayTable.Columns[4].HeaderText = "From Date";
                    holidayTable.Columns[5].HeaderText = "To Date";
                    showingManagers.Text = "Showing all managers";
                    break;
                case "dept_emp":
                    ds = new DataSet();
                    ds = c.getData(table);
                    sickleaveTable.DataSource = ds.Tables[table].DefaultView;
                    sickleaveTable.Columns[0].HeaderText = "Employee Number";
                    sickleaveTable.Columns[1].HeaderText = "First Name";
                    sickleaveTable.Columns[2].HeaderText = "Last Name";
                    sickleaveTable.Columns[3].HeaderText = "Department Number";
                    sickleaveTable.Columns[4].HeaderText = "From Date";
                    sickleaveTable.Columns[5].HeaderText = "To Date";
                    showingDeptemp.Text = "Showing last 100 department changes";
                    break;
                case "titles":
                    ds = new DataSet();
                    ds = c.getData(table);
                    paydetailsTable.DataSource = ds.Tables[table].DefaultView;
                    paydetailsTable.Columns[0].HeaderText = "Employee Number";
                    paydetailsTable.Columns[1].HeaderText = "First Name";
                    paydetailsTable.Columns[2].HeaderText = "Last Name";
                    paydetailsTable.Columns[3].HeaderText = "Title";
                    paydetailsTable.Columns[4].HeaderText = "From Date";
                    paydetailsTable.Columns[5].HeaderText = "To Date";
                    showingTitles.Text = "Showing last 100 title changes";
                    break;
                case "salaries":
                    ds = new DataSet();
                    ds = c.getData(table);
                    payhistoryTable.DataSource = ds.Tables[table].DefaultView;
                    payhistoryTable.Columns[0].HeaderText = "Employee Number";
                    payhistoryTable.Columns[1].HeaderText = "First Name";
                    payhistoryTable.Columns[2].HeaderText = "Last Name";
                    payhistoryTable.Columns[3].HeaderText = "Salary";
                    payhistoryTable.Columns[4].HeaderText = "From Date";
                    payhistoryTable.Columns[5].HeaderText = "To Date";
                    showingSalaries.Text = "Showing last 100 salary changes";
                    break;
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setData(tabControl1.SelectedTab.Name);

        }
    }
}
