using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Shared;

namespace OData.Controllers
{
    [Route("api")]
    public class ActorsController : ODataController
    {
        private readonly ImdbContext _imdbContext;

        public ActorsController(ImdbContext imdbContext)
        {
            _imdbContext = imdbContext;
        }

        [HttpGet("actors")]
        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(_imdbContext.Actors);
        }

        [HttpGet("actors({key})")]
        [EnableQuery]
        public ActionResult Get([FromODataUri] int key)
        {
            var item = _imdbContext.Actors.SingleOrDefault(d => d.Id.Equals(key));

            if (item is null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
