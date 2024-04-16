using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void addTown_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = passwordBox2.Text;
            string username = usernameBox1.Text;
            string pass;
            string data;
            string connectionString = @"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT password1, date1 from LoginInfo where Username = @username", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    if (resultTable.Rows.Count > 0)
                    {
                        pass = (string)resultTable.Rows[0]["password1"];
                        data = (string)resultTable.Rows[0]["date1"];
                        string salt = "";
                        string salt1;
                        salt = DateTime.Now.ToString();
                        salt1 = salt;
                        string hashedpass = hashpassword($"{password}{data}");
                        if (username == "Dessi")
                        {
                            Form2 adminForm = new Form2("admin");
                            adminForm.Show();
                            this.Hide();

                        }
                        else if (pass == hashedpass)
                        {
                            Form2 userForm = new Form2("user");
                            userForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such user!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");

                }



            }

            }
        public void AdminMeet(string username, string password)
        {

            if (username == "admin" && password == "admin")
            {

                Form2 adminForm = new Form2("admin");
                adminForm.Show();
                this.Hide();
            }
            else if (username == "user" && password == "user")
            {

                Form2 userForm = new Form2("user");
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }


        private void usernameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

            string password1 = passwordBox2.Text;
            string password2 = passwordBox3.Text;
            
            string passwordPattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";
            if (Regex.IsMatch(password1, passwordPattern) && password1.Equals(password2))
            {
                MessageBox.Show("Valid");
                string salt = "";
                string salt1;
                salt = DateTime.Now.ToString();
                salt1 = salt;
                string password = passwordBox3.Text;
                string hashedpass = hashpassword($"{password}{salt}");
                MessageBox.Show(hashedpass);
                using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO LoginInfo (username, date1, password1) VALUES (@username, @salt, @hashedPassword)",con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@username", usernameBox1.Text);
                        cmd.Parameters.AddWithValue("@hashedPassword", hashedpass);
                        cmd.Parameters.AddWithValue("@salt", salt);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Added to the Database");

                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid");
            }
           

        }
        string hashpassword(string text)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(text);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
