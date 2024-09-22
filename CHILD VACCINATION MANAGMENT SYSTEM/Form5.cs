using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CHILD_VACCINATION_MANAGMENT_SYSTEM
{
    public partial class Patient_Info : Form
    {
        private string connectiontoString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\cvms\\editbyweeza\\CHILD VACCINATION MANAGMENT SYSTEM\\CHILD VACCINATION MANAGMENT SYSTEM\\Child_Vaccine.mdf\";Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private Dictionary<int, Dictionary<string, bool>> childVaccineInfo; // Child_id -> VaccineName -> Administered

        public Patient_Info()
        {
            InitializeComponent();
            childVaccineInfo = new Dictionary<int, Dictionary<string, bool>>();
        }

        private void OpenSqlConnection()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connectiontoString);
            }

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        private void UpdateVaccineRecords(int Child_id)
        {
            OpenSqlConnection();

            try
            {
                // Use a transaction to ensure that either all operations succeed or fail together
                using (SqlTransaction transaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        // Get the existing vaccine records for the child
                        Dictionary<string, bool> existingVaccines = GetExistingVaccineRecords(Child_id, transaction);

                        // Iterate through checked items in the checkboxlist
                        foreach (string vaccineName in checkedListBox1.CheckedItems)
                        {
                            // Check if the vaccine record already exists for the child
                            if (!existingVaccines.ContainsKey(vaccineName))
                            {
                                // Insert a new vaccine record for the child
                                SqlCommand insertCommand = new SqlCommand("INSERT INTO VACCINE (Vaccine_name, Child_id) VALUES (@VaccineName, @Child_id)", sqlConnection, transaction);
                                insertCommand.Parameters.AddWithValue("@VaccineName", vaccineName);
                                insertCommand.Parameters.AddWithValue("@Child_id", Child_id);
                                insertCommand.ExecuteNonQuery();

                            }
                        }

                        // Commit the transaction if everything is successful
                        transaction.Commit();
                        MessageBox.Show("Vaccine records updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there's an error
                        transaction.Rollback();
                        MessageBox.Show("Error updating vaccine records: " + ex.Message);
                    }
                }
            }
            finally
            {
                CloseSqlConnection();
            }
        }


        private Dictionary<string, bool> GetExistingVaccineRecords(int Child_id, SqlTransaction transaction)
        {
            Dictionary<string, bool> existingVaccines = new Dictionary<string, bool>();

            // Query to get existing vaccine records for the child
            string query = "SELECT Vaccine_name FROM VACCINE WHERE Child_id = @Child_id";


            using (SqlCommand cmd = new SqlCommand(query, sqlConnection, transaction))  // Use the same transaction here
            {
                cmd.Parameters.AddWithValue("@Child_id", Child_id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string vaccineName = reader["Vaccine_name"].ToString();
                        existingVaccines[vaccineName] = true;
                    }
                }
            }

            return existingVaccines;
        }



        private void CloseSqlConnection()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UPDATE
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            OpenSqlConnection();
            try
            {
                // Check if parent already exists
                string parentQuery = "SELECT Parent_id FROM PARENT WHERE FullName = @ParentName AND Contact_no = @ParentContact";
                sqlCommand = new SqlCommand(parentQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ParentName", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@ParentContact", textBox5.Text);

                int parentId;

                object result = sqlCommand.ExecuteScalar();
                if (result != null)
                {
                    // Parent already exists, use existing Parent_id
                    parentId = (int)result;
                }
                else
                {
                    // Parent doesn't exist, insert new parent and get generated Parent_id
                    string insertParentQuery = "INSERT INTO PARENT (FullName, Contact_no) VALUES (@ParentName, @ParentContact); SELECT SCOPE_IDENTITY();";
                    sqlCommand = new SqlCommand(insertParentQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@ParentName", textBox4.Text);
                    sqlCommand.Parameters.AddWithValue("@ParentContact", textBox5.Text);

                    // Get the generated Parent_id
                    parentId = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }

                // Now insert data into the CHILD table using the obtained Parent_id
                // Now insert data into the CHILD table using the obtained Parent_id
                string childQuery = "INSERT INTO CHILD (FullName, DateOfBirth, Gender, Parent_id) " +
                                    "VALUES (@FullName, @DateOfBirth, @Gender, @ParentId);" +
                                    " SELECT SCOPE_IDENTITY() AS ChildId";

                sqlCommand = new SqlCommand(childQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@FullName", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", DateTime.ParseExact(textBox2.Text, "dd/MM/yyyy", null));

                // Get the selected gender from the radio buttons
                string gender = radioButton1.Checked ? "Male" : "Female";
                sqlCommand.Parameters.AddWithValue("@Gender", gender);

                sqlCommand.Parameters.AddWithValue("@ParentId", parentId);

                // Get the generated Child_id
                int Child_id = Convert.ToInt32(sqlCommand.ExecuteScalar());

                // Update the VACCINE table for the new child
                UpdateVaccineRecords(Child_id);

                MessageBox.Show("Data inserted successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
            finally
            {
                display_data();
                CloseSqlConnection();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            OpenSqlConnection();

            try
            {
                if (int.TryParse(textBox7.Text, out int Child_id))
                {
                    string query = "SELECT C.*, P.FullName AS ParentName, P.Contact_no AS ParentContact " +
                                   "FROM CHILD C " +
                                   "INNER JOIN PARENT P ON C.Parent_id = P.Parent_id " +
                                   "WHERE C.Child_id = @Child_id";

                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Child_id", Child_id);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        textBox1.Text = reader["FullName"].ToString();
                        textBox2.Text = reader["DateOfBirth"].ToString();
                        radioButton1.Checked = reader["Gender"].ToString().Equals("Male", StringComparison.OrdinalIgnoreCase);
                        radioButton2.Checked = reader["Gender"].ToString().Equals("Female", StringComparison.OrdinalIgnoreCase);
                        textBox4.Text = reader["ParentName"].ToString();
                        textBox5.Text = reader["ParentContact"].ToString();

                        display_data();
                       
                    }
                    else
                    {
                        MessageBox.Show("Child ID not found.");
                        ClearTextBoxes();
                        dataGridView2.DataSource = null; // Clear DataGridView when child is not found
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Child ID. Please enter a valid numeric value.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
            finally
            {
                CloseSqlConnection();
            }
        }


        private void display_data()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectiontoString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT C.*, P.FullName AS ParentName, P.Contact_no AS ParentContact, V.Vaccine_name " +
                                          "FROM CHILD C " +
                                          "INNER JOIN PARENT P ON C.Parent_id = P.Parent_id " +
                                          "LEFT JOIN VACCINE V ON C.Child_id = V.Child_id " +
                                          "WHERE C.Child_id = @Child_id";
                        cmd.Parameters.AddWithValue("@Child_id", Convert.ToInt32(textBox7.Text));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Bind the DataTable to the DataGridView
                            dataGridView2.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox7.Clear();
            textBox5.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 parentDashboard = new Form4();
            Hide();
            parentDashboard.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 parentDashboard = new Form4();
            Hide();
            parentDashboard.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}