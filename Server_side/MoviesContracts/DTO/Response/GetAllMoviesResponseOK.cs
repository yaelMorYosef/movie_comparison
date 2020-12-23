using Movie_Comparison.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO
{
    public class GetAllMoviesResponseOK : MovieResponse
    {
        public List<MovieDTO> movies{ get; set; }
   
        public GetAllMoviesResponseOK(List<MovieDTO> m)
        {
            this.movies = m;
        }
    }
}
