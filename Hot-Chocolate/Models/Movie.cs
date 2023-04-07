using System;
using System.Collections.Generic;

namespace Hot_Chocolate.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MoviesGenres = new HashSet<MoviesGenre>();
            Roles = new HashSet<Role>();
            Directors = new HashSet<Director>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Year { get; set; }
        public float? Rank { get; set; }

        public virtual ICollection<MoviesGenre> MoviesGenres { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Director> Directors { get; set; }
    }
}
