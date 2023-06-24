namespace Hot_Chocolate.Models
{
    public partial class MoviesGenre
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Genre { get; set; } = null!;

        public virtual Movie Movie { get; set; } = null!;
    }
}
