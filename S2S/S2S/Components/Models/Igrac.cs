using Microsoft.Data.SqlClient;
using S2S.Components.Models.Utils;

namespace S2S.Components.Models
{
    public class Igrac : OpstiDomenskiObjekat
    {
        public string Nadimak { get; set; }
        public string Lozinka { get; set; }

        public string NazivTabele => "Igrac";

        public string Vrednosti => $"'{Nadimak}', '{Lozinka}'";

        public string WhereUslov  {get; set;}

        public string UpdateVrednosti {get; set;}

        public List<OpstiDomenskiObjekat> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
