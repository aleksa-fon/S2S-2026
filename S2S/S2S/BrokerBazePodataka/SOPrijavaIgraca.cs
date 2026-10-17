using S2S.Components.Models;
using System.Linq;

namespace S2S.BrokerBazePodataka
{
    public class SOPrijavaIgraca : SOBase
    {
        private Igrac igrac;
        public Igrac Result;

        public SOPrijavaIgraca(Igrac i)
        {
            this.igrac = i;
        }
        public override void SOFunction()
        {
            igrac.WhereUslov = $"Nadimak = '{igrac.Nadimak}' and Lozinka = '{igrac.Lozinka}'";
            List<Igrac> Lista = broker.GetByCondition(igrac).Cast<Igrac>().ToList();
            Result = Lista.FirstOrDefault();
            if (Result == null) {
                throw new Exception("Ne postoji igrač sa ovim kredencijalima");
            }
        }
    }
}
