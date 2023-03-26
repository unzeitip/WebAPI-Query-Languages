﻿using System;
using System.Collections.Generic;

namespace OData.Models
{
    public partial class MoviesGenre
    {
        public int MovieId { get; set; }
        public string Genre { get; set; } = null!;

        public virtual Movie Movie { get; set; } = null!;
    }
}
