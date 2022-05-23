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
    public partial class BooksForm : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=LEONID-PC\SQLEXPESS2;Initial Catalog=Task8;Integrated Security=True");
        public BooksForm()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            String query = "INSERT INTO Books (id_author, id_department, name, publisher_code, language) VALUES (@author, @department, @name, @code, @lang)";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@author", idAuthor.Text);
            command.Parameters.AddWithValue("@department", idDepartment.Text);
            command.Parameters.AddWithValue("@name", name.Text);
            command.Parameters.AddWithValue("@code", publisherCode.Text);
            command.Parameters.AddWithValue("@lang", language.Text);

            command.ExecuteNonQuery();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM Books";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
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
    }
}
