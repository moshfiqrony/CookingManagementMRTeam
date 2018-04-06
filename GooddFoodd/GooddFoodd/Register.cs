using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GooddFoodd
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            LoginFooter.Text = "All Rights Reserved To Goodd Foodd " + DateTime.Now.Year + " | Developed By MR TEAM";
        }

        private void UID_Leave(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.UseSystemPasswordChar = true;
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            ConfirmPassword.Text = "";
            ConfirmPassword.UseSystemPasswordChar = true;
            ConfirmPassword.Focus();
        }

        private void UID_Click(object sender, EventArgs e)
        {
            UID.Text = "";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void RegisterBtn_Leave(object sender, EventArgs e)
        {
            LoginBtn.Focus();
        }

        private void ConfirmPassword_Leave(object sender, EventArgs e)
        {
            RegisterBtn.Focus();
        }

        //code for inserting value
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if(Password.Text == ConfirmPassword.Text)
            {
                Connector SqlConn = new Connector();
                MySqlConnection conn = new MySqlConnection(SqlConn.SQL);
                conn.Open();
                string query = "INSERT INTO `authentication` (`UID`, `PWSD`) VALUES ('"+UID.Text+"', '"+Password.Text+"')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    MessageBox.Show("Your Are Succesfully Registered", "Alert");
                    Login ln = new Login();
                    ln.ShowDialog();
                    
                    
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Alert");
                }
            }
            else
            {
                MessageBox.Show("Password Doesn't Match", "Alert");
            }
            
            
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
