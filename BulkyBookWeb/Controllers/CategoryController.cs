
using BulkyBookWeb.Models;
using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
           _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategotrylist = _db.Categories;
            return View(objCategotrylist);
        }
    }
}
