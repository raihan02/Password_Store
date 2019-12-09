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
    public partial class View : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        string sr = "";
        public View()
        {
            InitializeComponent();
        }
        
        private void Label3_Click(object sender, EventArgs e)
        {
            label3.Hide();
        }
        private void View_Load(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select item_name from items";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox.Items.Add(dr["item_name"].ToString());
            }
            con.Close();
        }
       
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
            cmd = new SqlCommand("Select * from items where item_name = '" + comboBox.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                string ss = dr.GetString(1).ToString();
                enterText.Text = ss;
                
            }
            con.Close();
        }

        private void PinShowButton_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
            string str = "select * from info where pin = '" +text.Text+"' and name = '"+Form1.user+"'"; 
            cmd = new SqlCommand(str, con);
            SqlDataAdapter sd = new SqlDataAdapter(str, con);
            DataTable dta = new DataTable();
            sd.Fill(dta);
            if (dta.Rows.Count > 0)
            {
                label3.Text = Form1.user;
                label3.Text = enterText.Text;
            }
            else
            {
                MessageBox.Show("Pin is not correct !!!");
            }
            con.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home_Page hp = new Home_Page();
            hp.Show();
            this.Hide();
        }
    }
}