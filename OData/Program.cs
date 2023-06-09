using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OData;
using OData.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ImdbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("imdb")));

builder.Services.AddControllers().AddOData(
    options => options.EnableQueryFeatures(null)
    .AddRouteComponents("api", GetEdmModel()));

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();

static IEdmModel GetEdmModel()
{
    var modelBuilder = new ODataConventionModelBuilder();
    modelBuilder.EntitySet<Actor>("actors");

    modelBuilder.EntitySet<Movie>("movies");

    modelBuilder.EntitySet<Director>("directors");

    modelBuilder.EntityType<Role>().HasKey(r => new { r.ActorId, r.MovieId, r.RoleName });
    modelBuilder.EntitySet<Role>("roles");

    modelBuilder.EntityType<MoviesGenre>().HasKey(e => new { e.MovieId, e.Genre });
    modelBuilder.EntitySet<MoviesGenre>("moviesGenre");

    modelBuilder.EntityType<DirectorsGenre>().HasKey(e => new { e.DirectorId, e.Genre });
    modelBuilder.EntitySet<DirectorsGenre>("directorsGenre");

    return modelBuilder.GetEdmModel();
}