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
    public partial class Form1 : Form
    {
        Conexion c = null;
        DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
            //Datos del Form y tamaños
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            employeesTable.Width = this.Width - this.Width/28;
            employeesTable.Height = this.Height / 3;
            employeesTable.Location = new Point(this.Width/56,this.Height*2/5);

            //Datos del Panel de datos
            panel1.Visible = false;
            panel1.Width = this.Width - this.Width / 27;
            panel1.Height = this.Height / 5;
            panel1.Location = new Point(this.Width / 54, this.Height / 5);
            firstName.Width = panel1.Width / 7;
            lastName.Width = panel1.Width / 7;
            gender.Width = panel1.Width / 7;
            birthDate.Width = panel1.Width / 7;
            hireDate.Width = panel1.Width / 7;
            addRecord.Width = panel1.Width / 7;
            addRecord.Height = panel1.Height / 3;
            hideFields.Height = panel1.Height / 3;
            hideFields.Width = panel1.Width / 7;
            label1.Location = new Point(panel1.Width / 49, 0);
            firstName.Location = new Point(panel1.Width / 49, label1.Height*16/3);
            label2.Location = new Point(panel1.Width *9/ 49, 0 );
            lastName.Location = new Point(panel1.Width *9/ 49, label2.Height * 16 / 3);
            label3.Location = new Point(panel1.Width *17/ 49, 0);
            gender.Location = new Point(panel1.Width*17 / 49, label3.Height * 16 / 3);
            label4.Location = new Point(panel1.Width *25/ 49, 0);
            birthDate.Location = new Point(panel1.Width *25/ 49, label4.Height * 16 / 3);
            label5.Location = new Point(panel1.Width *33/ 49, 0);
            hireDate.Location = new Point(panel1.Width *33/ 49, label5.Height * 16 / 3);
            addRecord.Location = new Point(panel1.Width * 41 / 49, 0);
            hideFields.Location = new Point(panel1.Width * 41 / 49, label5.Height * 16 / 3);

            //Datos del segundo panel
            panel2.Width = this.Width - this.Width / 27;
            panel2.Height = this.Height / 5;
            panel2.Location = new Point(this.Width / 54, this.Height*4 / 5);
            showFields.Height = panel2.Height / 3;
            showFields.Width = panel2.Width / 7;
            deleteRecord.Height = panel2.Height / 3;
            deleteRecord.Width = panel2.Width / 7;
            editRecord.Height = panel2.Height / 3;
            editRecord.Width = panel2.Width / 7;
            showFields.Location = new Point(this.Width / 2 - showFields.Width / 2, 0);
            deleteRecord.Location = new Point(this.Width / 2 - showFields.Width -deleteRecord.Width, 0);
            editRecord.Location = new Point(this.Width / 2 + showFields.Width , 0);


            c = new Conexion(); 
            ds = new DataSet();
            ds = c.getData("employees");
            
            employeesTable.DataSource = ds.Tables["employees"].DefaultView;
            employeesTable.Columns[0].HeaderText = "Number";
            employeesTable.Columns[1].HeaderText = "First Name";
            employeesTable.Columns[2].HeaderText = "Last Name";
            employeesTable.Columns[3].HeaderText = "Gender";
            employeesTable.Columns[4].HeaderText = "Birth Date";
            employeesTable.Columns[5].HeaderText = "Hire Date";

            ds.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showFields_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void hideFields_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            firstName.Text = "";
            lastName.Text = "";
            gender.SelectedIndex = -1;
            birthDate.Value = DateTime.Now;
            hireDate.Value = DateTime.Now;
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            if (addRecord.Text.Equals("Add"))
            {
                Object[] row = new object[5];


                row[0] = firstName.Text;
                row[1] = lastName.Text;
                row[2] = gender.SelectedItem.ToString();
                row[3] = birthDate.Value;
                row[4] = hireDate.Value;
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
                firstName.Text = "";
                lastName.Text = "";
                gender.SelectedIndex = -1;
                birthDate.Value = DateTime.Now;
                hireDate.Value = DateTime.Now;
            }
            else
            {
                if (employeesTable.SelectedCells.Count > 0)
                {
                    Object[] row = new object[6];
                    int selectedrowindex = employeesTable.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = employeesTable.Rows[selectedrowindex];
                    row[0] = Convert.ToInt32(selectedRow.Cells[0].Value);

                    row[1] = firstName.Text;
                    row[2] = lastName.Text;
                    row[3] = gender.SelectedItem.ToString();
                    row[4] = birthDate.Value;
                    row[5] = hireDate.Value;
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
                    firstName.Text = "";
                    lastName.Text = "";
                    gender.SelectedIndex = -1;
                    birthDate.Value = DateTime.Now;
                    hireDate.Value = DateTime.Now;
                }
                    
            }

            addRecord.Text = "Add";
            panel1.Visible = false;
            
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
                            firstName.Text = Convert.ToString(selectedRow.Cells[i].Value);
                            break;

                        case 2:
                            lastName.Text = Convert.ToString(selectedRow.Cells[i].Value);
                            break;

                        case 3:
                            string selectedgender = Convert.ToString(selectedRow.Cells[i].Value);
                            if (selectedgender.Equals("M"))
                            {
                                gender.SelectedIndex = 0;
                            }
                            else
                            {
                                gender.SelectedIndex = 1;
                            }

                            break;

                        case 4:
                            birthDate.Value = Convert.ToDateTime(selectedRow.Cells[i].Value);
                            break;

                        case 5:
                            hireDate.Value = Convert.ToDateTime(selectedRow.Cells[i].Value);
                            break;


                    }
                    
                }
                string a = Convert.ToString(selectedRow.Cells[0].Value);

            }
            addRecord.Text = "Edit";
            panel1.Visible = true;
            
        }
    }
}
