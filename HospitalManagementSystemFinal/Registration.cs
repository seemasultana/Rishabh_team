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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace HospitalManagementSystemFinal
{
    public partial class Registration : Form
    {
        string emailpattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        string password = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        public Registration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxReguser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxregemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxregphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxregpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Register]
           ([User name]
           ,[Emailid]
           ,[Password]
           ,[Confirmpass])
     VALUES
          ('" + textBoxReguser.Text + "', '" + textBoxregemail.Text + "', '" + textBoxregpass.Text + "', '" + textBoxregcp + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();



                if (string.IsNullOrEmpty(textBoxReguser.Text) == true)
                {
                    textBoxReguser.Focus();
                    errorProvider1.SetError(this.textBoxReguser, "Please fill username");
                }
                else if (Regex.IsMatch(textBoxregemail.Text, emailpattern) == false)
                {
                    textBoxregemail.Focus();
                    errorProvider2.SetError(this.textBoxregemail, "Please enter valid email");

                }
                else if (Regex.IsMatch(textBoxregpass.Text, password) == false)
                {
                    textBoxregpass.Focus();
                    errorProvider3.SetError(this.textBoxregpass, "Enter strong password!");
                }
                else if (textBoxregcp.Text != textBoxregpass.Text)
                {
                    textBoxregcp.Focus();
                    errorProvider4.SetError(this.textBoxregcp, "Password Mismatched");
                }
                else
                {
                    MessageBox.Show("Registered");
                    Login f = new Login();
                    f.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Inavalid Format");
            }
           
        }

        private void btnalreday_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void textBoxReguser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxReguser.Text) == true)
            {
                textBoxReguser.Focus();
                errorProvider1.SetError(this.textBoxReguser, "Please fill username");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxReguser_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch)==true)
            {
                e.Handled = false;

            }
            else if (ch==8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxregemail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxregemail_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBoxregemail.Text, emailpattern)==false)
            {
                textBoxregemail.Focus();
                errorProvider2.SetError(this.textBoxregemail, "Please enter valid email");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxregpass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxregpass.Text, password) == false)
            {
                textBoxregpass.Focus();
                errorProvider3.SetError(this.textBoxregpass, "Enter strong password!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBoxregcp_Leave(object sender, EventArgs e)
        {
            if (textBoxregcp.Text != textBoxregpass.Text)
            {
                textBoxregcp.Focus();
                errorProvider4.SetError(this.textBoxregcp, "Password Mismatched");
            }
            else
            {
                errorProvider4.Clear();
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
    }
}
