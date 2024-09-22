using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//AAWEEZA FAROOQUI AND AMRAH IMTIAZ
namespace CHILD_VACCINATION_MANAGMENT_SYSTEM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        // Add a property to get the selected user type
        public string SelectedUserType
        {
            get
            {
                return doctorradio.Checked ? "DOC" : (parentlogin.Checked ? "PAR" : "");
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            // Pass the selected user type to Form1
            f1.UserTypeFromForm2 = SelectedUserType;

            this.Hide();
            f1.Visible = true;
        }

        private void doctorradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void parentlogin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
