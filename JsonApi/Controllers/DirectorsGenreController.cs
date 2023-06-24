using JsonApi.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;

namespace JsonApi.Controllers
{
    public class DirectorsGenreController : JsonApiController<DirectorsGenre, int>
    {
        public DirectorsGenreController(IJsonApiOptions options, IResourceGraph resourceGraph, ILoggerFactory loggerFactory, IResourceService<DirectorsGenre, int> resourceService)
            : base(options, resourceGraph, loggerFactory, resourceService)
        {
        }
    }
}