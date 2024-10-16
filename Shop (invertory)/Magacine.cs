using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop__invertory_
{
    public partial class Magacine : Form
    {
        public Magacine()
        {
            InitializeComponent();
        }

        string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=shopInvertoryDB;Integrated Security=True;";

        private void Magacine_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string sql = "SELECT * from products";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void PerformSearch(string searchText)
        {
            string query = "SELECT * from products WHERE name LIKE @searchText";

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable results = new DataTable();
                            adapter.Fill(results);

                            dataGridView1.DataSource = results;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            PerformSearch(searchBox.Text.Trim());
        }
    }
}
    

