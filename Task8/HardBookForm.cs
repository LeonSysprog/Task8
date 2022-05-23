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
    public partial class HardBookForm : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=LEONID-PC\SQLEXPESS2;Initial Catalog=BookDB;Integrated Security=True");
        public HardBookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            string query = "SELECT * FROM Books WHERE name = @bookName";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@bookName", textBox1.Text);

            SqlDataReader readerBooks = command.ExecuteReader();

            List<string[]> dataBooks = new List<string[]>();

            while (readerBooks.Read())
            {
                dataBooks.Add(new string[5]);

                dataBooks[dataBooks.Count - 1][0] = readerBooks[1].ToString();
                dataBooks[dataBooks.Count - 1][1] = readerBooks[2].ToString();
                dataBooks[dataBooks.Count - 1][2] = readerBooks[3].ToString();
                dataBooks[dataBooks.Count - 1][3] = readerBooks[4].ToString();
                dataBooks[dataBooks.Count - 1][4] = readerBooks[5].ToString();
            }

            readerBooks.Close();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();

            foreach (string[] s in dataBooks)
            {
                dataGridView1.Rows.Add(s);
            }

            if (dataBooks.Count == 0)
            {
                myConnection.Close();
                return;
            }

            for (int i = 0; i < dataBooks.Count; ++i)
            {
                //-------------------------authors------------------------------------
                query = "SELECT * FROM Authors WHERE id = @idAuthor";

                SqlCommand commandAuthors = new SqlCommand(query, myConnection);
                commandAuthors.Parameters.AddWithValue("@idAuthor", dataBooks[i][0]);

                SqlDataReader readerAuthors = commandAuthors.ExecuteReader();

                List<string[]> dataAuthors = new List<string[]>();

                while (readerAuthors.Read())
                {
                    dataAuthors.Add(new string[3]);

                    dataAuthors[dataAuthors.Count - 1][0] = readerAuthors[1].ToString();
                    dataAuthors[dataAuthors.Count - 1][1] = readerAuthors[2].ToString();
                    dataAuthors[dataAuthors.Count - 1][2] = readerAuthors[3].ToString();
                }

                foreach (string[] s in dataAuthors)
                {
                    dataGridView2.Rows.Add(s);
                }

                readerAuthors.Close();

                //-----------------------departments-----------------------
                query = "SELECT * FROM Departments WHERE id = @idDepartment";

                SqlCommand commandDepartments = new SqlCommand(query, myConnection);
                commandDepartments.Parameters.AddWithValue("@idDepartment", dataBooks[i][1]);

                SqlDataReader readerDepartments = commandDepartments.ExecuteReader();

                List<string> dataDepartments = new List<string>();

                while (readerDepartments.Read())
                {
                    dataDepartments.Add(readerDepartments[1].ToString());
                }

                foreach (string s in dataDepartments)
                {
                    dataGridView3.Rows.Add(s);
                }

                readerDepartments.Close();
            }

            myConnection.Close();
        }
    }
}
