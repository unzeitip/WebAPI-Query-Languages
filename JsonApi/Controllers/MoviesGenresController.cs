using JsonApi.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;

namespace JsonApi.Controllers
{
    public class MoviesGenresController : JsonApiController<MoviesGenre, int>
    {
        public MoviesGenresController(IJsonApiOptions options, IResourceGraph resourceGraph, ILoggerFactory loggerFactory, IResourceService<MoviesGenre, int> resourceService)
            : base(options, resourceGraph, loggerFactory, resourceService)
        {
        }
    }
}