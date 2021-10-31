using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProjectV1.Models
{
    public class Allergy
    {
        [Key]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only arabic numerals are allowed.")]
        [Display(Name = "Allergy Id")]
        [Column("Allergy Id")]
        public int AllergyId { get; set; }

        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string Allergen { get; set; }
        public string Examples { get; set; }
    }
}