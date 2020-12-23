using DalInfraContracts;
using DalInfraContracts.Interfaces;
using MoviesContracts.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace DalParametersConverter
{
    public class DBParameterConverter
    {
        IInfraDAL _dal;
        public DBParameterConverter(IInfraDAL dal)
        {
            _dal = dal;
        }
        public IDBParameter ConvertToParameter(object dto, string parameterName)
        {
            IDBParameter retval = null;
            foreach (var property in dto.GetType().GetProperties())
            {
                var attribute = property.GetCustomAttribute<DBParameterAttribute>();
                if (attribute != null)//This property is a parameter 
                {
                    if (attribute.ParameterName.Equals(parameterName))
                    {
                        var paramValue = property.GetValue(dto);
                        ///Create Parameter 
                        retval = _dal.GetParameter(parameterName, paramValue);
                        break;

                    }

                }
            }
            return retval;
        }
        public IDBParameter[] ConvertToParameters(object dto)
        {
         
            List<IDBParameter> retval = new List<IDBParameter>();
            //for Each property in DTO check for DBParameter Atribute
    
            foreach (var property in dto.GetType().GetProperties())
            {
                var attribute = property.GetCustomAttribute<DBParameterAttribute>();
                if (attribute != null)//This property is a parameter 
                {
                    //get param name from attribute
                    var paramName = attribute.ParameterName;
                    //invoke GetValue for example: if propety is UserID the invoke will execute 
                    //paramValue = dto.UserID 
                    var paramValue = property.GetValue(dto);
                    ///Create Parameter 
                    var parameter = _dal.GetParameter(paramName, paramValue);
                    retval.Add(parameter);
                }

            }
            return retval.ToArray();
        }

        public List<MovieDTO> ConvertToDTO(DataSet parameters)
        {
            List<MovieDTO> retval = new List<MovieDTO>();
            foreach (DataRow row in parameters.Tables[0].Rows)
            {
                retval.Add(new MovieDTO()
                {
                    Movie_name = (string)row[0],
                    IMDB_Url = (string)row[1],
                    Rating = (int)row[2],
                    Number_of_votes = (int)row[3],
                    Movie_id = (int)row[4],
                    Creation_date = (DateTime)row[5]
                });
            }
 
            return retval;

        }
    }
}
