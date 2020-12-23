using DalInfraContracts;
using Movie_Comparison.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO.Request
{
   public class GetMovieRequeste: MovieRequest
    {
        [DBParameter("Movie_name")]
        public string movie_name { get; set; }
    }
}
