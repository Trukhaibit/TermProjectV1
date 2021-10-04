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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recommend>().HasData(
                new Recommend
                {
                    RecommendId = 1,
                    Name = "Johnathan Fischer",
                    Food = "Hot Dish",
                    Rating = 5
                },
                new Recommend
                {
                    RecommendId = 2,
                    Name = "CadillacConvertable98",
                    Food = "Vernor's Ginger Ale",
                    Rating = 2
                },
                new Recommend
                {
                    RecommendId = 3,
                    Name = "Gerald",
                    Food = "Mackinac Island Fudge",
                    Rating = 4
                }
                );
        }
    }
}