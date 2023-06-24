using JsonApi;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Resources.Annotations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ImdbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("imdb")));

builder.Services.AddJsonApi<ImdbContext>(options =>
{
    options.DefaultPageSize = null;
    options.Namespace = "api";
    options.IncludeExceptionStackTraceInErrors = true;

    options.IncludeTotalResourceCount = false;
    options.RelationshipLinks = LinkTypes.None;
    options.ResourceLinks = LinkTypes.None;
    options.TopLevelLinks = LinkTypes.None;
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.UseJsonApi();

app.MapControllers();

app.Run();