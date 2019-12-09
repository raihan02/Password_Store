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
    public partial class Pin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Pin()
        {
            InitializeComponent();
        }

        private void PinSubmit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
            string str = "select * from info where pin = '" + pinText.Text + "' and name = '" + Form1.user + "'";
            cmd = new SqlCommand(str, con);
            SqlDataAdapter sd = new SqlDataAdapter(str, con);
            DataTable dta = new DataTable();
            sd.Fill(dta);
            if (dta.Rows.Count > 0)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Pin is not correct !!!");
            }
            con.Close();

        }
    }
}
