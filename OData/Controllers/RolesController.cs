using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System.Linq;

namespace OData.Controllers
{
    [Route("api")]
    public class RolesController : ODataController
    {
        private readonly ImdbContext _imdbContext;
        public RolesController(ImdbContext imdbContext)
        {
            _imdbContext = imdbContext;
        }

        [HttpGet("roles")]
        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(_imdbContext.Roles);
        }
    }
}
