using System.Configuration;

namespace Kerry.ITS.DB.Utility
{
    public class K3DRDBFactory : DBFactory
    {
        public K3DRDBFactory()
        {
            DBFactory.dbProviderName = ConfigurationManager.AppSettings["K3DataProvider"];
            DBFactory.dbConnectionString = ConfigurationManager.ConnectionStrings["K3DREntitiesADO"].ToString();
            this.connection = CreateConnection(dbProviderName, dbConnectionString);
        }
    }
}
