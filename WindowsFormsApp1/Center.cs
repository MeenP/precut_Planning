using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    class Center
    {
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        
        public static SqlDataReader data_reader;
        public static DataSet data_set;
        public static SqlDataAdapter data_adpater;
        public static BindingSource binding_source;
        // Insert,Select,Update,Delete command

        public static string sql;
        public static int Location=1;
        public static string Identity;
        public static string LocationString;
        public static string GetconnectionStringDB_Windsor(int Location)
        {
            string Precut_Line;
            string _identity;

            if (Location == 2)
            {
                Precut_Line = ConfigurationManager.AppSettings["Precut_Line2"].ToString();
                _identity = ConfigurationManager.AppSettings["Identity2"].ToString();
                LocationString = "โรงบน 2";

            }
            else if(Location == 3)
            {
                Precut_Line = ConfigurationManager.AppSettings["Precut_Line3"].ToString();
                _identity = ConfigurationManager.AppSettings["Identity3"].ToString();
                LocationString = "โรง 3 T&T ";

            }
            else
            {
                Precut_Line = ConfigurationManager.AppSettings["Precut_Line1"].ToString();
                _identity = ConfigurationManager.AppSettings["Identity1"].ToString();
                LocationString = "โรงล่าง 1";
            }

            string constring = Precut_Line;
            Identity = _identity;
            return constring;
        }

        public static string GetconnectionStringDB_LinkQV(int Location)
        {
            string Precut_Line;
            string _identity;

            if (Location == 2)
            {
                Precut_Line = ConfigurationManager.AppSettings["LinkQV_Line2"].ToString();
                _identity = ConfigurationManager.AppSettings["Identity2"].ToString();

            }
            else if(Location == 3)
            {
                Precut_Line = ConfigurationManager.AppSettings["LinkQV_Line3"].ToString();
                _identity = ConfigurationManager.AppSettings["Identity3"].ToString();

            }
            else
            {
                Precut_Line = ConfigurationManager.AppSettings["LinkQV_Line1"].ToString();
                _identity = ConfigurationManager.AppSettings["Identity1"].ToString();
            }

            string constring = Precut_Line;
            Identity = _identity;
            return constring;
        }

        public static void openConnection_LinkQvDB()
        {
            if (con.State == ConnectionState.Open)
            {
                return;
            }


            if (Location ==2)
            {
                con.ConnectionString = GetconnectionStringDB_LinkQV(2);
                con.Open();
            }
            else if(Location == 3)
            {
                con.ConnectionString = GetconnectionStringDB_LinkQV(3);
                con.Open();
            }
            else
            {
                con.ConnectionString = GetconnectionStringDB_LinkQV(1);
                con.Open();
            }
        }

        public static void openConnection_WindsorDB()
        {
            cmd.CommandTimeout = 600;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            if (Location == 2)
            {
                con.ConnectionString = GetconnectionStringDB_Windsor(2);
                con.Open();
            }
            else if (Location == 3)
            {
                con.ConnectionString = GetconnectionStringDB_Windsor(3);
                con.Open();
            }
            else
            {
                con.ConnectionString = GetconnectionStringDB_Windsor(1);
                con.Open();
            }
        }

        public static void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                //  MessageBox.Show("The connection is: " + con.State);
            }
        }

        public static string GetServerIP()
        {
            string ip = ConfigurationManager.AppSettings["Identity"].ToString();
            return ip;
        }
     }
}
