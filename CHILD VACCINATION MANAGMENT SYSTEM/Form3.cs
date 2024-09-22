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
    public partial class Form3 : Form
    {

        private string connectiontoDB = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\cvms\\editbyweeza\\CHILD VACCINATION MANAGMENT SYSTEM\\CHILD VACCINATION MANAGMENT SYSTEM\\Child_Vaccine.mdf\";Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        // Load appointments into DataGridView
        private void LoadAppointments()
        {
            using (SqlConnection connection = new SqlConnection(connectiontoDB))
            {
                connection.Open();
                string query = "SELECT Appointment_id,Appointment_date,Appointment_time FROM Appointment";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker1.Value;

            DateTime selectedDate = selectedDateTime.Date;
            TimeSpan selectedTime = selectedDateTime.TimeOfDay;

            MessageBox.Show($"Selected Date: {selectedDate.ToString("yyyy-MM-dd")}\nSelected Time: {selectedTime.ToString(@"hh\:mm")}");


            int childId = Convert.ToInt32(textBox1.Text);

            using (SqlConnection connection = new SqlConnection(connectiontoDB))
            {
                connection.Open();

                // Assuming your Appointment table has columns: Child_id, Appointment_date, and Appointment_time
                string query = "INSERT INTO Appointment (Child_id, Appointment_date, Appointment_time) VALUES (@ChildId, @appointmentdate, @AppointmentTime)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ChildId", childId);
                command.Parameters.AddWithValue("@appointmentdate", selectedDate);
                command.Parameters.AddWithValue("@AppointmentTime", selectedTime);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment added successfully!");
                        LoadAppointments(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to add appointment.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 doctorDashboard = new Form2();
            this.Hide();
            doctorDashboard.Show();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeslotbtn_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter Child ID.");
                return;
            }

            DateTime selectedDateTime = dateTimePicker1.Value;

            DateTime selectedDate = selectedDateTime.Date;
            TimeSpan selectedTime = selectedDateTime.TimeOfDay;

            int childId = Convert.ToInt32(textBox1.Text);

            using (SqlConnection connection = new SqlConnection(connectiontoDB))
            {
                connection.Open();
                string query = "INSERT INTO Appointment (Child_Id, Appointment_time,Appointment_date) VALUES (@ChildId, @Appointment_time,@Appointment_date)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ChildId", childId);
                command.Parameters.AddWithValue("@Appointment_time", selectedTime);
                command.Parameters.AddWithValue("@Appointment_date", selectedDate);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment added successfully!");
                        LoadAppointments(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to add appointment.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }



    }
}

