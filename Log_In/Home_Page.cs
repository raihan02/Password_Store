using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ItemsAdd ia = new ItemsAdd();
            ia.Show();
            this.Hide();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pin p = new Pin();
            p.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Pin p = new Pin();
            p.Show();
        }
    }
}
