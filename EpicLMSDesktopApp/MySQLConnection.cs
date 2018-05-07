using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EpicLMSDesktopApp
{
    class MySQLConnection
    {
        public static MySqlConnection openCon()
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost; DATABASE=epiclms; UID=root; PASSWORD=CS123+");
            try
            {
                con.Open();
                return con;
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
                return con;
            }




            /*
            try
            {
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
             */
        }
        
        public static bool closeCon(MySqlConnection con)
        {
            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
