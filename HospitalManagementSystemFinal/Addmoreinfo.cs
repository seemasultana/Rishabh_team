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
    public partial class Addmoreinfo : Form
    {
        public Addmoreinfo()
        {
            InitializeComponent();
        }

        private void Addmoreinfo_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                int pid = Convert.ToInt32(textBox1.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT *FROM AddPatient where pid=" + pid + "";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                Da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textSymptoms_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxWard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textDiagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxWardType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textMedicines_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textSymptoms.Text) == true)
            {
                textSymptoms.Focus();
                errorProvider1.SetError(this.textSymptoms, "Enter Symptoms !");
            }

            else if (string.IsNullOrEmpty(comboBoxWard.Text) == true)
            {
                comboBoxWard.Focus();
                errorProvider4.SetError(this.comboBoxWard, "Select ward !");
            }
            else if (string.IsNullOrEmpty(textDiagnosis.Text) == true)
            {
                textDiagnosis.Focus();
                errorProvider2.SetError(this.textDiagnosis, "Enter  Diagnosis!");
            }
            else if (string.IsNullOrEmpty(comboBoxWardType.Text) == true)
            {
                comboBoxWardType.Focus();
                errorProvider5.SetError(this.comboBoxWardType, "Select ward type!!");
            }

            else if (string.IsNullOrEmpty(textMedicines.Text) == true)
            {
                textMedicines.Focus();
                errorProvider3.SetError(this.textMedicines, "Enter Medicines!");
            }
            else
            {
                try
                {
                    int pid = Convert.ToInt32(textBox1.Text);
                    String sympt = textSymptoms.Text;
                    String diag = textDiagnosis.Text;
                    String medicine = textMedicines.Text;
                    String ward = comboBoxWard.Text;
                    String wardtype = comboBoxWardType.Text;
                    String date = dateTimePicker1.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "INSERT INTO PatientMore VALUES(" + pid + ",'" + sympt + "','" + diag + "','" + medicine + "','" + ward + "','" + wardtype + "','" + date + "')";
                    SqlDataAdapter Da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    Da.Fill(ds);


                    MessageBox.Show("Data Saved!!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Fiels is empty!");
                }
            }
            

           /* textBox1.Clear();

            textSymptoms.Clear();
            textDiagnosis.Clear();
            textMedicines.Clear();
            comboBoxWard.ResetText();
            comboBoxWardType.ResetText();
            dateTimePicker1.ResetText();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPatient apb = new AddPatient();
            apb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HistoryPatient hp = new HistoryPatient();
            hp.Show();
            this.Hide();
        }

        private void textSymptoms_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textSymptoms.Text) == true)
            {
                textSymptoms.Focus();
                errorProvider1.SetError(this.textSymptoms, "Enter Symptoms !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textDiagnosis_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDiagnosis.Text) == true)
            {
                textDiagnosis.Focus();
                errorProvider2.SetError(this.textDiagnosis, "Enter  Diagnosis!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textMedicines_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMedicines.Text) == true)
            {
                textMedicines.Focus();
                errorProvider3.SetError(this.textMedicines, "Enter Medicines!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void comboBoxWard_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxWard.Text) == true)
            {
                comboBoxWard.Focus();
                errorProvider4.SetError(this.comboBoxWard, "Select ward !");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void comboBoxWardType_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxWardType.Text) == true)
            {
                comboBoxWardType.Focus();
                errorProvider5.SetError(this.comboBoxWardType, "Select ward type!!");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int pid = Convert.ToInt32(textBox1.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT *FROM AddPatient where pid=" + pid + "";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                Da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
               
                SqlCommand s = new SqlCommand("DELETE FROM AddPatient WHERE pid=@pid");
                con.Open();
                s.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        /*  void FillData()
{
SqlConnection con = new SqlConnection();
con.ConnectionString = "Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
con.Open();
SqlDataAdapter sd = new SqlDataAdapter("Search", con);
sd.SelectCommand.CommandType = CommandType.StoredProcedure;
sd.SelectCommand.Parameters.AddWithValue("@Pid", textBox1.Text.Trim());
DataTable dt  = new DataTable();
sd.Fill(dt);
dataGridView1.DataSource = dt;
con.Close();
}*/
    }
}












