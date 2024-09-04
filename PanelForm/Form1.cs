using Entities.Concrete;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using static System.Net.WebRequestMethods;

namespace PanelForm
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString = @"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=true";

        public Form1()
        {
            InitializeComponent();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }


        private void LoadProducts()
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "select * from products";
                    SqlCommand command = new SqlCommand(query, connection);


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluþtu.");
            }




        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
