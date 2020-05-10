using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Practice
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GUNVPBB;Initial Catalog=Invoice;Integrated Security=True");

        private void LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query1 = "SELECT Password From Admin_Info where Password = '" + Password.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query1, con);
                DataTable dt = new DataTable();

                SDA.Fill(dt);
                con.Close();
                if (dt.Rows[0] != null)
                {
                    MessageBox.Show("Enter another password");
                }

            }
            catch
            {
                con.Open();
                String query = "INSERT INTO Admin_Info (Name,Password) VALUES('" + UserName.Text + "','" + Password.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("INSERTED SUCCESSFULLY !! ");

                Start strat = new Start();
                strat.Show();
                this.Hide();
                //this.Close();
            }
        }
    }
}
