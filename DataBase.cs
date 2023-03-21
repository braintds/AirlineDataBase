using System.Data.OleDb;
using System.Data;


namespace AirlineDataBase
{
    class DataBase
    {
        OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.AirlineDataBaseConnectionString);

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public OleDbConnection getConnection()
        {
            return this.connection;
        }
    }
}
