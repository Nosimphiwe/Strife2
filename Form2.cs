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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog findFile = new OpenFileDialog();
            findFile.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (findFile.ShowDialog() == DialogResult.OK)
            {
                picProfile.Image = new Bitmap(findFile.FileName);
            }

        }

        DataAccess da = new DataAccess();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string cell = txtCell.Text;
            string unit = txtUnit.Text;
            string street = txtStreet.Text;
            string suburb = txtSuburb.Text;
            string zip = txtZip.Text;
            string province = txtProvince.Text;
            string country = txtCountry.Text;
            string password = txtPassword.Text;
            string picture = picProfile.Image.ToString(); ;

            da.InsertUserDetails(name, surname, email, cell, unit, street, suburb, zip, province, country, password, picture);

            MessageBox.Show("Successfully Entered");

            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void picProfile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog findFile = new OpenFileDialog();
            findFile.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (findFile.ShowDialog() == DialogResult.OK)
            {
                picProfile.Image = new Bitmap(findFile.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
