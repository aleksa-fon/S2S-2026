using S2S.Components.Models;

namespace S2S.BrokerBazePodataka
{
    public class SODodajIgraca : SOBase
    {
        private Igrac igrac;
        public Igrac? Result;

        public SODodajIgraca(Igrac i)
        {
            this.igrac = i;
        }
        public override void SOFunction()
        {
            igrac.WhereUslov = $"Nadimak = '{igrac.Nadimak}'";
            List<Igrac> Lista = broker.GetByCondition(igrac).Cast<Igrac>().ToList();
            if (Lista.FirstOrDefault() == null)
            {
                broker.Add(igrac);
                Result = igrac;
            }
            else
            {
                Result = null;
            }
        }
    }
}
