using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void addTown_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Towns (TownsID, Town_Name) VALUES(@id, @city)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
            cmd.Parameters.AddWithValue("@city", townTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was inserted");
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void deleteTown_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Towns WHERE Town_Name = @city AND  TownsID= @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
            cmd.Parameters.AddWithValue("@city", townTextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Town deleted successfully");



        }


        private void UpdateTown_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Towns SET Town_Name = @city WHERE  TownsID= @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
            cmd.Parameters.AddWithValue("@city", townTextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Town was updated");
        }

        private void AddCountry_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Countries (CountriesID, CountryName) VALUES(@id, @Country )", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Country", textBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Country was updated");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Countries WHERE CountryName =  @Country AND  CountriesID= @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Country", textBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Country deleted successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Countries SET CountryName = @Country  WHERE  CountriesID= @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Country", textBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Country was updated");
        }
    }
}

