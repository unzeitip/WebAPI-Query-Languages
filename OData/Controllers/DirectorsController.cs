using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Shared.Models;

namespace OData.Controllers
{
    [Route("api")]
    public class DirectorsController : ODataController
    {
        private readonly ImdbContext _imdbContext;

        public DirectorsController(ImdbContext imdbContext)
        {
            _imdbContext = imdbContext;
        }

        [HttpGet("directors")]
        [HttpGet("directors/$count")]
        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(_imdbContext.Actors);
        }

        [HttpGet("directors({key})")]
        [EnableQuery]
        public ActionResult Get([FromODataUri] int key)
        {
            var item = _imdbContext.Directors.SingleOrDefault(d => d.Id.Equals(key));

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
