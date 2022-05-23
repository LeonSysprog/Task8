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
    public partial class CouriersForm : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=LEONID-PC\SQLEXPESS2;Initial Catalog=Task8;Integrated Security=True");
        public CouriersForm()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM Clients";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();
            myConnection.Close();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            String query = "INSERT INTO Clients (fio, phone, email) VALUES (@fioParametr, @phoneParametr, @emailParametr)";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@fioParametr", textBox1.Text);
            command.Parameters.AddWithValue("@phoneParametr", textBox2.Text);
            command.Parameters.AddWithValue("@emailParametr", textBox3.Text);

            command.ExecuteNonQuery();
        }
    }
}
