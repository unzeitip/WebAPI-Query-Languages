using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JsonApi.Models
{
    public partial class DirectorsGenre : Identifiable<dynamic>
    {
        [NotMapped]
        public override dynamic Id { get; set; } = null!;

        public int DirectorId { get; set; }

        [Attr]
        public string Genre { get; set; } = null!;

        [Attr]
        public float? Prob { get; set; }

        [HasOne]
        public virtual Director Director { get; set; } = null!;
    }
}