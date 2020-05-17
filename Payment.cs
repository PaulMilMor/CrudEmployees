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
        List<String> deptnames;
        List<String> paytype;
        List<string> paytypeno;

        public Payment()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
            c = new Conexion();

            c.updatePaydetails();
            //ds.Dispose();
            deptnames = c.getNames("departments");
            deptPCombo.Items.Clear();
            foreach (String deptno in deptnames)
            {
                deptPCombo.Items.Add(deptno);
            }
            paytypeno = c.getAllids("paytype");
            paytype = c.getNames("paytype");
            ptPCombo.Items.Clear();
            foreach (String type in paytype)
            {
                ptPCombo.Items.Add(type);
            }
            sdPPicker.Value = new DateTime(sdPPicker.Value.Year, sdPPicker.Value.Month, 1);
            sdPPicker.Enabled = false;

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
            row[6] = int.Parse(c.getID("paytype", ptPCombo.SelectedItem.ToString()));
            //row[6] = ptPCombo.SelectedIndex + 2001;
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
            row[6] = int.Parse(c.getID("paytype", ptPCombo.SelectedItem.ToString()));
            //row[6] = ptPCombo.SelectedIndex + 2001;
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
                int ptIndex = paytypeno.IndexOf(ds.Tables[0].Rows[0][8].ToString());
                ptPCombo.SelectedIndex = ptPCombo.Items.IndexOf(paytype[ptIndex]);

                //ptPCombo.SelectedIndex = 
                ptPCombo.SelectedIndex = int.Parse(ds.Tables[0].Rows[0][8].ToString())-2001;
                paydetailsPanel.Visible = true;
                addPDetail.Text = "Edit";
            }
        }


        

        private void numText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                //search.Enabled = true;
            }
            
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
            DialogResult dialogResult = MessageBox.Show("If you go back to CRUD any unsaved changes will be lost. Continue?", "Return to CRUD", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var Tables = new Tables();
                Tables.Shown += (o, args) => { this.Hide(); };
                Tables.Show();
            }
                
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
            Cursor.Current = Cursors.WaitCursor;
            ds = new DataSet();
            ds = c.getPayroll(c.getID("departments",deptPCombo.SelectedItem.ToString()));
            paymentTable.DataSource = ds.Tables[0];
            paymentTable.Refresh();
            paymentTable.Columns[0].HeaderText = "Employee Number";
            paymentTable.Columns[1].HeaderText = "First Name";
            paymentTable.Columns[2].HeaderText = "Last Name";
            paymentTable.Columns[3].HeaderText = "Monthly Salary";
            paymentTable.Columns[4].HeaderText = "Total Bonus";
            paymentTable.Columns[5].HeaderText = "Total Deductions";
            if (paymentTable.Columns.Count < 7)
            {
                paymentTable.Columns.Add("Column", "Net Salary");

            }
            for (int i = 0; i < paymentTable.Rows.Count; i++)
            {
               
                double salary = double.Parse(paymentTable[3, i].Value.ToString());
                string tbonus = paymentTable[4, i].Value.ToString();
                string tdeduct = paymentTable[5, i].Value.ToString();
                if (string.IsNullOrEmpty(tbonus))
                {
                    paymentTable[4, i].Value = 0;
                    tbonus = "0";

                }
                if (string.IsNullOrEmpty(tdeduct))
                {
                    paymentTable[5, i].Value = 0;
                    tdeduct = "0";
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
                loadDepartment.Enabled = false;
            }
            else
            {
                loadDepartment.Enabled = true;
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discharge this employee from payroll?", "Delete", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Object[] row;
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
                    row = new object[2];
                    row[0] = ds.Tables[0].Rows[0][0];
                    row[1] = ds.Tables[0].Rows[0][3];
                    c.Delete("paydetails", row);
                    this.LoadEmployees_Click(this, new EventArgs());
                    paymentTable.Refresh();
                }
            }
        }

        private void RegisterPayment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to register this month payment?", "Confirm Payment", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                if (paymentTable.Rows.Count > 0)
                {
                    for (int i = 0; i < paymentTable.Rows.Count; i++)
                    {
                        int empno = Convert.ToInt32(paymentTable.Rows[i].Cells[0].Value);
                        double payamount = Convert.ToDouble(paymentTable.Rows[i].Cells[6].Value);
                        c.insertPayment(empno, payamount);
                    }
                    MessageBox.Show("Payment registered successfully.");
                }
                Cursor.Current = Cursors.Arrow;
            }
                
        }
    }
}
