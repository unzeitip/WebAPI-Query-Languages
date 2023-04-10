using Hot_Chocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace Hot_Chocolate
{
    public partial class ImdbContext : DbContext
    {
        public ImdbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; } = null!;
        public virtual DbSet<Director> Directors { get; set; } = null!;
        public virtual DbSet<DirectorsGenre> DirectorsGenres { get; set; } = null!;
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<MoviesGenre> MoviesGenres { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("actors");

                entity.HasIndex(e => e.FirstName, "actors_first_name");

                entity.HasIndex(e => e.LastName, "actors_last_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("gender")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<Director>(entity =>
            {
                entity.ToTable("directors");

                entity.HasIndex(e => e.FirstName, "directors_first_name");

                entity.HasIndex(e => e.LastName, "directors_last_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .HasColumnName("last_name");

                entity.HasMany(d => d.Movies)
                    .WithMany(p => p.Directors)
                    .UsingEntity<Dictionary<string, object>>(
                        "MoviesDirector",
                        l => l.HasOne<Movie>().WithMany().HasForeignKey("MovieId").HasConstraintName("movies_directors$movies_directors_ibfk_2"),
                        r => r.HasOne<Director>().WithMany().HasForeignKey("DirectorId").HasConstraintName("movies_directors$movies_directors_ibfk_1"),
                        j =>
                        {
                            j.HasKey("DirectorId", "MovieId").HasName("PK_movies_directors_director_id");

                            j.ToTable("movies_directors");

                            j.HasIndex(new[] { "DirectorId" }, "movies_directors_director_id");

                            j.HasIndex(new[] { "MovieId" }, "movies_directors_movie_id");

                            j.IndexerProperty<int>("DirectorId").HasColumnName("director_id");

                            j.IndexerProperty<int>("MovieId").HasColumnName("movie_id");
                        });
            });

            modelBuilder.Entity<DirectorsGenre>(entity =>
            {
                entity.HasKey(e => new { e.DirectorId, e.Genre })
                    .HasName("PK_directors_genres_director_id");

                entity.ToTable("directors_genres");

                entity.HasIndex(e => e.DirectorId, "directors_genres_director_id");

                entity.Property(e => e.DirectorId).HasColumnName("director_id");

                entity.Property(e => e.Genre)
                    .HasMaxLength(100)
                    .HasColumnName("genre");

                entity.Property(e => e.Prob).HasColumnName("prob");

                entity.HasOne(d => d.Director)
                    .WithMany(p => p.DirectorsGenres)
                    .HasForeignKey(d => d.DirectorId)
                    .HasConstraintName("directors_genres$directors_genres_ibfk_1");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies");

                entity.HasIndex(e => e.Name, "movies_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<MoviesGenre>(entity =>
            {
                entity.HasKey(e => new { e.MovieId, e.Genre })
                    .HasName("PK_movies_genres_movie_id");

                entity.ToTable("movies_genres");

                entity.HasIndex(e => e.MovieId, "movies_genres_movie_id");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.Genre)
                    .HasMaxLength(100)
                    .HasColumnName("genre");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MoviesGenres)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("movies_genres$movies_genres_ibfk_1");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => new { e.ActorId, e.MovieId, e.RoleName })
                    .HasName("PK_roles_actor_id");

                entity.ToTable("roles");

                entity.HasIndex(e => e.ActorId, "actor_id");

                entity.HasIndex(e => e.MovieId, "movie_id");

                entity.Property(e => e.ActorId).HasColumnName("actor_id");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .HasColumnName("role");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.ActorId)
                    .HasConstraintName("roles$roles_ibfk_1");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("roles$roles_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
