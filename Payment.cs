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
        
        public Payment()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            searchBar.GotFocus += search_GotFocus;
            searchBar.LostFocus += search_LostFocus;

            c = new Conexion();

            ds.Dispose();
            deptnums = c.getDeptId();
            foreach(String deptno in deptnums)
            {
                deptPCombo.Items.Add(deptno);
            }

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
            row = new object[5];
            row[0] = enPText.Text;
            row[0] = sdPPicker.Value;
            row[0] = rnPText.Text;
            row[0] = atPCombo.SelectedItem.ToString();
            row[0] = bnPText.Text;
            row[0] = baPText.Text;
            row[0] = ptPCombo.SelectedIndex;

            HidePPanel_Click(this, new EventArgs());
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
            sdPPicker.Value = DateTime.Now;
            ptPCombo.SelectedIndex = -1;
            atPCombo.SelectedIndex = -1;
            paydetailsPanel.Visible = true;
        }

        private void EditDetails_Click(object sender, EventArgs e)
        {

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
            sdPPicker.Value = DateTime.Now;
            ptPCombo.SelectedIndex = -1;
            atPCombo.SelectedIndex = -1;
            paydetailsPanel.Visible = false;

        }
    }
}
