using Microsoft.EntityFrameworkCore;

namespace PetGallery.Models
{
    public class GalleryContext : DbContext
    {
        public GalleryContext(DbContextOptions<GalleryContext> options) : base(options)
        {
        }
        public DbSet<Cats> Cat { get; set; }
        public DbSet<Dogs> Dog { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cats>().HasData(
               new Cats { CatId = 1, Name = "Fluffy", Breed = "Persian", Age = 3 },
               new Cats { CatId = 2, Name = "Whiskers", Breed = "Siamese", Age = 5 },
               new Cats { CatId = 3, Name = "Shadow", Breed = "Maine C", Age = 2 }
            );

            modelBuilder.Entity<Dogs>().HasData(
                new Dogs { DogId = 1, Name = "Buddy", Breed = "Golden Retriever", Age = 4 },
                new Dogs { DogId = 2, Name = "Max", Breed = "Labrador Retriever", Age = 6 },
                new Dogs { DogId = 3, Name = "Bella", Breed = "German Shepherd", Age = 3 }
            );
        }
    }
}
