using Microsoft.Data.SqlClient;

namespace S2S.Components.Models.Utils
{
    public interface OpstiDomenskiObjekat
    {
        string NazivTabele { get; }
        string Vrednosti { get; }

        string WhereUslov {  get; }

        string UpdateVrednosti { get; }

        List<OpstiDomenskiObjekat> GetReaderList(SqlDataReader reader);

    }
}
