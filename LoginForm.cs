using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySqlConnector;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //sbtsignin.Click += btsignin_Click;

            tbpass.UseSystemPasswordChar = true;

            registerlink.LinkClicked += registerlink_LinkClicked;

        }

        private void txtdesc_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registerlink_Click_1(object sender, EventArgs e)
        {

        }

        private void btsignin_Click(object sender, EventArgs e)
        {
            string username = tbuserid.Text.Trim();
            string password = tbpass.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection con = database.GetConnection())
                {
                    con.Open();

                string query = "SELECT user_id, password, full_name, user_role, is_active " +
                                "FROM users WHERE username = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return;
                            }

                            string storedHash = reader["password"].ToString();
                             string fullname = reader["full_name"].ToString();
                            string role = reader["user_role"].ToString();
                            bool isActive = Convert.ToBoolean(reader["is_active"]);
                            int userid = Convert.ToInt32(reader["user_id"]);

                            if(!PasswordHelper.VerifyPassword(password, storedHash))
                            {
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return;
                            }

                            if(!isActive)
                            {
                                MessageBox.Show("Your account is inactive. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        UserSession.Start(userid, username, fullname, role);
                        MessageBox.Show($"Welcome, {fullname}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            reader.Close();

                            dashboard dash = new dashboard();
                            dash.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {

            }


        }

        private void registerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration register = new Registration();
            register.Show();
            this.Hide();
        }
    }
}
