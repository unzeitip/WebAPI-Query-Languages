using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JsonApi.Models
{
    public partial class MoviesGenre : Identifiable<dynamic>
    {
        [NotMapped]
        public override dynamic Id { get; set; } = null!;

        public int MovieId { get; set; }

        [Attr]
        public string Genre { get; set; } = null!;

        [HasOne]
        public virtual Movie Movie { get; set; } = null!;
    }
}