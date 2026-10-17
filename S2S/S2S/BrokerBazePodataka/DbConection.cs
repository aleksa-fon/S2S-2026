using Microsoft.Data.SqlClient;

namespace S2S.BrokerBazePodataka
{
    public class DbConection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DbConection()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Igraci;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();

        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {

            transaction.Rollback();
        }  

        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }

        public void Add()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Insert";
        }

       
    }
}
