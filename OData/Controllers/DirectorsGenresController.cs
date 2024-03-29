﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace OData.Controllers
{
    [Route("api")]
    public class DirectorsGenresController : ODataController
    {
        private readonly ImdbContext _imdbContext;

        public DirectorsGenresController(ImdbContext imdbContext)
        {
            _imdbContext = imdbContext;
        }

        [HttpGet("directorsGenres")]
        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(_imdbContext.DirectorsGenres);
        }
    }
}