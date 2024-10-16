using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop__invertory_
{
    public partial class PaymentChange : Form
    {
        private Payment payment;

        public PaymentChange(Payment pay)
        {
            InitializeComponent();     
            payment = pay;
        }

        

        string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=shopInvertoryDB;Integrated Security=True;";
        decimal cashInput = 0;
        decimal cardInput = 0;
        string change;

        private void PaymentChange_Load(object sender, EventArgs e)
        {
            billCostTextBox.Text = Payment.billCost.ToString();
            cashInputTextBox.Focus();                  
        }

        private void CalculateTotal(object sender, KeyEventArgs e)
        {          
            change = (cashInput + cardInput - Convert.ToDecimal(billCostTextBox.Text)).ToString();
            e.Handled = true;  
            changeTextBox.Text = change;
        }

        private void cashInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(cashInputTextBox.Text == "")
                {
                    cashInput = 0;
                    cashInputTextBox.Text = "0.00";
                    CalculateTotal(sender, e);
                }
                else
                {
                    cashInput = Convert.ToInt32(cashInputTextBox.Text);
                    CalculateTotal(sender, e);
                }
                cardInputTextBox.Focus();
            }               
        }

        private void cardInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(cardInputTextBox.Text == "")
                {
                    cardInput = 0;
                    cardInputTextBox.Text = "0.00";
                    CalculateTotal(sender, e);
                }
                else
                {
                    cardInput = Convert.ToDecimal(cardInputTextBox.Text);
                    CalculateTotal(sender, e);
                }
                changeTextBox.Focus();
            }           
        }

        private void InputNumOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cashInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumOnly(sender, e);
        }

        private void cardInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumOnly(sender, e);
        }

        private void changeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Convert.ToDecimal(change) >= 0)
            {

                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                string insert = "INSERT INTO orders (OrderDate, ID, Item, Quantity, Price, Total) SELECT getDate(), ID, Item, Quantity, Price, Total FROM payment;";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();

                string update = "UPDATE products SET quantity = quantity - (SELECT Quantity FROM payment WHERE Item = products.name AND ID = products.ID)WHERE name = (SELECT Item FROM payment WHERE ID = products.ID);";
                SqlCommand upd = new SqlCommand(update, conn);
                upd.ExecuteNonQuery();

                string delete = "DELETE from payment";
                SqlCommand cmd2 = new SqlCommand(delete, conn);
                cmd2.ExecuteNonQuery();
               
                payment.RefreshData();
                payment.Show();
                this.Hide();
            }          
        }
    }
}
