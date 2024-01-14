using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySqlX.XDevAPI;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Cms;

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
                database = "jaymenecola_"; // Replace with your MySQL database name
                username = "jay.menecola"; // Replace with your MySQL username
                password = "YSYUVJY3"; // Replace with your MySQL password
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
            public void InsertIntoDatabase(string clientID, string firstName, string lastName, string phoneNumber, string email, string address)
            {
                if (OpenConnection())
                {
                    string query = "INSERT INTO users (ClientID, FirstName, LastName, PhoneNumber, Email, Address) " +
                        "VALUES (@clientID, @FirstName, @LastName, @PhoneNumber, @Email, @Address)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (Int32.TryParse(clientID, out int clientIDInt))
                        {
                            cmd.Parameters.AddWithValue("@ClientID", clientIDInt);
                        }
                        try
                        {
                            MailAddress emailInput = new MailAddress(email);
                            cmd.Parameters.AddWithValue("@Email", email);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Invalid email address format. Please try again.");
                        }


                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Address", address);
                        
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully!");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not Connected to the Database");
                }
            }   

            public void SearchDatabase(string search, DataGridView dataGridView2)
            {
                if (OpenConnection())
                {
                    string query = "SELECT * FROM users WHERE ClientID = @search";
                    MySqlParameter[] parameters = { new MySqlParameter("@search", MySqlDbType.Int32) { Value = int.Parse(search) } };
                    MySQLConnector groupProjectConnect = new MySQLConnector();
                    DataTable resultTable = groupProjectConnect.ExecuteQuery(query, parameters);
                    dataGridView2.DataSource = resultTable;
                    
                }
                else
                {
                    MessageBox.Show("Not Connected to the Database");
                }
            }

            public void DeleteSearchResult(string search)
            {
                if (OpenConnection())
                {
                    string query = "DELETE FROM users WHERE ClientID = @search";
                    MySqlParameter[] parameters = { new MySqlParameter("@search", MySqlDbType.Int32) { Value = int.Parse(search) } };
                    MySQLConnector groupProjectConnect = new MySQLConnector();
                    groupProjectConnect.ExecuteQuery(query, parameters);

                }
            }

            public void SaveToCSV(string fileName)
            {
                if (OpenConnection())
                {
                    string query = "SELECT * FROM users";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection)) 
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();

                            for(int i = 0; i < reader.FieldCount; i++)
                            {
                                sb.Append(reader.GetName(i));
                                sb.Append(i == reader.FieldCount - 1 ? "\n" : ",");
                            }
                            // rows
                            while (reader.Read())
                            {
                                for(int i = 0; i < reader.FieldCount; i++)
                                {
                                    sb.Append(reader[i]);
                                    sb.Append(i == reader.FieldCount - 1 ? "\n" : ","); 
                                }
                            }

                            File.WriteAllText(fileName, sb.ToString());
                        }    
                    }
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
                MySQLConnector database = new MySQLConnector();
                string query = "SELECT * FROM users ORDER BY FirstName";
                dataGridView1.DataSource = database.ExecuteQuery(query);

            }
            else
            {
                Order.Text = "Order by Name";
                sortByName= false;
                MySQLConnector database = new MySQLConnector();
                string query = "SELECT * FROM users ORDER BY ClientID";
                dataGridView1.DataSource = database.ExecuteQuery(query);
            }
        }
       
        private void Submit_Click_1(object sender, EventArgs e)
        {
            //performs a check to see if all fields have been populated
            if(Check_Boxes() && Check_Textboxes())
            {
                //store all entered data as strings
                string clientID = ID_textbox.Text;
                string firstName = FirstName_textbox.Text;
                string lastName = LastName_textbox.Text;
                string phoneNumber = Phone_textbox.Text;
                string email = Email_textbox.Text;
                string address = Address_textbox.Text;

                //submit to the database
                MySQLConnector database = new MySQLConnector();
                database.InsertIntoDatabase(clientID, firstName, lastName, phoneNumber, email, address);
                //empty all text-boxes
                ID_textbox.Text = FirstName_textbox.Text = LastName_textbox.Text = Phone_textbox.Text = Email_textbox.Text = Address_textbox.Text = "";
                Result_Output_label.Text = "Success!";
            }
            else
            {
                Result_Output_label.Text = "Form Incomplete!";
            }
        }
        private void printSearch_Click(object sender, EventArgs e)
        {
            int parsedVal;
            if (!int.TryParse(clientSearch.Text, out parsedVal))
            {
                MessageBox.Show("This is a number only field. Please try again.");
                return;
            }
            if (clientSearch.Text != "")
            {
                string search = clientSearch.Text;
                MySQLConnector database = new MySQLConnector();
                database.SearchDatabase(search, dataGridView2);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            MySQLConnector groupProjectConnect = new MySQLConnector();
            string query = "SELECT * FROM users";
            dataGridView1.DataSource = groupProjectConnect.ExecuteQuery(query);
        }

        private void cancelSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            clientSearch.Text = null;
        }

        private void deleteSearch_Click(object sender, EventArgs e)
        {
            string search = clientSearch.Text;
            MySQLConnector database = new MySQLConnector();
            database.DeleteSearchResult(search);
            dataGridView2.DataSource = null;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save CSV File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                MySQLConnector database = new MySQLConnector();
                database.SaveToCSV(saveFileDialog1.FileName);
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

