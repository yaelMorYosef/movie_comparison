using Movie_Comparison.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO.Response
{
    public class GetSortMovieByCreationDate : MovieResponse
    {
        public List<MovieDTO> movies { get; set; }
        public GetSortMovieByCreationDate(List<MovieDTO> m)
        {
            movies = m;
        }
    }
}
