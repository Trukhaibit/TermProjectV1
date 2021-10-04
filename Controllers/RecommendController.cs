using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TermProjectV1.Models;

namespace MovieList.Controllers
{
    public class RecommendController : Controller
    {
        private RecommendContext context { get; set; }

        public RecommendController(RecommendContext ctx)
        {
            context = ctx;
        }
    }
}