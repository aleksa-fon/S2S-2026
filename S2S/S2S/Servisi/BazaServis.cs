using S2S.BrokerBazePodataka;
using S2S.Components.Models;

namespace S2S.Servisi
{
    public class BazaServis
    {
        public Igrac DodajIgraca(Igrac igrac) { 
        SODodajIgraca so = new SODodajIgraca(igrac);
            so.ExecuteSystemOperation();
            return so.Result;
        }

        public Igrac? PrijavaIgraca(Igrac igrac)
        {
            SOPrijavaIgraca so = new SOPrijavaIgraca(igrac);
            so.ExecuteSystemOperation();
            return so.Result;   
        }
    }
}
