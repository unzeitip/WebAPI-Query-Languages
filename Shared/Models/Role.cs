using System;
using System.Collections.Generic;

namespace Shared.Models
{
    public partial class Role
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        public string Role1 { get; set; } = null!;

        public virtual Actor Actor { get; set; } = null!;
        public virtual Movie Movie { get; set; } = null!;
    }
}
