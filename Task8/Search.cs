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
    public partial class Search : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=LEONID-PC\SQLEXPESS2;Initial Catalog=BookDB;Integrated Security=True");
        public Search()
        {
            InitializeComponent();
        }

        private void searchString_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM [dbo].[Orders] AS A INNER JOIN [dbo].[BooksOrders] AS B ON A.id = B.id_order and order_date >= @date and order_date < @boundDate";

            SqlCommand command = new SqlCommand(query, myConnection);
            DateTime bound = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day + 1);
            command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@boundDate", bound);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
                data[data.Count - 1][5] = reader[6].ToString();
                data[data.Count - 1][6] = reader[7].ToString();
                data[data.Count - 1][7] = reader[8].ToString();
            }

            reader.Close();
            myConnection.Close();

            searchTable.Rows.Clear();
            searchTable.Refresh();

            foreach (string[] s in data)
            {
                searchTable.Rows.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM [dbo].[Orders] AS A INNER JOIN [dbo].[BooksOrders] AS B ON A.id = B.id_order and total_amount = @amount";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@amount", textBox1.Text);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
                data[data.Count - 1][5] = reader[6].ToString();
                data[data.Count - 1][6] = reader[7].ToString();
                data[data.Count - 1][7] = reader[8].ToString();
            }

            reader.Close();
            myConnection.Close();

            searchTable.Rows.Clear();
            searchTable.Refresh();

            foreach (string[] s in data)
            {
                searchTable.Rows.Add(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM [dbo].[Orders] AS A INNER JOIN [dbo].[BooksOrders] AS B ON A.id = B.id_order and book_count = @count";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@count", textBox2.Text);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
                data[data.Count - 1][5] = reader[6].ToString();
                data[data.Count - 1][6] = reader[7].ToString();
                data[data.Count - 1][7] = reader[8].ToString();
            }

            reader.Close();
            myConnection.Close();

            searchTable.Rows.Clear();
            searchTable.Refresh();

            foreach (string[] s in data)
            {
                searchTable.Rows.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM [dbo].[Orders] AS A INNER JOIN [dbo].[BooksOrders] AS B ON A.id = B.id_order and order_date >= @date and order_date < @boundDate and total_amount = @amount and book_count = @count";

            SqlCommand command = new SqlCommand(query, myConnection);
            DateTime bound = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day + 1);
            command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@boundDate", bound);
            command.Parameters.AddWithValue("@amount", textBox1.Text);
            command.Parameters.AddWithValue("@count", textBox2.Text);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
                data[data.Count - 1][5] = reader[6].ToString();
                data[data.Count - 1][6] = reader[7].ToString();
                data[data.Count - 1][7] = reader[8].ToString();
            }

            reader.Close();
            myConnection.Close();

            searchTable.Rows.Clear();
            searchTable.Refresh();

            foreach (string[] s in data)
            {
                searchTable.Rows.Add(s);
            }
        }
    }
}
