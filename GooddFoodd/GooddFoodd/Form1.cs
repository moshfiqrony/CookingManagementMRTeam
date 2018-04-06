using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GooddFoodd;
using MySql.Data.MySqlClient;

namespace GooddFoodd
{
    public partial class Login : Form
    {
        Connector SQLConn = new Connector();
        public Login()
        {
            InitializeComponent();
        }

        //code for what will happend on form load
        private void Login_Load(object sender, EventArgs e)
        {
            /*
            MainPanel mp = new MainPanel();
            mp.Owner = this;
            this.Hide();
            mp.ShowDialog();
            */
            LoginFooter.Text = "All Rights Reserved To Goodd Foodd " + DateTime.Now.Year + " | Developed By MR TEAM";
            try
            {
                Connector conn = new Connector();
                MySqlConnection con = new MySqlConnection(conn.SQL);
                con.Open();
                AlertPanel.Visible = true;
                AlertLabel.Text = "Database Connected";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //mouse click on uid make it empty
        private void UID_MouseClick(object sender, MouseEventArgs e)
        {
            UID.Text = "";
        }

        //mouse click on pass make it empty and pass char
        private void UID_Leave(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.UseSystemPasswordChar = true;
        }

        //register button open register box
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register openform = new Register();
            openform.Owner = this;
            openform.ShowDialog();
        }

        //pass field leave focus radio button
        private void Password_Leave(object sender, EventArgs e)
        {
            Admin.Focus();
        }

        //radio leave focus login button
        private void Admin_Leave(object sender, EventArgs e)
        {
            LoginBtn.Focus();
        }

        //lonin button click even
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UID.Text != "" && Password.Text != "" && (Admin.Checked != false || User.Checked != false)) //checking empty palce
            {
                int pwr=-1,Valid=0;
                AlertPanel.Visible = false;

                //cheking admin
                if(Admin.Checked == true)
                {
                    pwr = 1;
                } else if(User.Checked == true)
                {
                    pwr = 0;
                }

                //executing query
                MySqlConnection Connect = new MySqlConnection(SQLConn.SQL);
                Connect.Open();
                MySqlCommand cmd = Connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM `authentication` WHERE `UID` = '"+UID.Text+"' AND `PWSD` = '"+Password.Text+"' AND `PWR` = '"+pwr+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                Valid = Convert.ToInt32(dt.Rows.Count.ToString());

                //checking valid user
                if (Valid == 1)
                {
                    MainPanel mp = new MainPanel();
                    mp.Owner = this;
                    this.Hide();
                    mp.ShowDialog();
                }
                else
                {
                    AlertPanel.Visible = true;
                    AlertLabel.Text = "Invalid Username OR Password";
                }
            }
            else
            {
                AlertPanel.Visible = true;
                AlertLabel.Text = "PLease Fill All Field";
            }
        }
    }
}
