using DalInfraContracts.Interfaces;
using DalParametersConverter;
using FactoryContracts;
using Movie_Comparison.DTO;
using MoviesContracts.DTO;
using MoviesContracts.DTO.Response;
using MoviesContracts.DTO.Request;

using MoviesContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace MovieServiceImpl
{
    [RegisterAttribute(Policy.transient, typeof(IMovieService))]

    public class MovieService : IMovieService
    {


        IMovieDAL _dal;

        public MovieService(IMovieDAL dal)
        {
            _dal = dal;


        }

        public MovieResponse Create_movie(MovieRequest request)
        {

            //המרה לDTO
            MovieRequest movieRequest = new MovieRequest() { Movie = request.Movie };
            try
            {
                return _dal.Create_movie(movieRequest);


            }
            catch
            {
                return new ResponseERR();

            }


        }




        public MovieResponse Get_movie(MovieRequest request)
        {


            try
            {
                return _dal.Get_movie(request);

            }
            catch
            {
                return new ResponseERR();

            }

        }

        public MovieResponse Get_All_movies()
        {

            try
            {

                return _dal.Get_All_movies();


            }
            catch
            {
                return new ResponseERR();

            }

        }

        public List<MovieDTO> ConvertToDTO(DataSet parameters)
        {
            List<MovieDTO> retval = new List<MovieDTO>();
            foreach (DataRow row in parameters.Tables[0].Rows)
            {
                retval.Add(new MovieDTO()
                {
                    Movie_name = (string)row[0],
                    IMDB_Url = (string)row[1],
                    Rating = (int)row[2],
                    Number_of_votes = (int)row[3],
                    Movie_id = (int)row[4],
                    Creation_date = (DateTime)row[5]
                });
            }

            return retval;

        }

        public MovieResponse Update_movie(MovieRequest request)
        {
            MovieRequest movieRequest = new MovieRequest() { Movie = request.Movie };
            movieRequest.Movie.Number_of_votes += 1;


            try
            {
                return _dal.Update_movie(movieRequest);


            }
            catch
            {
                return new ResponseERR();

            }
        }





        public MovieResponse GetSortMovieByname(ListToSortRequest request)
        {
            ListToSortRequest movieRequest = new ListToSortRequest() { ListToSort = request.ListToSort };


            try
            {
                return _dal.GetSortMovieByname(movieRequest);


            }
            catch
            {
                return new ResponseERR();


            }
        }


        public MovieResponse GetSortMovieByRating(ListToSortRequest request)
        {

            ListToSortRequest movieRequest = new ListToSortRequest() { ListToSort = request.ListToSort };

            try
            {
                return _dal.GetSortMovieByRating(movieRequest);


            }
            catch
            {
                return new ResponseERR();


            }
        }

        public MovieResponse GetSortMovieByCreationDate(ListToSortRequest request)
        {

            ListToSortRequest movieRequest = new ListToSortRequest() { ListToSort = request.ListToSort };

            try
            {
                return _dal.GetSortMovieByCreationDate(movieRequest);


            }
            catch
            {
                return new ResponseERR();


            }
        }

        public MovieResponse GetSortMovieByNumOfVotes(ListToSortRequest request)
        {

            ListToSortRequest movieRequest = new ListToSortRequest() { ListToSort = request.ListToSort };

            try
            {
                return _dal.GetSortMovieByNumOfVotes(movieRequest);


            }
            catch
            {
                return new ResponseERR();


            }

        }








    }
}
