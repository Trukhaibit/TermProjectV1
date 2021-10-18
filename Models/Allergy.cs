using System;
using System.ComponentModel.DataAnnotations;

namespace TermProjectV1.Models
{
    public class Allergy
    {
        [Key]
        public int AllergyId { get; set; }
        public string Allergen { get; set; }
        public string Examples { get; set; }
    }
}