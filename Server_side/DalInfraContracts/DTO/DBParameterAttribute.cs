using System;

namespace DalInfraContracts
{
    public class DBParameterAttribute:Attribute
    {

        public string ParameterName { get; }
        public DBParameterAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}
