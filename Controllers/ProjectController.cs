using Microsoft.AspNetCore.Mvc;
using FundingApp.Data;

namespace FundingApp.Controllers
{
    public class ProjectController : Controller
    {
        private readonly FundingDBContext _context;

        public ProjectController(FundingDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
