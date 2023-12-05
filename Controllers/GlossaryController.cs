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

        // Return the Create Glossary View
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

        public IActionResult Edit(int? id)
        {
            if (id == null || id < 0)
                return NotFound();

            Glossary editGloss = _db.Glossaries.Find(id);
            if (editGloss == null)
            { 
                return NotFound();
            }

            return View(editGloss);
        }

        // Update a Glossary in the DB
        [HttpPost]
        public IActionResult Edit(Glossary obj)
        {
            if (ModelState.IsValid)
            {
                _db.Glossaries.Update(obj);
                _db.SaveChanges();

                // Takes in:
                // 1. Action name
                // 2. Controller name
                return RedirectToAction("Index", "Glossary");
            }
            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id < 0)
                return NotFound();

            Glossary deleteGloss = _db.Glossaries.Find(id);
            if (deleteGloss == null)
            {
                return NotFound();
            }

            return View(deleteGloss);
        }

        // Delete a Glossary from the DB
        [HttpPost]
        public IActionResult Delete(Glossary obj)
        {
            if(obj == null)
                return NotFound();

            Glossary deleteGloss = _db.Glossaries.Find(obj.GlossaryId);
            _db.Glossaries.Remove(deleteGloss);
            _db.SaveChanges();

            // Takes in:
            // 1. Action name
            // 2. Controller name
            return RedirectToAction("Index", "Glossary");
        }
    }
}
