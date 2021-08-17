using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class StorageAdministratorSQLServer : IStorageAdministrator
    {
        Broker broker = new Broker();
        public List<Administrator> GetAll()
        {
            /* try
             {
                 broker.OpenConnection();
                 return broker.GetAll();
             }
             finally
             {
                 broker.CloseConnection();
             }*/
            throw new Exception();
        }
    }
}
