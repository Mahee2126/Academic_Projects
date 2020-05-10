using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practice
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        

        private void LogIn_Click(object sender, EventArgs e)
        {
            Startpage stratpage = new Startpage();
            stratpage.Show();
            this.Hide();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            sign_up signUp = new sign_up();
            signUp.Show();
            this.Hide();
        }
    }
}
