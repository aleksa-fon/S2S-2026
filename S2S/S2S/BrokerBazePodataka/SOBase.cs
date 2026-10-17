namespace S2S.BrokerBazePodataka
{
    public abstract class SOBase
    {
        private Broker broker;

        public SOBase()
        {
            broker = new Broker();
        }

        public void ExecuteSystemOperation()
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                SOFunction();
                broker.Commit();
            }
            catch (Exception ex) { 
            broker.Rollback();
            }
            finally {
            broker.CloseConnection();
            }
        }

        public abstract void SOFunction();

    }
}
