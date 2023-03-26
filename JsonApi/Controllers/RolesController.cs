using JsonApi.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;

namespace OData.Controllers
{
    public class RolesController : JsonApiController<Role, dynamic>
    {
        public RolesController(IJsonApiOptions options, IResourceGraph resourceGraph, ILoggerFactory loggerFactory, IResourceService<Role, dynamic> resourceService)
            : base(options, resourceGraph, loggerFactory, resourceService)
        {
        }
    }
}