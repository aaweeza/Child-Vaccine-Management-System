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
    public partial class Form1 : Form
    {

        private string connectiontoDB = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\cvms\\editbyweeza\\CHILD VACCINATION MANAGMENT SYSTEM\\CHILD VACCINATION MANAGMENT SYSTEM\\LoginDatabase.mdf\";Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.MaxLength = 16;
            }
        }

        public string UserTypeFromForm2 { get; set; }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = connectiontoDB;
            sqlcon.Open();

            string usernameInput = textBox1.Text;
            string passwordInput = textBox2.Text;

            // Use the stored user type from Form2
            string userType = UserTypeFromForm2;

            if (string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Please select a user type (Doctor or Parent).");
                sqlcon.Close();
                return;
            }

            // Construct the query based on user type
            string query = $"SELECT * FROM Login WHERE username = '{usernameInput}' AND password = '{passwordInput}' AND username LIKE '{userType}%'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (userType == "DOC")
                {
                    // Redirect to Doctor Dashboard
                    Form4 doctorDashboard = new Form4();
                    this.Hide();
                    doctorDashboard.Show();
                }
                else if (userType == "PAR")
                {
                    // Redirect to Parent Dashboard
                    Form3 parentDashboard = new Form3();
                    this.Hide();
                    parentDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

            sqlcon.Close(); //closing the connection
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 choose = new Form2();
            this.Hide();
            choose.Show();
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {

        }
    }
}
