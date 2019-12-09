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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }
        private void Label5_Click(object sender, EventArgs e)
        {
            label5.Hide();
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(userPasswordText.Text == confirmPasswordText.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4UE5J5G\RAIHANSQL;Initial Catalog=Raihan_Database;Integrated Security=True;Pooling=False");
                string str = "insert into info(name,password,cpass,pin) values('"+userNameText.Text+"','" + userPasswordText.Text + "', '" + confirmPasswordText.Text + "','" + pinText.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You are registered. Thank you");
            }
            else
            {
                label5.Show();
                label5.Text = "Password mismatch";
            }
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
