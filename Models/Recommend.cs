using System;
using System.ComponentModel.DataAnnotations;

namespace TermProjectV1.Models
{
    public class Recommend
    {
        public int RecommendId { get; set; }

        [Required(ErrorMessage = "Please enter the food's name.")]
        public string Food { get; set; }

        [Required(ErrorMessage = "Please pick an Allergen, (")]
        public int AllergyId { get; set; }

        public Allergy Allergy { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }
    }
}