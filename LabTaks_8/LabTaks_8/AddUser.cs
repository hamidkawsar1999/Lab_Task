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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUserButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration f = new Registration();
            f.Show();
        }
    }
}
