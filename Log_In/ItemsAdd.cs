using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Log_In
{
    public partial class ItemsAdd : Form
    {
        public ItemsAdd()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home_Page hp = new Home_Page();
            hp.Show();
            this.Hide();
        }

        private void ItemSubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
            string str = "insert into items(item_name,password) values('" + itemText.Text + "', '" + itemPasswordText.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Submitted Successfully!!");

        }
    }
}
