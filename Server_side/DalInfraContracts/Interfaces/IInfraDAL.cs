using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DalInfraContracts.Interfaces
{
   public  interface IInfraDAL
    {
      
        IDBConnection GetConnection(string connectionString);
        IDBParameter GetParameter(string paramName, object paramValue);
        DataSet Exec(IDBConnection connection, string spName, params IDBParameter[] parameters);
    }
}
