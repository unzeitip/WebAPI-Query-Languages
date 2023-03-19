using Shared.Models;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<Actor>("actors");
modelBuilder.EntitySet<Movie>("movies");
modelBuilder.EntitySet<Director>("directors");
modelBuilder.EntitySet<Role>("roles");

builder.Services.AddDbContext<ImdbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("imdb")));

builder.Services.AddControllers().AddOData(
    options => options.EnableQueryFeatures(null)
    .AddRouteComponents("api", modelBuilder.GetEdmModel()));

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();