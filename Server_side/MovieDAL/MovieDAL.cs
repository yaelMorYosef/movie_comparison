using DalInfraContracts.Interfaces;
using DalParametersConverter;
using FactoryContracts;
using Movie_Comparison.DTO;
using MoviesContracts.DTO;
using MoviesContracts.DTO.Request;
using MoviesContracts.DTO.Response;
using MoviesContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace MovieDAL
{
    [RegisterAttribute(Policy.transient, typeof(IMovieDAL))]

    public class MovieDAL : IMovieDAL


    {


        IInfraDAL _dal;
        DBParameterConverter _paramConverter;
        IDBConnection connection;
        string conString = "Server = DESKTOP-RMGMK9A\\SQLEXPRESS; Database = Movie_Comparison; Trusted_Connection = True;";
       
        public MovieDAL(IInfraDAL dal)
        {
            _dal = dal;
            _paramConverter = new DBParameterConverter(_dal);
             connection = _dal.GetConnection(conString);
        }
        public MovieResponse Create_movie(MovieRequest request)
        {

        

            var parameters = _paramConverter.ConvertToParameters(request.Movie);

            var MovieResult = _dal.Exec(connection, "Create_movie", parameters);

            CreateMovieResponseOK retval = new CreateMovieResponseOK();

            return retval;

        }

      

        public MovieResponse GetSortMovieByCreationDate(ListToSortRequest request)
        {

           
            NoMovieExist retval = new NoMovieExist();
            if (request != null)
            {
                var list = request.ListToSort;
                var sList= list.OrderBy(m => m.Creation_date).ToList();
                sList.Reverse();
                return new GetSortMovieByCreationDate(sList);
               
            }
            return retval;


        }

  
        public MovieResponse GetSortMovieByname(ListToSortRequest request)
        {
           

            NoMovieExist retval = new NoMovieExist();
            if (request != null)
            {
                var list = request.ListToSort;
                var sList = list.OrderBy(m => m.Movie_name).ToList();
                return new GetSortMovieByname(sList);


            }
            return retval;
        }

     

        public MovieResponse GetSortMovieByNumOfVotes(ListToSortRequest request)
        {
  

            NoMovieExist retval = new NoMovieExist();
            if (request != null)
            {
                var list = request.ListToSort;
                var sList = list.OrderBy(m => m.Number_of_votes).ToList();
                sList.Reverse();
                return new GetSortMovieByNumOfVotes(sList);
            }
            return retval;
        }

     

        public MovieResponse GetSortMovieByRating(ListToSortRequest request)
        {
        
            NoMovieExist retval = new NoMovieExist();
            if (request != null)
            {
                var list = request.ListToSort;
                var sList = list.OrderBy(m => m.Rating).ToList();
                sList.Reverse();
                return new GetSortMovieByRating(sList);

            }
            return retval;


        }

   

        public MovieResponse Get_All_movies()
        {

          

            var movieResult = _dal.Exec(connection, "Get_All_movies");
            var movies = _paramConverter.ConvertToDTO(movieResult);
            GetAllMoviesResponseOK retval = new GetAllMoviesResponseOK(movies);
            if (movieResult.Tables[0].Rows.Count == 0)
            {
                return new NoMovieExist();
            }
           

            return retval;
        }



        public MovieResponse Get_movie(MovieRequest request)
        {
            GetMovieRequeste req = new GetMovieRequeste();
            req.movie_name = (request as GetMovieRequeste).movie_name;

          
            var movieName = _paramConverter.ConvertToParameter(req, "Movie_name");
            var movieResult = _dal.Exec(connection, "Get_movie", movieName);
            List<MovieDTO> retval = new List<MovieDTO>();
            retval = _paramConverter.ConvertToDTO(movieResult);
            GetMovieResponseOK ret = new GetMovieResponseOK(retval);
            if (movieResult.Tables[0].Rows.Count == 0)
            {
                //movie is not existed
                return new NoMovieExist();
            }

            return ret;
        }

      
        public MovieResponse Update_movie(MovieRequest request)
        {
          
            var parameters = _paramConverter.ConvertToParameters(request.Movie);
            var MovieResult = _dal.Exec(connection, "Update_movie", parameters);
            UpdateMovieResponseOK retval = new UpdateMovieResponseOK();

            return retval;
        }

    }
}
