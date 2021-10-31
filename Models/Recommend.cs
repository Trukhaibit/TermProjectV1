using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProjectV1.Models
{
    public class Recommend
    {
        [Key]
        public int RecommendId { get; set; }

        [Required(ErrorMessage = "Please enter the food's name.")]
        [StringLength(35, ErrorMessage = "The maximum length of the food's name is 35")]
        public string Food { get; set; }

        [ForeignKey("AllergyId")]
        [Required(ErrorMessage = "Please pick an Allergen, (")]
        public int AllergyId { get; set; }

        public Allergy Allergy { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(20, ErrorMessage = "The maximum length for a username is 20")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [DataType(DataType.Text)]
        public int? Rating { get; set; }
    }
}