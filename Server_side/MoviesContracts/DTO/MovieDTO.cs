using DalInfraContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContracts.DTO
{
    public class MovieDTO
    {

        [DBParameter("Movie_name")]
        public string Movie_name { get; set; }
        [DBParameter("IMDB_Url")]
        public string IMDB_Url { get; set; }
        [DBParameter("Rating")]
        public int Rating { get; set; }
        [DBParameter("Number_of_votes")]
        public int Number_of_votes { get; set; }
        //[DBParameter("Movie_id")]
        public int Movie_id { get; set; }
        [DBParameter("Creation_date")]
        public DateTime Creation_date { get; set; }


    }
}
