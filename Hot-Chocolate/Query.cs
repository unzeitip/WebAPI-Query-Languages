﻿using Hot_Chocolate.Models;

namespace Hot_Chocolate
{
    public class Query
    {
        [UseOffsetPaging(MaxPageSize = int.MaxValue)]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Actor> GetActors(ImdbContext context)
            => context.Actors;

        public Actor? GetActor(ImdbContext context, int id)
            => context.Actors.FirstOrDefault(x => x.Id == id);

        [UseOffsetPaging(MaxPageSize = int.MaxValue)]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Movie> GetMovies(ImdbContext context)
            => context.Movies;

        public Movie? GetMovie(ImdbContext context, int id)
            => context.Movies.FirstOrDefault(x => x.Id == id);

        [UseOffsetPaging(MaxPageSize = int.MaxValue)]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Role> GetRoles(ImdbContext context)
            => context.Roles;
    }
}
