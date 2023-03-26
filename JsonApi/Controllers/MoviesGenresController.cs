using JsonApi.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;

namespace OData.Controllers
{
    public class MoviesGenresController : JsonApiController<MoviesGenre, dynamic>
    {
        public MoviesGenresController(IJsonApiOptions options, IResourceGraph resourceGraph, ILoggerFactory loggerFactory, IResourceService<MoviesGenre, dynamic> resourceService)
            : base(options, resourceGraph, loggerFactory, resourceService)
        {
        }
    }
}