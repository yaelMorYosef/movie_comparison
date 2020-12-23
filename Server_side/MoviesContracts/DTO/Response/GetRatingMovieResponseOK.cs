using Movie_Comparison.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO.Response
{
    public class GetRatingMovieResponseOK : MovieResponse
    {
        public List<MovieDTO> movies { get; set; }
        public GetRatingMovieResponseOK(List<MovieDTO> m)
        {
            movies = m;
        }

    }
}