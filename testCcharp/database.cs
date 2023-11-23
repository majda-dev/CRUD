using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace testCcharp
{
    internal class database
    {
        public static OleDbConnection db;
        public static String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source =" +
                      Application.StartupPath + "\\Ibrahim_Daanoun_Examen_Csharp.mdb";


        public static int insert(String query)
        {
            try
            {
                String connectionString = database.connectionString;
                db = new OleDbConnection(connectionString);
                db.Open();
                OleDbCommand cmd = new OleDbCommand(query, db);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                db.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static OleDbDataReader ExecuteQuery(String query)
        {
            try
            {
                String connectionString = database.connectionString;
                db = new OleDbConnection(connectionString);
                db.Open();
                OleDbCommand cmd = new OleDbCommand(query, db);
                OleDbDataReader rs = cmd.ExecuteReader();
                cmd.Dispose();
                return rs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void close()
        {
            db.Close();
        }
    }
}
