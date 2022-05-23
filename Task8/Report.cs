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
    public partial class Report : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=LEONID-PC\SQLEXPESS2;Initial Catalog=BookDB;Integrated Security=True");
        
        public Report()
        {
            InitializeComponent();
        }

        private void bookCountSuppliesButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            int res = 0;
            String query = "bookCountSupplies";
            SqlCommand command = new SqlCommand(query, myConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@startDate", dateBookCountSupplies1.Value);
            command.Parameters.AddWithValue("@endDate", dateBookCountSupplies2.Value);
            command.Parameters.Add("@sumVal", SqlDbType.Int).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            res = Convert.ToInt32(command.Parameters["@sumVal"].Value);
            resBookCount.Clear();
            resBookCount.Text = res.ToString();
        }

        private void revenueFromOrdersButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            long res = 0;
            String query = "revenueFromOrders";
            SqlCommand command = new SqlCommand(query, myConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@startDate", dateRevenueFromOrders1.Value);
            command.Parameters.AddWithValue("@endDate", dateRevenueFromOrders2.Value);
            command.Parameters.Add("@revenue", SqlDbType.BigInt).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            res = Convert.ToInt64(command.Parameters["@revenue"].Value);
            resRevenue.Clear();
            resRevenue.Text = res.ToString();
        }

        private void resTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getMaxBookCountByGenreButton_Click(object sender, EventArgs e)
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

            String query = "getMaxBookCountByGenre";
            SqlCommand command = new SqlCommand(query, myConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@startDate", dateGetMaxBookCountByGenre1.Value);
            command.Parameters.AddWithValue("@endDate", dateGetMaxBookCountByGenre2.Value);

            //command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }

            reader.Close();
            myConnection.Close();

            BookGenre.Rows.Clear();
            BookGenre.Refresh();

            foreach (string[] s in data)
            {
                BookGenre.Rows.Add(s);
            }
        }
    }
}
