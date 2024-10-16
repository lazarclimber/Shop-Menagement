using System;
using System.Windows.Forms;

namespace Shop__invertory_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
        }
  
        private void magacineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magacine magacine = new Magacine();
            magacine.Show();
        }

        private void addNewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItems addItems = new AddItems(); 
            addItems.Show();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewCategory addNewCategory = new AddNewCategory();
            addNewCategory.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payment1.Visible = true;
        }
    }
}
