using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models
{
    public partial class Role : Identifiable<int>
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }

        [Attr]
        public string RoleName { get; set; } = null!;

        [HasOne]
        public virtual Actor Actor { get; set; } = null!;

        [HasOne]
        public virtual Movie Movie { get; set; } = null!;
    }
}