using System;
using System.Windows.Forms;

namespace Shop__invertory_
{
    public partial class DailyRevenue : Form
    {
        public DailyRevenue()
        {
            InitializeComponent();
        }

        private void DailyRevenue_Load(object sender, EventArgs e)
        {
            dailyRevenueLbl.Text = Payment.dailyRevenue.ToString();
        }
    }
}
