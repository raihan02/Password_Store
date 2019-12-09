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
    public partial class Form2 : Form
    {

        SqlDataAdapter sdt;
        SqlCommandBuilder sbd;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            // sbd = new SqlCommandBuilder(sdt);
            // sbd.Up

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
            sdt = new SqlDataAdapter("Select * from items", con);
            dt = new DataTable();
            sdt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
            con.Open();
            String id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlDataAdapter sda = new SqlDataAdapter("DELETE  from items  where item_name = '" + id + "' ", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
            con.Open();
            String id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string q = "UPDATE items SET password ='" + textBox1.Text + "'where item_name = '" + id + "'";

           SqlCommand cmd = new SqlCommand(q, con);
           cmd.ExecuteNonQuery();
           MessageBox.Show("Updated");
           con.Close();
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Home_Page hp = new Home_Page();
            hp.Show();
            this.Close();
        }
    }
}
