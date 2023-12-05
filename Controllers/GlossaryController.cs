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
        public IActionResult Index()
        {
            List<Glossary> objGlossaryList = _db.Glossaries.ToList();
            return View(objGlossaryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
