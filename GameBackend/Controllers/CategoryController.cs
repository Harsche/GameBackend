using GameBackend.Data;
using Microsoft.AspNetCore.Mvc;

namespace GameBackend.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            List<Models.Category> categoryList = _db.Categories.ToList();
            return View(categoryList);
        }

    }
}
