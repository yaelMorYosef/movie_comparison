using Movie_Comparison.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO.Request
{
    public class ListToSortRequest : MovieRequest
    {
        public List<MovieDTO> ListToSort { get; set; }
       

    }
}
