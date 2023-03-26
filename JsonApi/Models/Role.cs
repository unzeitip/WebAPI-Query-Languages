using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JsonApi.Models
{
    public partial class Role : Identifiable<dynamic>
    {
        [NotMapped]
        public override dynamic Id { get; set; } = null!;

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