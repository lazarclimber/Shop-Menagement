using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Shop__invertory_
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        private void CategoryItems()
        {
            string filePath = "C:\\projekti visual studio\\C#\\Windows Form Application\\Shop (invertory)\\Shop (invertory)\\Shop (invertory)\\Category\\categories.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                categoryComboBox.Items.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    categoryComboBox.Items.Add(line);
                }
            }
        }

        private void quantityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void priceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void AddItems_Load(object sender, EventArgs e)
        {
            CategoryItems();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nameInput.Text) || !string.IsNullOrEmpty(quantityInput.Text) || !string.IsNullOrEmpty(priceInput.Text) || !string.IsNullOrEmpty(categoryComboBox.Text))
            {
                string name = nameInput.Text;
                decimal quantity = Convert.ToDecimal(quantityInput.Text);
                decimal price = Convert.ToDecimal(priceInput.Text);
                string category = categoryComboBox.Text;

                string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=shopInvertoryDB;Integrated Security=True;";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();

                string sql = "insert into products(name, quantity, price, category) values ('" + name+"', '"+quantity+"', '"+price+"', '"+category+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

                nameInput.Text = string.Empty;
                quantityInput.Text = string.Empty;
                priceInput.Text = string.Empty;
                categoryComboBox.Text = string.Empty;

                MessageBox.Show("Product inserted successfully", "Conformation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Input all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
