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
    public partial class SuppliesForm : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=LEONID-PC\SQLEXPESS2;Initial Catalog=Task8;Integrated Security=True");
        public SuppliesForm()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM Supplies";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
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

            String query = "INSERT INTO Supplies (id_supplier, arrival) VALUES (@supplierParametr, @arrivalParametr)";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@supplierParametr", textBox1.Text);
            command.Parameters.AddWithValue("@arrivalParametr", textBox2.Text);

            command.ExecuteNonQuery();
        }
    }
}
