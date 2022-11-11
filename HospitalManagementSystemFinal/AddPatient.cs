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

namespace HospitalManagementSystemFinal
{
    public partial class AddPatient : Form
    {
        
        public AddPatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPateint_Load(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBloodGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDisease_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                String name = textName.Text;
                String address = textAddress.Text;
                Int64 contact = Convert.ToInt64(textPhone.Text);
                int age = Convert.ToInt32(textAge.Text);
                String gender = comboGender.Text;
                String blood = textBloodGroup.Text;
                String any = textDisease.Text;
                int pid = Convert.ToInt32(textPId.Text);


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = @"INSERT INTO [dbo].[AddPatient]
           ([Name]
           ,[Full_Address]
           ,[Contact]
           ,[Age]
           ,[Gender]
           ,[Blood_Group]
           ,[Major_Disease]
           ,[pid]) VALUES('" + name + "','" + address + "'," + contact + "," + age + ",'" + gender + "','" + blood + "','" + any + "'," + pid + ")";

                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
                MessageBox.Show("Data is saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Format!! Try Again");

            }

        

            textName.Clear();
            textAddress.Clear();
            textPhone.Clear();
            textAge.Clear();
            textBloodGroup.Clear();
            textDisease.Clear();
            textPId.Clear();
            comboGender.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ControlButtons cbc = new ControlButtons();
            cbc.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addmoreinfo ami = new Addmoreinfo();
            ami.ShowDialog();
            this.Hide();
        }

        private void textName_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textName.Text)==true)
            {
                textName.Focus();
                errorProvider1.SetError(this.textName, "Enter name!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
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

        private void textAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAddress.Text) == true)
            {
                textAddress.Focus();
                errorProvider2.SetError(this.textAddress, "Enter address!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPhone.Text) == true)
            {
                textPhone.Focus();
                errorProvider3.SetError(this.textPhone, "Enter phone!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
          
            else
            {
                e.Handled = true;
            }
        }

        private void textBloodGroup_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBloodGroup.Text) == true)
            {
                textBloodGroup.Focus();
                errorProvider6.SetError(this.textBloodGroup, "Enter Blood group!");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void textDisease_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisease.Text) == true)
            {
                textDisease.Focus();
                errorProvider7.SetError(this.textDisease, "Enter Blood group!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void textPId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPId.Text) == true)
            {
                textPId.Focus();
                errorProvider8.SetError(this.textPId, "Enter Blood group!");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void textPId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAge.Text) == true)
            {
                textAge.Focus();
                errorProvider4.SetError(this.textAge, "Enter  Age!");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void comboGender_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboGender.Text) == true)
            {
                comboGender.Focus();
                errorProvider5.SetError(this.comboGender, "Enter  Age!");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true )
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
