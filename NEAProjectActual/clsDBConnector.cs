using System;
using System.Data.OleDb;

namespace NEAProjectActual
{
    public class clsDBConnector
    {
        private OleDbConnection conn;
        private string dbProvider;
        private string dbSource;

        public clsDBConnector()
        {
            dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
            dbSource = @"Data Source=" + Environment.CurrentDirectory + @"\ADSBDatabase.accdb";
            conn = new OleDbConnection(dbProvider + dbSource);
        }

        public OleDbConnection GetConnection()
        {
            return conn;
        }

        public void OpenConnection()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error opening database connection: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
