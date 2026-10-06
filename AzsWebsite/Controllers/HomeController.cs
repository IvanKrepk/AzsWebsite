using AzsWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AzsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly AzsDbContext _context;

        public HomeController(AzsDbContext context) 
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var latestNews = await _context.News
                .OrderByDescending(n => n.PublishDate)
                .Take(5)
                .ToListAsync();
            return View(latestNews);
        }
    }
}
