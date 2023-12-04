using Microsoft.AspNetCore.Mvc;

namespace DTI_Glossary_App.Controllers
{
    public class GlossaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
