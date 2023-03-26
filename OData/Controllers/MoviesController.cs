using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Shared;

namespace OData.Controllers
{
    [Route("api")]
    public class MoviesController : ODataController
    {
        private readonly ImdbContext _imdbContext;

        public MoviesController(ImdbContext imdbContext)
        {
            _imdbContext = imdbContext;
        }

        [HttpGet("movies")]
        [HttpGet("movies/$count")]
        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(_imdbContext.Movies);
        }

        [HttpGet("movies({key})")]
        [EnableQuery]
        public ActionResult Get([FromODataUri] int key)
        {
            var item = _imdbContext.Movies.SingleOrDefault(d => d.Id.Equals(key));

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
