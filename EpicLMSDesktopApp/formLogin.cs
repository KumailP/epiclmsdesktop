﻿using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EpicLMSDesktopApp
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("SERVER=localhost; DATABASE=epiclms; UID=root; PASSWORD=root");
            try
            {
                con.Open();
                

                MessageBox.Show("Connection Open ! ");

                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                string query = "SELECT * from student WHERE email='" + email + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                DataTable dtb1 = new DataTable();
                dtb1.Load(dataReader);
                //cmd.ExecuteNonQuery();

                //new SqlDataAdapter(query, con).Fill(dtb1);
                if (dtb1.Rows.Count > 0)
                {
                    bool doesmatch = BCrypt.CheckPassword(password, dtb1.Rows[0][4].ToString());
                    if (doesmatch)
                    {
                        MessageBox.Show("Logged in successfully!");
                        xGrid.DataSource = dtb1;
                    }
                    else
                    {
                        MessageBox.Show("Unable to login!");
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
                
                
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                   case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                
            }






            try
            {
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}