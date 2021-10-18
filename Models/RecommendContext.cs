using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TermProjectV1.Models
{
    public class RecommendContext : DbContext
    {
        public RecommendContext(DbContextOptions<RecommendContext> options) : base(options) { }
        public DbSet<Recommend> Recommends { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recommend>().HasData(
                new Recommend
                {
                    RecommendId = 1,
                    Name = "Johnathan Fischer",
                    AllergyId = 1,
                    Food = "Hot Dish",
                    Rating = 5
                },
                new Recommend
                {
                    RecommendId = 2,
                    Name = "CadillacConvertable98",
                    AllergyId = 1,
                    Food = "Vernor's Ginger Ale",
                    Rating = 2
                },
                new Recommend
                {
                    RecommendId = 3,
                    Name = "Gerald",
                    AllergyId = 2,
                    Food = "Mackinac Island Fudge",
                    Rating = 4
                }
                );
            modelBuilder.Entity<Allergy>().HasData(
                new Allergy
                {
                    AllergyId = 1,
                    Allergen = "None",
                    Examples = "Water",
                },
                new Allergy
                {
                    AllergyId = 2,
                    Allergen = "Peanuts",
                    Examples = "Peanut Butter, Brittle",
                },
                new Allergy
                {
                    AllergyId = 3,
                    Allergen = "Gluten",
                    Examples = "Bread, Beer",
                }
                );
        }
    }
}