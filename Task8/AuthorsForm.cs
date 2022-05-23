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
    public partial class AuthorsForm : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=LEONID-PC\SQLEXPESS2;Initial Catalog=Task8;Integrated Security=True");

        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void fio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            var fioText = fio.Text;
            var birthDate = birth.Value;
            var deathDate = death.Value;

            String query = "INSERT INTO Authors (fio, birth, death) VALUES (@fioParametr, @birthParametr, @deathParametr)";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@fioParametr", fioText);
            command.Parameters.AddWithValue("@birthParametr", birthDate);
            command.Parameters.AddWithValue("@deathParametr", deathDate);

            command.ExecuteNonQuery();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM Authors";

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

            Authors.Rows.Clear();
            Authors.Refresh();

            foreach (string[] s in data)
            {
                Authors.Rows.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            var fioText = fio.Text;
            var birthDate = birth.Value;
            var deathDate = death.Value;

            String query = "DELETE FROM Authors WHERE fio  = @nameAuthor";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@nameAuthor", textBox1.Text);

            command.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            var fioText = fio.Text;
            var birthDate = birth.Value;
            var deathDate = death.Value;

            String query = "UPDATE Authors SET fio = @n, birth = @b, death = @d WHERE fio  = @nameAuthor";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@nameAuthor", textBox1.Text);
            command.Parameters.AddWithValue("@n", fioText);
            command.Parameters.AddWithValue("@b", birthDate);
            command.Parameters.AddWithValue("@d", deathDate);

            command.ExecuteNonQuery();
        }
    }
}
