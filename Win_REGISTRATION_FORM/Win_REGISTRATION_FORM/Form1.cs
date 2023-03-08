using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_REGISTRATION_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == txtConPass.Text)
            {
                btnsubmit.Enabled = true;
                PassError.Text = "";
            }
            else
            {
                PassError.Text = "Password Doesnt Match! Please Retry!";
                btnsubmit.Enabled = false;
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string FirstName = txtFname.Text;
            string LastName = txtLname.Text;
            string Email = txtEmail.Text;
            string Contact = txtContact.Text;
            string Gender;
            if(rbMale.Checked== true)
            {
                Gender = rbMale.Text;
            }
            else
            {
                Gender = rbFemale.Text;
            }

            string Address = txtAddress.Text;
            string UserName = txtUsern.Text;
            string Password = txtPass.Text;

            MessageBox.Show("First Name: "+FirstName+ "\n" +"Last Name: "+LastName + "\n" +"Email: "+Email + "\n" +"Contact: "+Contact + "\n" +"Address: "+Address + "\n" +"Username: "+UserName + "\n" +"Password: "+Password);
        }
    }
}
