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
    public partial class Form1 : Form
    {
        
        string UserName = "19-40077-1";
        string password = "kawsar";

        string UN;
        string Pass;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UN = UserNameBox1.Text;
            Pass = PasswordBox2.Text;

            if (string.Equals(UN, UserName)==true && string.Equals(Pass,password))
            {
                this.Hide();
                label1.Text = " ok";
                AddUser f = new AddUser();
                f.Show();
            }
            else
            {
                MessageBox.Show("incorrect password or username");
            }
        }
    }
}
