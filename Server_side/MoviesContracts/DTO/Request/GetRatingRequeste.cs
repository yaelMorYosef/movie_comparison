using DalInfraContracts;
using Movie_Comparison.DTO;

namespace MoviesContracts.DTO.Request
{
  

        public class GetRatingRequeste : MovieRequest
        {
            [DBParameter("Rating")]
            public int Rating { get; set; }
        }
    }

