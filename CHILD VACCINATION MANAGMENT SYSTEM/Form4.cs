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
//AAWEEZA FAROOQUI AND AMRAH IMTIAZ
namespace CHILD_VACCINATION_MANAGMENT_SYSTEM
{
    public partial class Form4 : Form
    {
        private string connectiontoDB = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\cvms\\editbyweeza\\CHILD VACCINATION MANAGMENT SYSTEM\\CHILD VACCINATION MANAGMENT SYSTEM\\Child_Vaccine.mdf\";Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ADD-EDIT PATIENT INFO
            // Redirect to Add Patient Info:
            Patient_Info doctorDashboard = new Patient_Info();
            this.Hide();
            doctorDashboard.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //LOGIN
            Form2 doctorDashboard = new Form2();
            this.Hide();
            doctorDashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker1.Value;
            DateTime selectedDate = selectedDateTime.Date;

            // REMINDERS
            using (SqlConnection sqlCon = new SqlConnection(connectiontoDB))
            {
                sqlCon.Open();

                // Use a parameterized query to prevent SQL injection
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Appointment_id,Child_id,Appointment_date,Appointment_time FROM Appointment WHERE CONVERT(DATE, Appointment_date) = @SelectedDate", sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@SelectedDate", selectedDate);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }

            
        }
        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
