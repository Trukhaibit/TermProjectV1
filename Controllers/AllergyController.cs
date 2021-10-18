using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TermProjectV1.Models;

namespace MovieList.Controllers
{
    public class AllergyController : Controller
    {
        private RecommendContext context { get; set; }

        public AllergyController(RecommendContext ctx)
        {
            context = ctx;
        }
    }
}