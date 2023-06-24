using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models
{
    public partial class MoviesGenre : Identifiable<int>
    {
        public int MovieId { get; set; }

        [Attr]
        public string Genre { get; set; } = null!;

        [HasOne]
        public virtual Movie Movie { get; set; } = null!;
    }
}