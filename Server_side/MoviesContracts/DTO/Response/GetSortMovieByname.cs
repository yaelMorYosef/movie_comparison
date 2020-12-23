using Movie_Comparison.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO.Response
{
    public class GetSortMovieByname : MovieResponse
    {
        public List<MovieDTO> movies { get; set; }
        public GetSortMovieByname(List<MovieDTO> m)
        {
            movies = m;
        }
    }
}
