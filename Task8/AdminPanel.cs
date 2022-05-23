using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class AdminPanel : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=LEONID-PC\SQLEXPESS2;Initial Catalog=Task8;Integrated Security=True");
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AuthorsForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new BooksForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new ClientsForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new CouriersForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new DeliveriesForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new DepartmentsForm();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new OrdersForm();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new SuppliersForm();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new SuppliesForm();
            form.Show();
        }
    }
}
