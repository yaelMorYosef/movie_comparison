using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Movie_Comparison.DTO;
using MoviesContracts.DTO;
using MoviesContracts.DTO.Request;
using MoviesContracts.DTO.Response;
using MoviesContracts.Interfaces;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movie_Comparison.Controllers
{


    [ApiController]
    [Route("api/[controller]/{action}")]

    public class MovieController : ControllerBase
    {


        IMovieService _ImovieService;

        public MovieController(IMovieService movieService)
        {
            _ImovieService = movieService;
        }
        // POST api/<MovieController>
        [HttpPost]
        public MovieResponse Create_movie([FromBody] GetMovieRequeste request)
        {
            return _ImovieService.Create_movie(request);

        }



        [HttpPost]
        public MovieResponse Get_movie([FromBody] GetMovieRequeste request)
            {
             return _ImovieService.Get_movie(request);



        }

        [HttpPost]
        public MovieResponse Update_movie([FromBody] MovieRequest request)
        {

               return  _ImovieService.Update_movie(request);
            

        }
        [HttpPost]
        public MovieResponse GetSortMovieByname([FromBody] ListToSortRequest request)
        {
           return _ImovieService.GetSortMovieByname(request);
            

            //var serializedParent = JsonConvert.SerializeObject(request);
           // ListToSortRequest c = JsonConvert.DeserializeObject<ListToSortRequest>(serializedParent);
           
    





        }
        [HttpGet]
        public MovieResponse Get_All_movies()
        {
           return _ImovieService.Get_All_movies();
            
        
        }

        [HttpPost]
        public MovieResponse GetSortMovieByRating([FromBody] ListToSortRequest request)
        {
              return _ImovieService.GetSortMovieByRating(request);
         


        }
        [HttpPost]
        public MovieResponse GetSortMovieByCreationDate([FromBody] ListToSortRequest request)
        {
            return _ImovieService.GetSortMovieByCreationDate(request);
          
     


        }
        [HttpPost]
        public MovieResponse GetSortMovieByNumOfVotes([FromBody] ListToSortRequest request)
        {

            return _ImovieService.GetSortMovieByNumOfVotes(request);
         
        }




    }
}
