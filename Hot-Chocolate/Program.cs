using Hot_Chocolate;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ImdbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("imdb")));

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .RegisterDbContext<ImdbContext>(DbContextKind.Synchronized)
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.MapGraphQL("/api");

app.Run();