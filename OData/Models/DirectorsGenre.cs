﻿namespace OData.Models
{
    public partial class DirectorsGenre
    {
        public int Id { get; set; }
        public int DirectorId { get; set; }
        public string Genre { get; set; } = null!;
        public float? Prob { get; set; }

        public virtual Director Director { get; set; } = null!;
    }
}