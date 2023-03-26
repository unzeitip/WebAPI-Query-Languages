using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models
{
    public partial class Director : Identifiable<int>
    {
        public Director()
        {
            DirectorsGenres = new HashSet<DirectorsGenre>();
            Movies = new HashSet<Movie>();
        }

        [Attr]
        public string? FirstName { get; set; }

        [Attr]
        public string? LastName { get; set; }

        [HasMany]
        public virtual ICollection<DirectorsGenre> DirectorsGenres { get; set; }

        [HasMany]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}