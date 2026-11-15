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
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();

            btregister.Click += btregister_Click;

            tbpassr.UseSystemPasswordChar = true;
            tbrepassr.UseSystemPasswordChar = true;

            linksignin.LinkClicked += linksignin_LinkClicked;
        }


        private void linksignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            string fullname = tbfnr.Text.Trim();
            string username = tbuseridr.Text.Trim();
            string password = tbpassr.Text;
            string repassword = tbrepassr.Text;

            if(fullname == "" || username == "" || password == "" || repassword == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(password != repassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if(password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection con = database.GetConnection())    
                {
                    con.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";

                    using(MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, con))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", username);
                        int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = "INSERT INTO Users (username,password,full_name,user_role,is_active )" + "VALUES (@username, @password, @full_name, @user_role, @is_active)";

                    using (MySqlCommand cmd =  new MySqlCommand(query, con))
                    {
                        string PasswordHash = PasswordHelper.HashPassword(password);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", PasswordHash);
                        cmd.Parameters.AddWithValue("@full_name", fullname);
                        cmd.Parameters.AddWithValue("@user_role", "Staff");
                        cmd.Parameters.AddWithValue("@is_active", 1);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User regsitered successfully." , "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbfnr.Clear();
                            tbuseridr.Clear();
                            tbpassr.Clear();
                            tbrepassr.Clear();
                            
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            
                            MessageBox.Show("Failes to register user.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
