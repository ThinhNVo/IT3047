using Microsoft.EntityFrameworkCore;
namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Name = "The Shawshank Redemption", Year = 1994, Rating = 5, GenreId = "D" },
                new Movie { MovieId = 2, Name = "The Godfather", Year = 1972, Rating = 5, GenreId = "A" },
                new Movie { MovieId = 3, Name = "The Dark Knight", Year = 2008, Rating = 5, GenreId = "C" }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "S", Name = "Science Fiction" }
            );
        }
    }

}
