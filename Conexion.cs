using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEmployees
{
    class Conexion
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public Conexion()
        {
            iniciar();
        }

        public void iniciar()
        {
            try
            {
                server = "localhost:3307";
                database = "employees";
                user = "usr217210185";
                password = "pw217210185";
                string connectionString;
                connectionString = "SERVER=" + server + ";" +
                                    "DATABASE=" + database + ";" +
                                    "UID=" + user + ";" +
                                    "PASSWORD=" + password + ";";
                // connection = new MySqlConnection(connectionString);
                connection = new MySqlConnection("SERVER=192.168.0.12; PORT=3307; DATABASE=employees; UID=usr217210185; PWD=pw217210185;");
                //connection = new MySqlConnection("SERVER=localhost; PORT=3306; DATABASE=employees; UID=usr217210185; PWD=pw217210185;");

                Console.WriteLine("Connected");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private bool OpenConnection()
        {
            try
            {
                connection = new MySqlConnection("SERVER=localhost; PORT=3307; DATABASE=employees; UID=usr217210185; PWD=pw217210185;");

                connection.Open();
                return true;
            } catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataSet getData(string table)
        {
            String query = "";
            switch (table)
            {
                case "employees":
                    query = "SELECT * FROM employees ORDER BY hire_date DESC LIMIT 100";
                    Console.WriteLine("It is 1");
                    break;
                case "departments":
                    query = "SELECT * FROM departments ORDER BY dept_no";
                    break;
                case "dept_manager":
                    query = "SELECT * FROM current_managers ORDER BY dept_no";
                    break;
                case "dept_emp":
                    query = "SELECT * FROM current_deptemp ORDER BY from_date DESC LIMIT 100";
                    break;
                case "titles":
                    query = "SELECT * FROM current_titles ORDER BY from_date DESC LIMIT 100";
                    break;
                case "salaries":
                    query = "SELECT * FROM current_salaries ORDER BY from_date DESC LIMIT 100";
                    break;
                case "bonus":
                    query = "SELECT * FROM bonus ORDER BY bonus_date DESC LIMIT 100";
                    break;
                case "deduction":
                    query = "SELECT * FROM deduction ORDER BY deduct_date DESC LIMIT 100";
                    break;
                case "holiday":
                    query = "SELECT * FROM holiday ORDER BY  start_date DESC LIMIT 100";
                    break;
                case "sickleave":
                    query = "SELECT * FROM sickleave ORDER BY start_date DESC LIMIT 100";
                    break;
                case "paydetails":
                    query = "SELECT * FROM paydetails ORDER BY start_date DESC LIMIT 100";
                    break;
                case "payhistory":
                    query = "SELECT * FROM payhistory ORDER BY pay_date DESC LIMIT 100";
                    break;

            }
            DataSet ds = new DataSet();
            //String query = "SELECT * FROM employees ORDER BY hire_date DESC LIMIT 100";
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
                    sda.Fill(ds, table);



                    sda.Dispose();
                    this.CloseConnection();
                    return ds;
                }
                else
                {
                    Console.WriteLine("Doesn¿t work");
                    return ds;
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return ds;
            }

        }

        public void Edit(string tabla, Object[] row)
        {
            string query = "";
            try
            {
                switch (tabla)
                {
                    case "employees":
                        query = "UPDATE employees SET first_name = @fn," +
                                                     "last_name = @ln," +
                                                      "gender = @gen," +
                                                      "birth_date = @bd," +
                                                      "hire_date = @hd " +
                                                      "WHERE emp_no = @en";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@fn", row[1]);
                            cmd.Parameters.AddWithValue("@ln", row[2]);
                            cmd.Parameters.AddWithValue("@gen", row[3]);
                            cmd.Parameters.Add("@bd", MySqlDbType.Date).Value = row[4];
                            cmd.Parameters.Add("@hd", MySqlDbType.Date).Value = row[5];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "departments":
                        query = "UPDATE departments SET dept_name = @dn WHERE dept_no = @dno";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@dno", row[0]);
                            cmd.Parameters.AddWithValue("@dn", row[1]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "dept_manager":
                        query = "UPDATE dept_manager SET from_date = @fd, to_date = @td WHERE emp_no = @en AND dept_no =@dno";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@dno", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.Add("@td", MySqlDbType.Date).Value = row[3];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "dept_emp":
                        query = "UPDATE dept_emp SET from_date = @fd, to_date = @td WHERE emp_no = @en AND dept_no = @dno";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@dno", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.Add("@td", MySqlDbType.Date).Value = row[3];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "titles":
                        query = "UPDATE titles SET to_date = @td WHERE emp_no = @en AND title = @ti AND from_date=@fd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@ti", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.Add("@td", MySqlDbType.Date).Value = row[3];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "salaries":
                        query = "UPDATE salaries SET salary = @sal, to_date = @td WHERE emp_no = @en AND from_date = @fd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@sal", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.Add("@td", MySqlDbType.Date).Value = row[3];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "bonus":
                        query = "UPDATE bonus SET bonus_amount = @ba, bonus_type_no = @btn WHERE emp_no = @en AND bonus_date = @bod";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@bod", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.AddWithValue("@ba", row[2]);
                            cmd.Parameters.AddWithValue("@btn", row[3]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "deduction":
                        query = "UPDATE deduction SET deduct_amount = @da, bonus_type_no = @dtn WHERE emp_no = @en AND deduct_date = @dd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@dd", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.AddWithValue("@da", row[2]);
                            cmd.Parameters.AddWithValue("@dtn", row[3]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "holiday":
                        query = "UPDATE holiday SET end_date = @ed WHERE emp_no = @en AND start_date = @sd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@sd", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.Add("@ed", MySqlDbType.Date).Value = row[2];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "sickleave":
                        query = "UPDATE sickleave SET end_date = @ed, reason = @re WHERE emp_no = @en AND start_date = @sd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@sd", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.Add("@ed", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.AddWithValue("@re", row[3]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public Boolean Insert(string tabla, Object[] row)
        {
            string query = "";
            string result = "";
            //this.CloseConnection();
            try
            {
                switch (tabla)
                {
                    case "employees":
                        query = "INSERT INTO employees(emp_no,first_name,last_name,gender,birth_date,hire_date) " +
                                "VALUES(max_emp_no()+1,@fn,@ln,@gen,@bd,@hd)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@fn", row[0]);
                            cmd.Parameters.AddWithValue("@ln", row[1]);
                            cmd.Parameters.AddWithValue("@gen", row[2]);
                            cmd.Parameters.Add("@bd", MySqlDbType.Date).Value = row[3];
                            cmd.Parameters.Add("@hd", MySqlDbType.Date).Value = row[4];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Employee registered correctly.";
                        }
                        break;
                    case "departments":
                        query = "INSERT INTO departments(dept_no, dept_name) " +
                                "VALUES(@dno,@dn)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@dno", row[0]);
                            cmd.Parameters.AddWithValue("@dn", row[1]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Department registered correctly.";
                        }
                        break;
                    case "dept_manager":
                        query = "INSERT INTO dept_manager(emp_no,dept_no,from_date,to_date) " +
                                "VALUES(@en, @dno,@fd,@td)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@dno", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.Add("@td", MySqlDbType.Date).Value = row[3];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Manager registered correctly.";
                        }
                        break;
                    case "dept_emp":
                        query = "INSERT INTO dept_emp(emp_no, dept_no, from_date, to_date)" +
                                "VALUES(@en,@dno,@fd,@td)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@dno", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.Add("@td", MySqlDbType.Date).Value = row[3];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Employee registered correctly at department.";
                        }
                        break;
                    case "titles":
                        query = "INSERT INTO titles(emp_no, title, from_date, to_date)" +
                                "VALUES(@en,@ti,@fd,@td)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@ti", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.Add("@td", MySqlDbType.Date).Value = row[3];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Title registered correctly.";
                        }
                        break;
                    case "salaries":
                        query = "INSERT INTO salaries(emp_no, salary, from_date, to_date)" +
                                "VALUES(@en,@sal,@fd,@td)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@sal", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.Add("@td", MySqlDbType.Date).Value = row[3];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Salary registered correctly.";
                        }
                        break;
                    case "bonus":
                        query = "INSERT INTO bonus(emp_no, bonus_date, bonus_amount, bonus_type_no)" +
                                "VALUES(@en,@bod,@ba,@btn)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@bod", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.AddWithValue("@ba", row[2]);
                            cmd.Parameters.AddWithValue("@btn", row[3]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Bonus registered correctly.";
                        }
                        break;
                    case "deduction":
                        query = "INSERT INTO deduction(emp_no, deduct_date, deduct_amount, deduct_type_no)" +
                                "VALUES(@en,@dd,@da,@dtn)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@dd", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.AddWithValue("@da", row[2]);
                            cmd.Parameters.AddWithValue("@dtn", row[3]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Deduction registered correctly.";
                        }
                        break;
                    case "holiday":
                        query = "INSERT INTO holiday(emp_no, start_date, end_date)" +
                                "VALUES(@en,@sd,@ed)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@sd", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.Add("@ed", MySqlDbType.Date).Value = row[2];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Holiday registered correctly.";
                        }
                        break;
                    case "sickleave":
                        query = "INSERT INTO sickleave(emp_no, start_date, end_date, reason)" +
                                "VALUES(@en,@sd,@ed,@re)";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@sd", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.Add("@ed", MySqlDbType.Date).Value = row[2];
                            cmd.Parameters.AddWithValue("@re", row[3]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Sick Leave registered correctly.";
                        }
                        break;
                    case "paydetails":
                        query = "INSERT INTO paydetails(emp_no, start_date, routing_number, account_type, bank_name, bank_address,pay_type_no) " +
                            "VALUES(@en,@sd,@rn,@at,@bn,@ba,@ptn)";
                        if(this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@sd", MySqlDbType.Date).Value = row[1];
                            cmd.Parameters.AddWithValue("@rn", row[2]);
                            cmd.Parameters.AddWithValue("@at", row[3]);
                            cmd.Parameters.AddWithValue("@bn", row[4]);
                            cmd.Parameters.AddWithValue("@ba", row[5]);
                            cmd.Parameters.AddWithValue("@ptn", row[6]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                            result = "Pay Details registered correctly.";
                        }
                        break;

                }
                MessageBox.Show(result);
                return true;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
                //MessageBox.Show("There's something wrong with your data.");
            }


        }

        public void Delete(string table, Object[] row)
        {
            string query = "";
            try
            {
                switch (table)
                {
                    case "employees":
                        query = "DELETE FROM employees WHERE emp_no = @en";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "departments":
                        query = "DELETE FROM departments WHERE dept_no = @dno";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@dno", row[0]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "dept_manager":
                        query = "DELETE FROM dept_manager WHERE emp_no = @en AND dept_no = @dno";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@dno", row[1]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "dept_emp":
                        query = "DELETE FROM dept_emp WHERE emp_no = @en AND dept_no = @dno";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@dno", row[1]);
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "titles":
                        query = "DELETE FROM titles WHERE emp_no =@en AND title = @ti AND from_date=@fd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.AddWithValue("@ti", row[1]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "salaries":
                        query = "DELETE FROM salaries WHERE emp_no = @en AND from_date = @fd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[1];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "bonus":
                        query = "DELETE FROM bonus WHERE emp_no = @en AND bonus_date = @bod";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@bod", MySqlDbType.Date).Value = row[1];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "deduction":
                        query = "DELETE FROM deduction WHERE emp_no = @en AND deduct_date = @dd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@dd", MySqlDbType.Date).Value = row[1];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "holiday":
                        query = "DELETE FROM holiday WHERE emp_no = @en AND start_date = @sd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@sd", MySqlDbType.Date).Value = row[1];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                    case "sickleave":
                        query = "DELETE FROM sickleave WHERE emp_no = @en AND start_date = @sd";
                        if (this.OpenConnection() == true)
                        {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@en", row[0]);
                            cmd.Parameters.Add("@sd", MySqlDbType.Date).Value = row[1];
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            this.CloseConnection();
                        }
                        break;
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }

        }

        public DataSet Search(string table, int searched)
        {
            String query = "";

            switch (table)
            {
                case "employees":
                    query = "SELECT * FROM employees WHERE emp_no =" + searched;
                    Console.WriteLine("It is 1");
                    break;
                /*case "departments":
                    query = "SELECT * FROM departments ORDER BY dept_no";
                    break;*/
                case "dept_manager":
                    query = "SELECT * FROM current_managers WHERE emp_no=" + searched;
                    break;
                case "dept_emp":
                    query = "SELECT * FROM current_deptemp WHERE emp_no=" + searched;
                    break;
                case "titles":
                    query = "SELECT * FROM current_titles WHERE emp_no=" + searched;
                    break;
                case "salaries":
                    query = "SELECT * FROM current_salaries WHERE emp_no=" + searched;
                    break;
                case "bonus":
                    query = "SELECT * FROM bonus WHERE emp_no=" + searched;
                    break;
                case "deduction":
                    query = "SELECT * FROM deduction WHERE emp_no=" + searched;
                    break;
                case "holiday":
                    query = "SELECT * FROM holiday WHERE emp_no=" + searched;
                    break;
                case "sickleave":
                    query = "SELECT * FROM sickleave WHERE emp_no=" + searched;
                    break;
            }
            DataSet ds = new DataSet();
            //String query = "SELECT * FROM employees ORDER BY hire_date DESC LIMIT 100";
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
                    sda.Fill(ds, table);



                    sda.Dispose();
                    this.CloseConnection();
                    return ds;
                }
                else
                {
                    Console.WriteLine("Doesn¿t work");
                    return ds;
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return ds;
            }

        }


        public List<String> getDeptId()
        {
            List<String> deptid = new List<string>();
            String query = "SELECT DISTINCT dept_no FROM departments ORDER BY dept_no";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    deptid.Add((string)dataReader["dept_no"]);
                }
                dataReader.Close();
                this.CloseConnection();
                return deptid;
            }
            else
            {
                return deptid;
            }


        }
        public List<String> getBonusType()
        {
            List<String> bonustype = new List<string>();
            String query = "SELECT DISTINCT bonus_description FROM bonustype ORDER BY bonus_type_no";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    bonustype.Add((string)dataReader["bonus_description"]);
                }
                dataReader.Close();
                this.CloseConnection();
                return bonustype;
            }
            else
            {
                return bonustype;
            }


        }
        public List<String> getDeductType()
        {
            List<String> deducttype = new List<string>();
            String query = "SELECT DISTINCT deduct_description FROM deducttype ORDER BY deduct_type_no";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    deducttype.Add((string)dataReader["deduct_description"]);
                }
                dataReader.Close();
                this.CloseConnection();
                return deducttype;
            }
            else
            {
                return deducttype;
            }


        }

        public List<String> getPayType()
        {
            List<String> paytype = new List<string>();
            String query = "SELECT DISTINCT pay_type_description FROM paytype ORDER BY pay_type_no";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    paytype.Add((string)dataReader["pay_type_description"]);
                }
                dataReader.Close();
                this.CloseConnection();
                return paytype;
            }
            else
            {
                return paytype;
            }


        }

        public void getBonus()
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "get_current_bonus";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("selectedemp",500000));
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("THESE ARE THE BONUSES" + (string)dataReader["currentbonus"]);
                }
                dataReader.Close();
                this.CloseConnection();
            }
        }

        public DataSet getPayroll(string deptno)
        {
            DataSet ds = new DataSet();
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "get_payroll_details";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("deptno", deptno));
                MySqlDataAdapter sda = new MySqlDataAdapter();
                
                sda.SelectCommand = cmd;
                sda.Fill(ds);



                sda.Dispose();
                this.CloseConnection();
                return ds;

            }
            return ds;
        }



    }
    
}
