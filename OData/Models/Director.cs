namespace OData.Models
{
    public partial class Director
    {
        public Director()
        {
            DirectorsGenres = new HashSet<DirectorsGenre>();
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<DirectorsGenre> DirectorsGenres { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
