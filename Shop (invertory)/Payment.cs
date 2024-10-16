using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop__invertory_
{
    public partial class Payment : UserControl
    {
        private ContextMenuStrip contextMenu;

        public Payment()
        {
            InitializeComponent();

            contextMenu = new ContextMenuStrip();

            contextMenu.Items.Add("Daily Revenue", null, DailyRevenue);
            contextMenu.Items.Add("Monthly Revenue", null, MonthlyRevenue);
        }

        string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=shopInvertoryDB;Integrated Security=True;";
        public static decimal billCost;
        public static decimal dailyRevenue;

        public void RefreshData()
        {
            DisplayItemsInCart();
            totalPayment.Text = "0.00";
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            searchGridView.KeyDown += new KeyEventHandler(searchGridView_KeyDown);
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown);

            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string delete = "DELETE from payment";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            DisplayItemsInCart();

            totalPayment.Text = "0.00";
            conn.Close();
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void itemInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchGridView.Visible = true;
            if(itemInput.Text == "")
            {
                searchGridView.Visible = false;
            }
        }

        private void quantityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

                            searchGridView.DataSource = results;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void itemInput_TextChanged(object sender, EventArgs e)
        {
            PerformSearch(itemInput.Text.Trim());
        }


        private void searchGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                var currentCell = searchGridView.CurrentCell;

                if (currentCell != null)
                {
                    DataGridViewRow row = searchGridView.Rows[currentCell.RowIndex];
                    itemIDInput.Text = row.Cells[0].Value.ToString();
                    nameInput.Text = row.Cells[1].Value.ToString();
                    priceInput.Text = row.Cells[2].Value.ToString();
                    itemsLeftInput.Text = row.Cells[3].Value.ToString();
                    searchGridView.Visible = false;

                    quantityInput.Focus();
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {                
                e.Handled = true;
                
                    var id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
 
                    string delete = "DELETE from payment where id = '" + id + "'";
                    SqlConnection conn = new SqlConnection(connstring);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.ExecuteNonQuery();
                    
                    DisplayItemsInCart();

                    string grandTotal = "SELECT SUM(Total) AS grandTotal from payment";

                    using (SqlCommand check = new SqlCommand(grandTotal, conn))
                    {
                        object result = check.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal value = Convert.ToDecimal(result);
                            totalPayment.Text = value.ToString();
                        }
                        else
                        {
                            totalPayment.Text = "0.00";
                        }
                    }
                    conn.Close();                   
            }
        }

        private void DisplayItemsInCart()
        {
            string select = "SELECT ID, Item, Quantity, Price, Total from payment";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd2 = new SqlCommand(select, conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddToCart()
        {
            if (!string.IsNullOrEmpty(itemIDInput.Text) && !string.IsNullOrEmpty(quantityInput.Text))
            {
                string id = itemIDInput.Text;
                string name = nameInput.Text;
                string quantity = quantityInput.Text;
                string price = priceInput.Text;
                decimal total = Convert.ToDecimal(price) * Convert.ToDecimal(quantity);


                if (Convert.ToInt32(quantity) > 0)
                {
                    if(Convert.ToInt32(itemsLeftInput.Text) < Convert.ToInt32(quantity))
                    {
                        MessageBox.Show("Not enough items in magacine!");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(connstring);
                        conn.Open();

                        string sql = "INSERT into payment(ID, Item, Quantity, Price, Total) values ('" + id + "', '" + name + "', '" + quantity + "', '" + price + "', '" + total + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        DisplayItemsInCart();

                        string grandTotal = "SELECT SUM(Total) AS grandTotal from payment";

                        using (SqlCommand check = new SqlCommand(grandTotal, conn))
                        {
                            decimal count = (decimal)check.ExecuteScalar();
                            billCost = count;
                            totalPayment.Text = count.ToString();
                        }
                        conn.Close();

                        itemIDInput.Text = string.Empty;
                        nameInput.Text = string.Empty;
                        priceInput.Text = string.Empty;
                        itemsLeftInput.Text = string.Empty;
                        priceInput.Text = "0.00";
                        itemInput.Text = string.Empty;
                        quantityInput.Text = string.Empty;

                        dataGridView1.ClearSelection();
                        itemInput.Focus();
                    }                  
                }             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToCart();   
        }

        private void quantityInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && nameInput.Text != "")
            {
                e.Handled = true;
                AddToCart();
            }
        }

        private void DeleteFromCart()
        {
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string checkCart = "SELECT * from payment";

            using (SqlCommand check = new SqlCommand(checkCart, conn))
            {

                try
                {
                    object result = check.ExecuteScalar();
                    int count = result != null ? Convert.ToInt32(result) : 0;

                    if (count > 0)
                    {
                        DialogResult dialog = MessageBox.Show("Do you want to delete items from cart?", "Delete conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            string delete = "DELETE from payment";
                            SqlCommand cmd = new SqlCommand(delete, conn);
                            cmd.ExecuteNonQuery();

                            DisplayItemsInCart();

                            totalPayment.Text = "0.00";
                            conn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cart is already empty");
                }

            }
        }

        private void DeleteCartBtn_Click(object sender, EventArgs e)
        {
            DeleteFromCart();
        }

        private void PaymentFunction()
        {
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select count(*) from payment";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    PaymentChange paymentChange = new PaymentChange(this);
                    paymentChange.Show();
                }
            }
            conn.Close();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            PaymentFunction();
        }

        private void DailyRevenue(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;

            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select sum(total) from orders where cast(OrderDate as date) = cast(getdate() as date);";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    decimal count = (decimal)cmd.ExecuteScalar();
                    dailyRevenue = count;
                    DailyRevenue dR = new DailyRevenue();
                    dR.Show();
                }
                catch
                {
                    dailyRevenue = 0;
                    DailyRevenue dR = new DailyRevenue();
                    dR.Show();
                }               
            }
        }

        private void MonthlyRevenue(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            MonthlyRevenue mR = new MonthlyRevenue();
            mR.Show();
        }

        private void revenueBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            contextMenu.Show(button, 0, button.Height);
        }


    }
}
