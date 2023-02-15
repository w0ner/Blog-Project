using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        DbFirstContext db;
        public HomeController(DbFirstContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {


            return View(db.Products.Include(x => x.Category));
        }
    }
}
