using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace JsonApi.Models
{
    public partial class Actor : Identifiable<int>
    {
        public Actor()
        {
            Roles = new HashSet<Role>();
        }

        [Attr]
        public string? FirstName { get; set; }

        [Attr]
        public string? LastName { get; set; }

        [Attr]
        public string? Gender { get; set; }

        [HasMany]
        public virtual ICollection<Role> Roles { get; set; }
    }
}