using System;
using System.Collections.Generic;

namespace Hot_Chocolate.Models
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

        [UsePaging(MaxPageSize = int.MaxValue)]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public ICollection<Role> Roles { get; set; }
    }
}
