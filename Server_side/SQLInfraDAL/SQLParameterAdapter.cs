using DalInfraContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SQLInfraDAL
{
    public class SQLParameterAdapter : IDBParameter
    {
        public SqlParameter Parameter { get; }
        public SQLParameterAdapter()
        {
            Parameter = new SqlParameter();
        }
        public string ParameterName
        {
            get => Parameter.ParameterName;
            set => Parameter.ParameterName = value;
        }
        public object Value
        {
            get => Parameter.Value;
            set => Parameter.Value = value;
        }
    }
}
