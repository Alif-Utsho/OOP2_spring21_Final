using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = nametb.Text;
            string username = usernametb.Text;
            string email = emailtb.Text;
            string password = passwordtb.Text;

            if (name.Trim().Length==0 || username.Trim().Length == 0 || password.Trim().Length == 0 || email.Trim().Length == 0)
            {
                MessageBox.Show("Enter all required field");
            }
            else
            {

                string connectionString = @"Server=LAPTOP-LSE8ACET\SQL_SERVER;Database=OOP2_H_SP21;User Id=sa;Password=12345;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = string.Format("INSERT INTO users VALUES ('{0}', '{1}', '{2}', '{3}')", name, username, password, email);
                SqlCommand cmd = new SqlCommand(query, conn);
                var r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Data inserted");
                }
                else
                {
                    MessageBox.Show("Something is wrong");
                }
            }
        }
    }
}
