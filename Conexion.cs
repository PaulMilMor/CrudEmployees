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
                connection = new MySqlConnection("SERVER=localhost; PORT=3307; DATABASE=employees; UID=usr217210185; PWD=pw217210185;");

                Console.WriteLine("Connected");
            }
            catch (MySqlException)
            {
                Console.WriteLine("Not Connected");
            }
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            } catch(MySqlException ex)
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
            catch (MySqlException ex)
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

            }
            DataSet ds = new DataSet();
            //String query = "SELECT * FROM employees ORDER BY hire_date DESC LIMIT 100";
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
        }

        public void Edit(string tabla, Object[] row)
        {
            string query = "";
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
                        cmd.Parameters.AddWithValue("@gen",row[3]);
                        cmd.Parameters.Add("@bd", MySqlDbType.Date).Value = row[4];
                        cmd.Parameters.Add("@hd", MySqlDbType.Date).Value = row[5];
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                    break;
                case "departments":
                    query = "UPDATE departments SET dept_name = @dn WHERE dept_no = @dno";
                    if(this.OpenConnection() == true)
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
                        cmd.Parameters.Add("@td",MySqlDbType.Date).Value = row[3];
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                    break;
                case "salaries":
                    query = "UPDATE salaries SET salary = @sal, to_date = @td WHERE emp_no = @en AND from_date = @fd";
                    if(this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@en", row[0]);
                        cmd.Parameters.AddWithValue("@sal", row[1]);
                        cmd.Parameters.Add("@fd", MySqlDbType.Date).Value = row[2];
                        cmd.Parameters.Add("@ld", MySqlDbType.Date).Value = row[3];
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                    break;
            }
            
        }

        public void Insert(string tabla, Object[] row)
        {
            string query = "";
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
                    }
                    break;
                case "departments":
                    query = "INSERT INTO departments(dept_no, dept_name) " +
                            "VALUES(@dno,@dn)";
                    if(this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@dno", row[0]);
                        cmd.Parameters.AddWithValue("@dn", row[1]);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
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
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
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
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
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
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
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
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                    break;

            }

        }

        public void Delete(string table,Object[] row)
        {
            string query = "";
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
                    if(this.OpenConnection() == true)
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
            }
        }

    }
    
}
