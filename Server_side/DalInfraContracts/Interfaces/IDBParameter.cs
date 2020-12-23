using System;
using System.Collections.Generic;
using System.Text;

namespace DalInfraContracts.Interfaces
{
    public interface IDBParameter
    {
        string ParameterName { get; set; }
        object Value { get; set; }
    }
}
