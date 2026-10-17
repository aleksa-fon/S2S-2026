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
    }
}
