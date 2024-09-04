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

            CustomizeDataGridView();


        }

        private void CustomizeDataGridView()
        {
            // Ba�l�k ve h�cre arka plan renklerini ayarlama
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            // Ba�l�klar� kal�n ve ortalanm�� yapma
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // H�cre kenarl�klar�n� �zelle�tirme
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;

            // Sat�r se�imi rengi
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // AutoSizeColumnsMode ile s�tunlar� geni�letme
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Kullan�c� arabirimi ��eleri ekleyin
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
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

                MessageBox.Show("Bir hata olu�tu.");
            }




        }
        private async void button2_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }


        private void LoadOrders()
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "select * from orders";
                    SqlCommand command = new SqlCommand(query, connection);


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata olu�tu.");
            }




        }
        private async void button5_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers()
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "select * from orders";
                    SqlCommand command = new SqlCommand(query, connection);


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata olu�tu.");
            }




        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void LoadCategories()
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "select * from categories";
                    SqlCommand command = new SqlCommand(query, connection);


                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata olu�tu.");
            }




        }
    }
}
