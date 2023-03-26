using System;
using System.Collections.Generic;

namespace OData.Models
{
    public partial class Actor
    {
        public Actor()
        {
            Roles = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
