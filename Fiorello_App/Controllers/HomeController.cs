using Data.DAL;
using Data.Models;
using Fiorello_App.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

      
        public async Task<IActionResult> Index()
        {

           HomeVM homeVM = new HomeVM();

            homeVM.Sliders = await _context.Sliders.ToListAsync();
            homeVM.Products =await _context.Products
                .Include(n=>n.Category)
                .Where(n => !n.IsDeleted)
                .OrderByDescending(n=>n.CreatedDate).ToListAsync();
            homeVM.Categories= await _context.Categories
                .Where(n => !n.IsDeleted).ToListAsync();
            homeVM.Experts = await _context.Experts.ToListAsync();
            homeVM.Blogs = await _context.Blogs.ToListAsync();
            homeVM.Says = await _context.Says.ToListAsync();
            homeVM.Instagrams= await _context.Instagrams.ToListAsync();

            return View(homeVM);
        }
    }
}
