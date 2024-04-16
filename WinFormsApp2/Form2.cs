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
    public partial class Form2 : Form
    {
        public Form2(string a)
        {
            InitializeComponent();
            if (a == "admin")
            {
                adminButton.Visible = true;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC14\SQLEXPRESS;Initial Catalog=Countries2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CountriesID,CountryName from Countries", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable countriestable = new DataTable();
            adapter.Fill(countriestable);

            countryComboBox.DataSource = countriestable;
            countryComboBox.DisplayMember = "CountryName";
            countryComboBox.ValueMember = "CountriesID";





            cmd = new SqlCommand("Select TownsID,Town_Name from Towns", con);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable townsTable = new DataTable();
            adapter.Fill(townsTable);

            townComboBox.DataSource = townsTable;
            townComboBox.DisplayMember = "Town_Name";
            townComboBox.ValueMember = "TownsID";






        }






        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Form3 Form = new Form3();
            Form.Show();
            this.Hide();
        }
    }
}
