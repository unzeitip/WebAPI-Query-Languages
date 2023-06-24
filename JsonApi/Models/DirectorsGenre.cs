using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models
{
    public partial class DirectorsGenre : Identifiable<int>
    {
        public int DirectorId { get; set; }

        [Attr]
        public string Genre { get; set; } = null!;

        [Attr]
        public float? Prob { get; set; }

        [HasOne]
        public virtual Director Director { get; set; } = null!;
    }
}