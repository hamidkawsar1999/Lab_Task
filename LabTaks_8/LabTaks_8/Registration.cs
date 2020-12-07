using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTaks_8
{
    public partial class Registration : Form
    {
        public static string FirstName, LastName,EMAIL,ADDRESS,PHONE,SECURITYANSWER,ZIPCODE,City; 
        public Registration()
        {
            InitializeComponent();
        }

        private void Emaillabel_Click(object sender, EventArgs e)
        {
            Emaillabel.Text = "Email: ";
        }

        private void AccountInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstName=FirstNametextBox1.Text;
            LastName = LastNametextBox2.Text;
            EMAIL = MailTextBox3.Text;
            ADDRESS = AddressTextbox.Text;
            PHONE = PhoneTextBox.Text;
            SECURITYANSWER = SecurityAnswerTextBox.Text;
            ZIPCODE=ZipCodeTextBox5.Text;
            City = CityextBox.Text;
            ShowDetails f = new ShowDetails();
            f.Show();
        }
    }
}
