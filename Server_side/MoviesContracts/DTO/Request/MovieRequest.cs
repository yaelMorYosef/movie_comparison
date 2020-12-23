using DalInfraContracts;
using MoviesContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Comparison.DTO
{
    public class MovieRequest
    {
        public MovieDTO Movie { get; set; }

    }
    //public class GetRatingRequeste : MovieRequest
    //{
    //    [DBParameter("Rating")]
    //    public int Rating { get; set; }
    //}
    
    //public class GetMovieRequeste : MovieRequest
    //{
    //    [DBParameter("Movie_name")]
    //    public string movie_name { get; set; }
    //}
    //public class ListToSortRequest : MovieRequest
    //{     

    //    public List<MovieDTO> ListToSort;

    //}




}
