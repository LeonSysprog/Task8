using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Form form = new AdminPanel();
            form.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Form form = new UserPanel();
            form.Show();
        }
    }
}
