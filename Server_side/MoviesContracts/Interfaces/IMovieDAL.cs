using Movie_Comparison.DTO;
using MoviesContracts.DTO.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MoviesContracts.Interfaces
{
    public interface IMovieDAL
    {
        MovieResponse Create_movie(MovieRequest request);
      
        MovieResponse Get_movie(MovieRequest request);
        
        MovieResponse Update_movie(MovieRequest request);
        MovieResponse Get_All_movies();


        MovieResponse GetSortMovieByname(ListToSortRequest request);

        MovieResponse GetSortMovieByCreationDate(ListToSortRequest request);
 
        MovieResponse GetSortMovieByNumOfVotes(ListToSortRequest request);

     
        MovieResponse GetSortMovieByRating(ListToSortRequest request);




    }
}
