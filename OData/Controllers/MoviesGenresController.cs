using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Shared;
using System.Linq;

namespace OData.Controllers
{
    [Route("api")]
    public class MoviesGenresController : ODataController
    {
        private readonly ImdbContext _imdbContext;
        public MoviesGenresController(ImdbContext imdbContext)
        {
            _imdbContext = imdbContext;
        }

        [HttpGet("moviesGenres")]
        [HttpGet("moviesGenres/$count")]
        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(_imdbContext.MoviesGenres);
        }
    }
}
