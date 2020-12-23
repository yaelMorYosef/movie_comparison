using DalInfraContracts.Interfaces;
using System;
using System.Data.SqlClient;

namespace SQLInfraDAL
{
    public class SQLConnectionAdapter: IDBConnection
    {
        public SqlConnection Connection { get; }
        public SQLConnectionAdapter(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
        }

    }
}
