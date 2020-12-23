using Movie_Comparison.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO.Response
{
    public class GetSortMovieByNumOfVotes : MovieResponse
    {
        public List<MovieDTO> movies { get; set; }
        public GetSortMovieByNumOfVotes(List<MovieDTO> m)
        {
            movies = m;
        }
    }

}