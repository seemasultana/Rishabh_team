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
    public partial class HistoryPatient : Form
    {
        public HistoryPatient()
        {
            InitializeComponent();
        }

        private void HistoryPatient_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT *FROM AddPatient inner join PatientMore on AddPatient.pid=PatientMore.pid";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT *FROM AddPatient inner join PatientMore on AddPatient.pid=PatientMore.pid";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addmoreinfo amb = new Addmoreinfo();
            amb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospitalinfo hi = new Hospitalinfo();
            hi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=INBAWN170255\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                con.Open();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          /*  if (textBox1.Text != "")
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

                dataGridView2.DataSource = ds.Tables[0];*/


            }
        }
    }

