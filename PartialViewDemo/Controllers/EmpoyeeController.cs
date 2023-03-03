using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Data;

namespace PartialViewDemo.Controllers
{
    public class EmpoyeeController : Controller
    {
        private readonly ApplicationDbContext db;
        public EmpoyeeController(ApplicationDbContext db) 
        { 
            this.db = db;
        }
        public IActionResult Index()
        {
            var model=db.Employees.ToList();
            return View(model);
        }
    }
}
