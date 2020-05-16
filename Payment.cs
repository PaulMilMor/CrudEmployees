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
        List<String> deptnums;
        List<String> paytype;

        public Payment()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            searchBar.GotFocus += search_GotFocus;
            searchBar.LostFocus += search_LostFocus;

            c = new Conexion();

            c.updatePaydetails();
            //ds.Dispose();
            deptnums = c.getDeptId();
            deptPCombo.Items.Clear();
            foreach (String deptno in deptnums)
            {
                deptPCombo.Items.Add(deptno);
            }
            paytype = c.getPayType();
            ptPCombo.Items.Clear();
            foreach (String type in paytype)
            {
                ptPCombo.Items.Add(type);
            }
            sdPPicker.Value = new DateTime(sdPPicker.Value.Year, sdPPicker.Value.Month, 1);
            sdPPicker.Enabled = false;

        }

        private void setData()
        {
            ds = new DataSet();
            ds = c.getData("payment");
            paymentTable.DataSource = ds.Tables["paydetails"];
            paymentTable.Columns[0].HeaderText = "Employee Number";
            paymentTable.Columns[1].HeaderText = "First Name";
            paymentTable.Columns[2].HeaderText = "Last Name";
            paymentTable.Columns[3].HeaderText = "Monthly Salary";
            paymentTable.Columns[4].HeaderText = "Total Bonus";
            paymentTable.Columns[5].HeaderText = "Total Deductions";
            paymentTable.Columns[6].HeaderText = "Net Salary";

        }

        private void InsertData()
        {
            Object[] row;
            row = new object[7];
            row[0] = enPText.Text;
            row[1] = sdPPicker.Value;
            row[2] = rnPText.Text;
            row[3] = atPCombo.SelectedItem.ToString();
            row[4] = bnPText.Text;
            row[5] = baPText.Text;
            row[6] = ptPCombo.SelectedIndex + 2001;
            if (c.Insert("paydetails", row))
            {
                HidePPanel_Click(this, new EventArgs());
            }

            /*ds = new DataSet();
            ds = c.getData("paydetails");*/



        }
        private void EditData()
        {
            Object[] row;
            row = new object[7];
            row[0] = enPText.Text;
            row[1] = sdPPicker.Value;
            row[2] = rnPText.Text;
            row[3] = atPCombo.SelectedItem.ToString();
            row[4] = bnPText.Text;
            row[5] = baPText.Text;
            row[6] = ptPCombo.SelectedIndex + 2001;
            if (c.Edit("paydetails", row))
            {
                HidePPanel_Click(this, new EventArgs());
            }
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShowFields_Click(object sender, EventArgs e)
        {
            addPDetail.Text = "Add";
            enPText.Text = "";
            rnPText.Text = "";
            bnPText.Text = "";
            baPText.Text = "";
            sdPPicker.Value = new DateTime(sdPPicker.Value.Year, sdPPicker.Value.Month, 1);
            ptPCombo.SelectedIndex = -1;
            atPCombo.SelectedIndex = -1;
            paydetailsPanel.Visible = true;
        }

        private void EditDetails_Click(object sender, EventArgs e)
        {
            if (paymentTable.SelectedCells.Count > 0)
            {
                int searched;
                int selectedrowindex = paymentTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = paymentTable.Rows[selectedrowindex];
                String empno = Convert.ToString(selectedRow.Cells[0].Value);
                try
                {
                    searched = int.Parse(empno);

                }
                catch (FormatException)
                {
                    searched = 0;
                }
                ds = new DataSet();
                ds = c.Search("onepaydetails", searched);
                enPText.Text = ds.Tables[0].Rows[0][0].ToString();
                enPText.Enabled = false;
                sdPPicker.Value = DateTime.Parse(ds.Tables[0].Rows[0][3].ToString());
                rnPText.Text = ds.Tables[0].Rows[0][4].ToString();
                atPCombo.SelectedIndex = atPCombo.Items.IndexOf(ds.Tables[0].Rows[0][5].ToString());
                bnPText.Text = ds.Tables[0].Rows[0][6].ToString();
                baPText.Text = ds.Tables[0].Rows[0][7].ToString();
                ptPCombo.SelectedIndex = int.Parse(ds.Tables[0].Rows[0][8].ToString())-2001;
                paydetailsPanel.Visible = true;
                addPDetail.Text = "Edit";
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
        private void search_LostFocus(object sender, EventArgs e)
        {
            if(searchBar.Text == "")
            {
                searchBar.Text = "Search by employee number";

            }
            searchBar.ForeColor = Color.DarkGray;
        }

        private void numText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                //search.Enabled = true;
            }
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string table = "payment";
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
            ds = new DataSet();
            ds = c.getData(table);
            paymentTable.DataSource = ds.Tables[table];
            paymentTable.Columns[0].HeaderText = "Employee Number";
            paymentTable.Columns[1].HeaderText = "First Name";
            paymentTable.Columns[2].HeaderText = "Last Name";
            paymentTable.Columns[3].HeaderText = "Monthly Salary";
            paymentTable.Columns[4].HeaderText = "Total Bonus";
            paymentTable.Columns[5].HeaderText = "Total Deductions";
            paymentTable.Columns[6].HeaderText = "Net Salary";


        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Search_Click(this, new EventArgs());
            }
        }

        private void CancelSearch_Click(object sender, EventArgs e)
        {

            this.HidePPanel_Click(this, new EventArgs());
            searchBar.Text = "Search by employee number";

        }

        private void HidePPanel_Click(object sender, EventArgs e)
        {
            addPDetail.Text = "Add";
            enPText.Text = "";
            rnPText.Text = "";
            bnPText.Text = "";
            baPText.Text = "";
            sdPPicker.Value = new DateTime(sdPPicker.Value.Year, sdPPicker.Value.Month, 1);
            ptPCombo.SelectedIndex = -1;
            atPCombo.SelectedIndex = -1;
            paydetailsPanel.Visible = false;

        }

        private void OpenCrud_Click(object sender, EventArgs e)
        {
            var Tables = new Tables();
            Tables.Shown += (o, args) => { this.Hide(); };
            Tables.Show();
        }

        private void AddPDetail_Click(object sender, EventArgs e)
        {
            Boolean validateEmpty = true;
            Boolean validateRouting = true;
            validateEmpty = string.IsNullOrWhiteSpace(enPText.Text)
                        || string.IsNullOrWhiteSpace(rnPText.Text)
                        || string.IsNullOrWhiteSpace(bnPText.Text)
                        || string.IsNullOrWhiteSpace(baPText.Text)
                        || atPCombo.SelectedIndex == -1
                        || ptPCombo.SelectedIndex == -1;
            validateRouting = rnPText.Text.Length !=9;
            if (validateEmpty)
            {
                MessageBox.Show("Fill all the fields");
            } else if (validateRouting)
            {
                MessageBox.Show("Routing number must be exactly 9 characters");
            }
            else
            {
                if (addPDetail.Text.Equals("Add"))
                {
                    this.InsertData();
                }
                else
                {
                    this.EditData();
                    addPDetail.Text = "Add";
                    this.HidePPanel_Click(this, new EventArgs());
                }
                validateEmpty = true;
            }
        }

        private void LoadEmployees_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds = c.getPayroll(deptPCombo.SelectedItem.ToString());
            paymentTable.DataSource = ds.Tables[0];
            paymentTable.Columns.Add("Column", "Net Salary");
            for (int i = 0; i < paymentTable.Rows.Count; i++)
            {
                //MessageBox.Show(paymentTable[3,i].Value.ToString());
                double salary = double.Parse(paymentTable[3, i].Value.ToString());
                string tbonus = paymentTable[4, i].Value.ToString();
                string tdeduct = paymentTable[5, i].Value.ToString();
                if (string.IsNullOrEmpty(tbonus))
                {
                    paymentTable[4, i].Value = 0;
                } else if (string.IsNullOrEmpty(tdeduct))
                {
                    paymentTable[5, i].Value = 0;
                }
                double doublebonus = double.Parse(tbonus);
                double doublededuct = double.Parse(tdeduct);
                paymentTable[6, i].Value = salary + doublebonus - doublededuct;
            }
        }

        private void DeptPCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(deptPCombo.SelectedIndex == -1)
            {
                loadEmployees.Enabled = false;
            }
            else
            {
                loadEmployees.Enabled = true;
            }
        }
    }
}
