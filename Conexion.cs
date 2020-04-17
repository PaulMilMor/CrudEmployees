﻿using MySql.Data.MySqlClient;
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

            }
            DataSet ds = new DataSet();
            //String query = "SELECT * FROM employees ORDER BY hire_date DESC LIMIT 100";
            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
                sda.Fill(ds, "employees");
                
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
            }
            
        }

        public void Insert(string tabla, Object[] row)
        {
            string query = "";
            switch (tabla)
            {
                case "employees":
                    query = "INSERT INTO employees(emp_no,first_name,last_name,gender,birth_date,hire_date)" +
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
            }

        }

        public void Delete(string table,int empno)
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
                        cmd.Parameters.AddWithValue("@en", empno);
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                    break;
            }
        }

    }
    
}
