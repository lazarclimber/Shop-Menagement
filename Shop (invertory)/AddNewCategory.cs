using System;
using System.IO;
using System.Windows.Forms;

namespace Shop__invertory_
{
    public partial class AddNewCategory : Form
    {
        public AddNewCategory()
        {
            InitializeComponent();
        }

        string filePath = "C:\\projekti visual studio\\C#\\Windows Form Application\\Shop (invertory)\\Shop (invertory)\\Shop (invertory)\\Category\\categories.txt";

        private void ListCategory()
        {
            listBox1.Items.Clear();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
        }

        private void AddNewCategory_Load(object sender, EventArgs e)
        {
            ListCategory();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
           

            if(!string.IsNullOrEmpty(categoryInput.Text))
            {       
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (string item in listBox1.Items)
                    {
                        sw.WriteLine(item);
                    }

                    sw.WriteLine(categoryInput.Text);
                    categoryInput.Text = string.Empty;

                    MessageBox.Show("New category added successfully", "Conformation message", MessageBoxButtons.OK, MessageBoxIcon.Information);       
                }

                ListCategory();
            }
            else
            {
                MessageBox.Show("Input category name");
            }
            
        }
    }  
}
