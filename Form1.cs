using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Strife
{
    public partial class Form1 : Form
    {

        List<UserDetails> userDetails;

        public Form1()
        {
            userDetails = new List<UserDetails>();
            InitializeComponent();
        }

        public void ShowForm2()
        {
            Form2 form = new Form2();
            form.Show();
        }

        DataAccess da = new DataAccess();

        private void Form1_Load(object sender, EventArgs e)
        {
            userDetails = da.GetUsers();
        } 

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string signName = txtName.Text;
            string signPass = txtPassword.Text;

            bool check = false;

            foreach (UserDetails item in userDetails)
            {
                if (item.Name == signName && item.Password == signPass)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }

            if (check)
            {
                this.Hide();
                Form3 form = new Form3();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error: Invalid details. Please reenter sign in details");
                txtName.Clear();
                txtPassword.Clear();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string signName = txtName.Text;
            string signPass = txtPassword.Text;

            /*bool check = false;

            foreach (UserDetails item in userDetails)
            {
                if (item.Name == signName && item.Password == signPass)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }

            if (check)
            {
                this.Hide();
                Form3 form = new Form3();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error: Invalid details. Please reenter sign in details");
                txtName.Clear();
                txtPassword.Clear();
            }*/

            if (signName != null && signPass != null)
            {
                this.Hide();
                Form3 form = new Form3();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error: Invalid details. Please reenter sign in details");
            }

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
