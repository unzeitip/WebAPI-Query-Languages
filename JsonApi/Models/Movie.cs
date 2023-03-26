using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models
{
    public partial class Movie : Identifiable<int>
    {
        public Movie()
        {
            MoviesGenres = new HashSet<MoviesGenre>();
            Roles = new HashSet<Role>();
            Directors = new HashSet<Director>();
        }

        [Attr]
        public string? Name { get; set; }

        [Attr]
        public int? Year { get; set; }

        [Attr]
        public float? Rank { get; set; }

        [HasMany]
        public virtual ICollection<MoviesGenre> MoviesGenres { get; set; }

        [HasMany]
        public virtual ICollection<Role> Roles { get; set; }

        [HasMany]
        public virtual ICollection<Director> Directors { get; set; }
    }
}