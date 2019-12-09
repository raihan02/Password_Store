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
    public partial class Form1 : Form
    {
        public static string user = "";
        public static string password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBuuton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUP su = new SignUP();
            su.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
            string str = "select name,password from info where name = '"+nameText.Text+"' and password = '"+passwordText.Text+"'";
            
            
           
                user = nameText.Text;
                password = passwordText.Text;
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter sd = new SqlDataAdapter(str, con);
                DataTable dta = new DataTable();
                sd.Fill(dta);
                if (dta.Rows.Count > 0)
                {

                    this.Hide();
                    Home_Page hp = new Home_Page();
                    hp.Show();

                }
                else
                {
                    MessageBox.Show("Password or Username is not correct !!!");
                }
            
           
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
