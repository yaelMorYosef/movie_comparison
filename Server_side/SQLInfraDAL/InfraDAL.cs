using DalInfraContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace SQLInfraDAL
{
    public class InfraDAL : IInfraDAL
    {
        private SqlConnection getConnection(string connectionString)
        {
            var retval = new SqlConnection(connectionString);
            return retval;
        }
        private DataSet Exec(SqlConnection connection, string spName, params SqlParameter[] parameters)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (var parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            var retval = new DataSet();
            dataAdapter.Fill(retval);
            return retval;
        }

        public IDBConnection GetConnection(string connectionString)
        {
            return new SQLConnectionAdapter(connectionString);
        }



        public DataSet Exec(IDBConnection connection, string spName, params IDBParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = (connection as SQLConnectionAdapter).Connection;
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (var parameter in parameters)
            {
                var paramAdapter = parameter as SQLParameterAdapter;
                cmd.Parameters.Add(paramAdapter.Parameter);
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            var retval = new DataSet();
            dataAdapter.Fill(retval);
            return retval;

        }

        public IDBParameter GetParameter(string paramName, object paramValue)
        {   
            IDBParameter retval = new SQLParameterAdapter();
            retval.ParameterName = paramName;
            retval.Value = paramValue;
            return retval;
        }

   
    
    }
}

