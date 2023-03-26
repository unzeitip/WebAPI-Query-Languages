using JsonApi.Definitions;
using JsonApiDotNetCore.Configuration;
using Microsoft.EntityFrameworkCore;
using Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ImdbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("imdb")));

// Compose key entites have to have set default property to sort by
builder.Services.AddResourceDefinition<RoleDefinition>();
builder.Services.AddResourceDefinition<DirectorsGenreDefinition>();
builder.Services.AddResourceDefinition<MoviesGenreDefinition>();

builder.Services.AddJsonApi<ImdbContext>(options =>
{
    options.Namespace = "api";
    options.IncludeExceptionStackTraceInErrors = true;
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.UseJsonApi();

app.MapControllers();

app.Run();