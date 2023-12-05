using DTI_Glossary_App.Data;
using DTI_Glossary_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace DTI_Glossary_App.Controllers
{
    public class GlossaryController : Controller
    {

        private readonly AppDbContext _db;
        public GlossaryController(AppDbContext db)
        {
            _db = db;
        }

        // Get all Glossaries
        public IActionResult Index()
        {
            List<Glossary> objGlossaryList = _db.Glossaries.ToList();
            return View(objGlossaryList);
        }

        // Load the Create Glossary View
        public IActionResult Create()
        {
            return View();
        }

        // Post a Glossary to the DB
        [HttpPost]
        public IActionResult Create(Glossary obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                _db.SaveChanges();

                // Takes in:
                // 1. Action name
                // 2. Controller name
                return RedirectToAction("Index", "Glossary");
            }
            return View();

        }
    }
}
