using Hot_Chocolate;
using HotChocolate.Types.Pagination;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ImdbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("imdb")));

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .SetPagingOptions(new PagingOptions
    {
        DefaultPageSize = int.MaxValue-1,
        MaxPageSize = int.MaxValue-1
    })
    .RegisterDbContext<ImdbContext>(DbContextKind.Synchronized)
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.MapGraphQL("/api");

app.Run();