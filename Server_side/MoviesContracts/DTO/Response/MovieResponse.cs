using DalInfraContracts.Interfaces;
using MoviesContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Comparison.DTO
{
    public class MovieResponse
    {
        public string ResponseType { get; set; }
        public MovieResponse()
        {
            ResponseType = this.GetType().Name;
        }
    }
}
    //public class ResponseERR : MovieResponse
    //{

    //}
    //public class MovieExistsResponse : MovieResponse
    //{

    //}
    //public class CreateMovieResponseOK : MovieResponse
    //{
    //}
    //public class CreateMovieResponseNotOK : MovieResponse
    //{
    //}
    //public class UpdateMovieResponseOK : MovieResponse
    //{
    //}
    //public class UpdateMovieResponseNotOK : MovieResponse
    //{
    //}
    //public class DeleteMovieResponseOK : MovieResponse
    //{
    //}
    //public class DeleteMovieResponseNotOK : MovieResponse
    //{
    //}
    //public class GetMovieResponseOK : MovieResponse
    //{

    //    public List<MovieDTO> movies;
    //    public GetMovieResponseOK(List<MovieDTO> m)
    //    {
    //        movies = m;
    //    }
         
    //}
    //public class GetMovieResponseNotOK : MovieResponse
    //{
    //}
    //public class GetRatingMovieResponseOK : MovieResponse
    //{
    //    public List<MovieDTO> movies;
    //    public GetRatingMovieResponseOK(List<MovieDTO> m)
    //    {
    //        movies = m;
    //    }

    //}
    //public class GetRatingMovieResponseNotOK : MovieResponse
    //{
    //}
    //public class GetAllMoviesResponseOK : MovieResponse
    //{
    //    public List<MovieDTO> movies;
    //    public GetAllMoviesResponseOK(List<MovieDTO> m)
    //    {
    //        this.movies = m;
    //    }   
    //}
    //public class NoMovieExist : MovieResponse
    //{
    //}
    //public class GetSortMovieByname: MovieResponse
    //{
    //    public List<MovieDTO> movies;
    //    public GetSortMovieByname(List<MovieDTO> m)
    //    {
    //        movies = m;
    //    }
    //}

    //public class GetSortMovieByRating : MovieResponse
    //{
    //    public List<MovieDTO> movies;
    //    public GetSortMovieByRating(List<MovieDTO> m)
    //    {
    //        movies = m;
    //    }
    //}
    //public class GetSortMovieByCreationDate : MovieResponse
    //{
    //    public List<MovieDTO> movies;
    //    public GetSortMovieByCreationDate(List<MovieDTO> m)
    //    {
    //        movies = m;
    //    }
    //}

//    public class GetSortMovieByNumOfVotes : MovieResponse
//    {
//        public List<MovieDTO> movies;
//        public GetSortMovieByNumOfVotes(List<MovieDTO> m)
//        {
//            movies = m;
//        }
//    }
  
//}
