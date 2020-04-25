using MySql.Data.MySqlClient;
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
        DataGridView[] tables;
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
            tables = new DataGridView[] { employeesTable, departmentsTable, deptmanagerTable, deptempTable, titlesTable, salariesTable };
            searchBar.GotFocus += search_GotFocus;
            searchBar.LostFocus += search_LostFocus;
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
        private void InsertData()
        {
            Object[] row;
            int index = tabControl1.SelectedIndex;
            switch (index)
            {
                case 0:
                    row = new Object[5];


                    row[0] = fnEText.Text;
                    row[1] = lnEText.Text;
                    row[2] = genECombo.SelectedItem.ToString();
                    row[3] = bdEPicker.Value;
                    row[4] = hdEPicker.Value;
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
                    break;
                case 1:
                    row = new Object[2];
                    row[0] = dnoDText.Text;
                    row[1] = dnDText.Text;
                    c.Insert("departments", row);
                    ds = new DataSet();
                    ds = c.getData("departments");
                    departmentsTable.DataSource = ds.Tables["departments"].DefaultView;
                    departmentsTable.Refresh();
                    ds.Dispose();
                    dnoDText.Text = "";
                    dnDText.Text = "";
                    break;
                case 2:
                    row = new Object[4];
                    row[0] = enDMText.Text;
                    row[1] = dnoDMText.Text;
                    row[2] = fdDMPicker.Value;
                    row[3] = tdDMPicker.Value;
                    c.Insert("dept_manager", row);
                    ds = new DataSet();
                    ds = c.getData("dept_manager");
                    deptmanagerTable.DataSource = ds.Tables["dept_manager"].DefaultView;
                    deptmanagerTable.Refresh();
                    ds.Dispose();
                    enDMText.Text = "";
                    dnoDMText.Text = "";
                    fdDMPicker.Value = DateTime.Now;
                    tdDMPicker.Value = DateTime.Now;
                    break;
                case 3:
                    row = new object[4];
                    row[0] = enDEText.Text;
                    row[1] = dnoDEText.Text;
                    row[2] = fdDEPicker.Value;
                    row[3] = tdDEPicker.Value;
                    c.Insert("dept_emp", row);
                    ds = new DataSet();
                    ds = c.getData("dept_emp");
                    deptempTable.DataSource = ds.Tables["dept_emp"].DefaultView;
                    deptempTable.Refresh();
                    ds.Dispose();
                    enDEText.Text = "";
                    dnoDEText.Text = "";
                    fdDEPicker.Value = DateTime.Now;
                    tdDEPicker.Value = DateTime.Now;
                    break;
                case 4:
                    row = new Object[4];
                    row[0] = enTText.Text;
                    row[1] = tiTText.Text;
                    row[2] = fdTPicker.Value;
                    row[3] = tdTPicker.Value;
                    c.Insert("titles", row);
                    ds = new DataSet();
                    ds = c.getData("titles");
                    deptmanagerTable.DataSource = ds.Tables["titles"].DefaultView;
                    deptmanagerTable.Refresh();
                    ds.Dispose();
                    enTText.Text = "";
                    tiTText.Text = "";
                    fdTPicker.Value = DateTime.Now;
                    tdTPicker.Value = DateTime.Now;
                    break;
                case 5:
                    row = new Object[4];
                    row[0] = enSText.Text;
                    row[1] = salSText.Text;
                    row[2] = fdSPicker.Value;
                    row[3] = tdSPicker.Value;
                    c.Insert("salaries", row);
                    ds = new DataSet();
                    ds = c.getData("salaries");
                    deptmanagerTable.DataSource = ds.Tables["salaries"].DefaultView;
                    deptmanagerTable.Refresh();
                    ds.Dispose();
                    enSText.Text = "";
                    salSText.Text = "";
                    fdSPicker.Value = DateTime.Now;
                    tdSPicker.Value = DateTime.Now;
                    break;

            }
            tables[index].Refresh();
        }

        private void EditData()
        {
            int index = tabControl1.SelectedIndex;
            Object[] row;
            if (tables[index].SelectedCells.Count > 0)
            {
                int selectedrowindex = tables[index].SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tables[index].Rows[selectedrowindex];

                switch (index)
                {
                    case 0:
                        row = new object[6];
                        row[0] = Convert.ToInt32(selectedRow.Cells[0].Value);
                        row[1] = fnEText.Text;
                        row[2] = lnEText.Text;
                        row[3] = genECombo.SelectedItem.ToString();
                        row[4] = bdEPicker.Value;
                        row[5] = hdEPicker.Value;
                        c.Edit("employees", row);
                        break;
                    case 1:
                        row = new object[2];
                        row[0] = dnoDText.Text;
                        row[1] = dnDText.Text;
                        c.Edit("departments", row);
                        break;
                    case 2:
                        row = new object[4];
                        row[0] = enDMText.Text;
                        row[1] = dnoDMText.Text;
                        row[2] = fdDMPicker.Value;
                        row[3] = tdDMPicker.Value;
                        c.Edit("dept_manager", row);
                        break;
                    case 3:
                        row = new object[4];
                        row[0] = enDEText.Text;
                        row[1] = dnoDEText.Text;
                        row[2] = fdDEPicker.Value;
                        row[3] = tdDEPicker.Value;
                        c.Edit("dept_emp", row);
                        break;
                    case 4:
                        row = new object[4];
                        row[0] = enTText.Text;
                        row[1] = tiTText.Text;
                        row[2] = fdTPicker.Value;
                        row[3] = tdTPicker.Value;
                        c.Edit("titles", row);
                        break;
                    case 5:
                        row = new object[4];
                        row[0] = enSText.Text;
                        row[1] = salSText.Text;
                        row[2] = fdSPicker.Value;
                        row[3] = tdSPicker.Value;
                        c.Edit("salaries", row);
                        break;
                }
                //Object[] row = new object[6];
                string tableName = tabControl1.SelectedTab.Name;
                this.setData(tableName);
                this.hideFields_Click(this, new EventArgs());

               /* c.Edit("employees", row);
                ds = new DataSet();
                ds = c.getData("employees");
                employeesTable.DataSource = ds.Tables["employees"].DefaultView;
                employeesTable.Refresh();
                ds.Dispose();
                fnEText.Text = "";
                lnEText.Text = "";
                genECombo.SelectedIndex = -1;
                bdEPicker.Value = DateTime.Now;
                hdEPicker.Value = DateTime.Now;*/
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
            tables[index].Enabled = true;
            addButtons[index].Text = "Add";
            switch (index)
            {
                case 0:
                    fnEText.Text = "";
                    lnEText.Text = "";
                    genECombo.SelectedIndex = -1;
                    bdEPicker.Value = DateTime.Now;
                    hdEPicker.Value = DateTime.Now;
                    break;
                case 1:
                    dnoDText.Text = "";
                    dnDText.Text = "";
                    break;
                case 2:
                    dnoDMText.Text = "";
                    dnoDMText.Enabled = true;
                    enDMText.Text = "";
                    enDMText.Enabled = true;
                    fdDMPicker.Value = DateTime.Now;
                    tdDMPicker.Value = DateTime.Now;
                    break;
                case 3:
                    dnoDEText.Text = "";
                    dnoDEText.Enabled = true;
                    enDEText.Text = "";
                    enDEText.Enabled = true;
                    fdDEPicker.Value = DateTime.Now;
                    tdDEPicker.Value = DateTime.Now;
                    break;
                case 4:
                    enTText.Text = "";
                    enTText.Enabled = true;
                    tiTText.Text = "";
                    tiTText.Enabled = true;
                    fdTPicker.Value = DateTime.Now;
                    fdTPicker.Enabled = true;
                    tdTPicker.Value = DateTime.Now;
                    break;
                case 5:
                    enSText.Text = "";
                    enSText.Enabled = true;
                    salSText.Text = "";
                    fdSPicker.Value = DateTime.Now;
                    fdSPicker.Enabled = true;
                    tdSPicker.Value = DateTime.Now;
                    break;

            }
        }

        private void hideFields_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            panels[index].Visible = false;
            tables[index].Enabled = true;
            switch (index)
            {
                case 0:
                    fnEText.Text = "";
                    lnEText.Text = "";
                    genECombo.SelectedIndex = -1;
                    bdEPicker.Value = DateTime.Now;
                    hdEPicker.Value = DateTime.Now;
                    break;
                case 1:
                    dnoDText.Text = "";
                    dnDText.Text = "";
                    break;
                case 2:
                    dnoDMText.Text = "";
                    dnoDMText.Enabled = true;
                    enDMText.Text = "";
                    enDMText.Enabled = true;
                    fdDMPicker.Value = DateTime.Now;
                    tdDMPicker.Value = DateTime.Now;
                    break;
                case 3:
                    dnoDEText.Text = "";
                    dnoDEText.Enabled = true;
                    enDEText.Text = "";
                    enDEText.Enabled = true;
                    fdDEPicker.Value = DateTime.Now;
                    tdDEPicker.Value = DateTime.Now;
                    break;
                case 4:
                    enTText.Text = "";
                    enTText.Enabled = true;
                    tiTText.Text = "";
                    tiTText.Enabled = true;
                    fdTPicker.Value = DateTime.Now;
                    fdTPicker.Enabled = true;
                    tdTPicker.Value = DateTime.Now;
                    break;
                case 5:
                    enSText.Text = "";
                    enSText.Enabled = true;
                    salSText.Text = "";
                    fdSPicker.Value = DateTime.Now;
                    fdSPicker.Enabled = true;
                    tdSPicker.Value = DateTime.Now;
                    break;

            }

            

            



        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if (addButtons[index].Text.Equals("Add"))
            {
                this.InsertData();
            }
            else
            {
                this.EditData();
                    
            }
            
            addButtons[index].Text = "Add";
            panels[index].Visible = false;
            
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record? It might delete some records in other tables", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                int index = tabControl1.SelectedIndex;
                Object[] row;
                if (tables[index].SelectedCells.Count > 0)
                {
                    int selectedrowindex = tables[index].SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = tables[index].Rows[selectedrowindex];
                    switch (index)
                    {
                        case 0:
                            row = new object[1];
                            row[0] = Convert.ToInt32(selectedRow.Cells[0].Value);
                            c.Delete("employees", row);
                            break;
                        case 1:
                            row = new object[1];
                            row[0] = Convert.ToString(selectedRow.Cells[0].Value);
                            c.Delete("departments", row);
                            break;
                        case 2:
                            row = new object[2];
                            row[0] = Convert.ToInt32(selectedRow.Cells[0].Value);
                            row[1] = Convert.ToString(selectedRow.Cells[3].Value);
                            c.Delete("dept_manager", row);
                            break;
                        case 3:
                            row = new object[2];
                            row[0] = Convert.ToInt32(selectedRow.Cells[0].Value);
                            row[1] = Convert.ToString(selectedRow.Cells[3].Value);
                            c.Delete("dept_emp", row);
                            break;
                        case 4:
                            row = new object[3];
                            row[0] = Convert.ToInt32(selectedRow.Cells[0].Value);
                            row[1] = Convert.ToString(selectedRow.Cells[3].Value);
                            row[2] = Convert.ToDateTime(selectedRow.Cells[4].Value);
                            c.Delete("titles", row);
                            break;
                        case 5:
                            row = new object[2];
                            row[0] = Convert.ToInt32(selectedRow.Cells[0].Value);
                            row[1] = Convert.ToDateTime(selectedRow.Cells[4].Value);
                            break;

                    }




                    string tableName = tabControl1.SelectedTab.Name;
                    this.setData(tableName);
                    tables[index].Refresh();
                    //c.Delete("employees", empno);
                    //ds = new DataSet();
                    //ds = c.getData("employees");
                    //employeesTable.DataSource = ds.Tables["employees"].DefaultView;
                    //employeesTable.Refresh();
                    //ds.Dispose();

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            Object[] row = new object[6];
            int index = tabControl1.SelectedIndex;
            DateTime temptd;
            if (tables[index].SelectedCells.Count > 0)
            {
                
                int selectedrowindex = tables[index].SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = tables[index].Rows[selectedrowindex];
                switch (index)
                {
                    case 0:
                        fnEText.Text = Convert.ToString(selectedRow.Cells[1].Value);
                        lnEText.Text = Convert.ToString(selectedRow.Cells[2].Value);
                        string selectedgender = Convert.ToString(selectedRow.Cells[3].Value);
                        if (selectedgender.Equals("M"))
                        {
                            genECombo.SelectedIndex = 0;
                        }
                        else
                        {
                            genECombo.SelectedIndex = 1;
                        }
                        bdEPicker.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                        hdEPicker.Value = Convert.ToDateTime(selectedRow.Cells[5].Value);
                        break;
                    case 1:
                        dnoDText.Text = Convert.ToString(selectedRow.Cells[0].Value);
                        dnoDText.Enabled = false;
                        dnDText.Text = Convert.ToString(selectedRow.Cells[1].Value);
                        break;
                    case 2:
                        enDMText.Text = Convert.ToString(selectedRow.Cells[0].Value);
                        enDMText.Enabled = false;
                        dnoDMText.Text = Convert.ToString(selectedRow.Cells[3].Value);
                        dnoDMText.Enabled = false;
                        fdDMPicker.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                        temptd = Convert.ToDateTime(selectedRow.Cells[5].Value);
                        
                        if (temptd.Year >= 9999)
                        {
                            temptd = new DateTime(9998, temptd.Month, temptd.Day);
                            
                        }
                        tdDMPicker.Value = temptd;
                        break;
                    case 3:
                        enDEText.Text = Convert.ToString(selectedRow.Cells[0].Value);
                        enDEText.Enabled = false;
                        dnoDEText.Text = Convert.ToString(selectedRow.Cells[3].Value);
                        dnoDEText.Enabled = false;
                        fdDEPicker.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                        temptd = Convert.ToDateTime(selectedRow.Cells[5].Value);

                        if (temptd.Year >= 9999)
                        {
                            temptd = new DateTime(9998, temptd.Month, temptd.Day);

                        }
                        tdDEPicker.Value = temptd;
                        break;
                    case 4:
                        enTText.Text = Convert.ToString(selectedRow.Cells[0].Value);
                        enTText.Enabled = false;
                        tiTText.Text = Convert.ToString(selectedRow.Cells[3].Value);
                        tiTText.Enabled = false;
                        fdTPicker.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                        fdTPicker.Enabled = false;
                        temptd = Convert.ToDateTime(selectedRow.Cells[5].Value);

                        if (temptd.Year >= 9999)
                        {
                            temptd = new DateTime(9998, temptd.Month, temptd.Day);

                        }
                        tdTPicker.Value = temptd;
                        break;
                    case 5:
                        enSText.Text = Convert.ToString(selectedRow.Cells[0].Value);
                        enSText.Enabled = false;
                        salSText.Text = Convert.ToString(selectedRow.Cells[3].Value);
                        fdSPicker.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                        fdSPicker.Enabled = false;
                        temptd = Convert.ToDateTime(selectedRow.Cells[5].Value);

                        if (temptd.Year >= 9999)
                        {
                            temptd = new DateTime(9998, temptd.Month, temptd.Day);

                        }
                        tdSPicker.Value = temptd;
                        break;
                }
                
                string a = Convert.ToString(selectedRow.Cells[0].Value);
                //int index = tabControl1.SelectedIndex;
                addButtons[index].Text = "Edit";
                panels[index].Visible = true;
                tables[index].Enabled = false;

            }
            
            
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string tableName = tabControl1.SelectedTab.Name;
            this.setData(tableName);
            this.hideFields_Click(this, new EventArgs());
            if(tableName == "departments")
            {
                cancelSearch.Enabled = false;
                search.Enabled = false;
            }
            else
            {
                cancelSearch.Enabled = true;
                search.Enabled = true;
            }
            
        }

        private void search_GotFocus(object sender, EventArgs e)
        {
            if(searchBar.Text == "Search by employee number")
            {
                searchBar.Text = "";
                
            }
            searchBar.ForeColor = Color.Black;
        }

        public void search_LostFocus(object sender, EventArgs e)
        {
            if(searchBar.Text == "")
            {
                searchBar.Text = "Search by employee number";
            }
            searchBar.ForeColor = Color.DarkGray;
        }

        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                
                //search.Enabled = true;
            }
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string table = tabControl1.SelectedTab.Name;
            int searched;
            search.Enabled = false;
            cancelSearch.Enabled = true;
            try
            {
                searched = int.Parse(searchBar.Text);

            }
            catch (FormatException)
            {
                searched = 0;
            }
             
            switch (table)
            {
                case "employees":
                    ds = new DataSet();
                    ds = c.Search(table,searched);

                    employeesTable.DataSource = ds.Tables[table].DefaultView;
                    employeesTable.Columns[0].HeaderText = "Employee Number";
                    employeesTable.Columns[1].HeaderText = "First Name";
                    employeesTable.Columns[2].HeaderText = "Last Name";
                    employeesTable.Columns[3].HeaderText = "Gender";
                    employeesTable.Columns[4].HeaderText = "Birth Date";
                    employeesTable.Columns[5].HeaderText = "Hire Date";
                    if(searched == 0)
                    {
                        showingEmployees.Text = "No records found";
                    }
                    else
                    {
                        showingEmployees.Text = "Showing info of employee " + searched;
                    }
                    
                    break;
                /*case "departments":
                    ds = new DataSet();
                    ds = c.getData(table);
                    departmentsTable.DataSource = ds.Tables[table].DefaultView;
                    departmentsTable.Columns[0].HeaderText = "Department Number";
                    departmentsTable.Columns[1].HeaderText = "Department Name";
                    break;*/
                case "dept_manager":
                    ds = new DataSet();
                    ds = c.Search(table, searched);
                    deptmanagerTable.DataSource = ds.Tables[table].DefaultView;
                    deptmanagerTable.Columns[0].HeaderText = "Employee Number";
                    deptmanagerTable.Columns[1].HeaderText = "First Name";
                    deptmanagerTable.Columns[2].HeaderText = "Last Name";
                    deptmanagerTable.Columns[1].HeaderText = "Department Number";
                    deptmanagerTable.Columns[2].HeaderText = "From Date";
                    deptmanagerTable.Columns[3].HeaderText = "To Date";
                    if (searched == 0)
                    {
                        showingManagers.Text = "No records found";
                    }
                    else
                    {
                        showingManagers.Text = "Showing info of employee " + searched;
                    }
                    break;
                case "dept_emp":
                    ds = new DataSet();
                    ds = c.Search(table,searched);
                    deptempTable.DataSource = ds.Tables[table].DefaultView;
                    deptempTable.Columns[0].HeaderText = "Employee Number";
                    deptempTable.Columns[1].HeaderText = "First Name";
                    deptempTable.Columns[2].HeaderText = "Last Name";
                    deptempTable.Columns[3].HeaderText = "Department Number";
                    deptempTable.Columns[4].HeaderText = "From Date";
                    deptempTable.Columns[5].HeaderText = "To Date";
                    if (searched == 0)
                    {
                        showingDeptemp.Text = "No records found";
                    }
                    else
                    {
                        showingDeptemp.Text = "Showing current department of employee " + searched;
                    }
                    break;
                case "titles":
                    ds = new DataSet();
                    ds = c.Search(table,searched);
                    titlesTable.DataSource = ds.Tables[table].DefaultView;
                    titlesTable.Columns[0].HeaderText = "Employee Number";
                    titlesTable.Columns[1].HeaderText = "First Name";
                    titlesTable.Columns[2].HeaderText = "Last Name";
                    titlesTable.Columns[3].HeaderText = "Title";
                    titlesTable.Columns[4].HeaderText = "From Date";
                    titlesTable.Columns[5].HeaderText = "To Date";
                    if (searched == 0)
                    {
                        showingTitles.Text = "No records found";
                    }
                    else
                    {
                        showingTitles.Text = "Showing current title of employee " + searched;
                    }
                    break;
                case "salaries":
                    ds = new DataSet();
                    ds = c.Search(table,searched);
                    salariesTable.DataSource = ds.Tables[table].DefaultView;
                    salariesTable.Columns[0].HeaderText = "Employee Number";
                    salariesTable.Columns[1].HeaderText = "First Name";
                    salariesTable.Columns[2].HeaderText = "Last Name";
                    salariesTable.Columns[3].HeaderText = "Salary";
                    salariesTable.Columns[4].HeaderText = "From Date";
                    salariesTable.Columns[5].HeaderText = "To Date";
                    if (searched == 0)
                    {
                        showingSalaries.Text = "No records found";
                    }
                    else
                    {
                        showingSalaries.Text = "Showing current salary of employee " + searched;
                    }
                    break;
                    
            }
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Click(this, new EventArgs());
            }
           /* int index = tabControl1.SelectedIndex;
            if (index != 1)
            {
                search.Enabled = true;
            }*/
        }

        private void CancelSearch_Click(object sender, EventArgs e)
        {
            string tableName = tabControl1.SelectedTab.Name;
            this.setData(tableName);
            this.hideFields_Click(this, new EventArgs());
            searchBar.Text = "Search by employee number";
            //cancelSearch.Enabled = false;
            //search.Enabled = false;
            /*if (tableName == "departments")
            {
                cancelSearch.Enabled = false;
                search.Enabled = false;
            }
            else
            {
                searchBar.Text = "Search by employee number";
                searchBar.Enabled = true;
                //cancelSearch.Enabled = true;
                //search.Enabled = true;
            }*/
        }
    }
        
}
