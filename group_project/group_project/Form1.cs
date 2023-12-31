﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Data.SqlClient;

namespace group_project
{
    public partial class Form1 : Form
    {
        private bool sortByName = false;
        public Form1()
        {
            InitializeComponent();
            MySQLConnector groupProjectConnect = new MySQLConnector();
            string query = "SELECT * FROM users";
            dataGridView1.DataSource = groupProjectConnect.ExecuteQuery(query);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Add;
        }
        public class MySQLConnector
        {
            public MySqlConnection connection;
            private string server;
            private string database;
            private string username;
            private string password;
            public MySQLConnector()
            {
                Initialize();
            }
            // Initialize the connection properties
            private void Initialize()
            {
                server = "ysjcs.net"; // Replace with your MySQL server hostname or IP address
                database = "arronyeoman"; // Replace with your MySQL database name
                username = "arron.yeoman"; // Replace with your MySQL username
                password = "B9R5WBJK"; // Replace with your MySQL password
                string connectionString = $"Server={server}; Database = {database}; Uid={username}; Pwd={password};";
                connection = new MySqlConnection(connectionString);
                Console.WriteLine("Initialised");
            }


            public bool OpenConnection()
            {
                try
                {
                    if (connection?.State != System.Data.ConnectionState.Open)
                    {
                        connection?.Open();
                        return true;
                    }
                    else
                    {
                        throw new Exception("summats fucked");
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle the exception (e.g., log it or display an error message)
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
            public bool CloseConnection()
            {
                try
                {
                    if (connection != null && connection.State !=
                    System.Data.ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                    return true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection?.Dispose(); // Dispose of the connection if it’s not null
                }
            }
            public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
            {
                DataTable dataTable = new DataTable();
                if (OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        try
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                dataTable.Load(reader);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                    CloseConnection();
                }
                return dataTable;
            }
            public void ExecuteNonQuery(string query)
            {
                if (OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                    CloseConnection();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = Remove;
        }

        private void Order_Click(object sender, EventArgs e)
        {
            if (sortByName == false)
            {
                Order.Text = "Order by Client ID";
                sortByName = true;
                //sort changing code here
            }
            else
            {
                Order.Text = "Order by Name";
                sortByName= false;
                //sort changing code here
            }
        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            if(Check_Boxes() && Check_Textboxes())
            {
                //Submit
                Result_Output_label.Text = "Success!";
            }
            else
            {
                Result_Output_label.Text = "Form Incomplete!";
            }
        }

        private bool Check_Textboxes()
        {
            if (ID_textbox.Text != null && FirstName_textbox.Text != null && LastName_textbox.Text != null &&
                Phone_textbox.Text != null && Address_textbox.Text != null && Email_textbox.Text != null)
            {
                return true;
            }
            else 
            {
             return false;
            }
        }
        private bool Check_Boxes()
        {
            if (Software_checkbox.Checked || Games_checkbox.Checked || Accessories_checkbox.Checked || Hardward_checkbox.Checked || Office_checkbox.Checked)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
    }
}

