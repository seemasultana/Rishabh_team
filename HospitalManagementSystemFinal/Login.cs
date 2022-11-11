using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementSystemFinal
{
    public partial class Login : Form
       
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textusername.Text) == true)
            {
                textusername.Focus();
                errorProvider1.SetError(this.textusername, "Please fill Email-id");
            }
            else if (string.IsNullOrEmpty(textpassword.Text) == true)
            {
                textpassword.Focus();
                errorProvider2.SetError(this.textpassword, "Please fill Password");
            }
            else
            {
                try
                {
                    string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery = " select * from [dbo].[Register] where Emailid=@Emailid and Password=@Password";
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    sqlcomm.Parameters.AddWithValue("@Emailid", textusername.Text);
                    sqlcomm.Parameters.AddWithValue("@Password", textpassword.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    sqlcomm.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Sucessfully");
                        ControlButtons c = new ControlButtons();
                        c.ShowDialog();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Inavlid Username & Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Hide();
        }

        private void textusername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textusername.Text)== true)
            {
                textusername.Focus();
                errorProvider1.SetError(this.textusername, "Please fill Email-id");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textusername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textpassword.Text) == true)
            {
                textpassword.Focus();
                errorProvider2.SetError(this.textpassword, "Please fill Password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }
    }
}
