using Movie_Comparison.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO.Response
{
    public class GetMovieResponseOK : MovieResponse
    {

        public List<MovieDTO> movies { get; set; }
        
        public GetMovieResponseOK(List<MovieDTO> m)
        {
            movies = m;
        }

    }
}
