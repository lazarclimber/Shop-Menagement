using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop__invertory_
{
    public partial class MonthlyRevenue : Form
    {
        public MonthlyRevenue()
        {
            InitializeComponent();
        }

        string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=shopInvertoryDB;Integrated Security=True;";

        private void monthFromToBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = fromTimePicker.Value;
            DateTime endDate = toTimePicker.Value;

            string startDateString = startDate.ToString("yyyy-MM-dd");
            string endDateString = endDate.ToString("yyyy-MM-dd");

            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string sql = "select sum(total) from orders where orderdate between @startDate AND @endDate;";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDateString);
                    cmd.Parameters.AddWithValue("@endDate", endDateString);

                    decimal count = (decimal)cmd.ExecuteScalar();
                    mothlyRevenueLbl.Text = count.ToString();
                    conn.Close();
                }
            }
            catch
            {
                mothlyRevenueLbl.Text = "0";
            }                    
        }
    }
}
