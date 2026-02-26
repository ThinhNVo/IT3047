using System.ComponentModel.DataAnnotations;

namespace PetGallery.Models
{
    public class Cats
    {

        [Key]
        public int CatId { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a Breed")]
        public string Breed { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [Range(1, 10, ErrorMessage = "Age must not be over 10")]
        public int Age { get; set; }

    }
}
