using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Conoce_La_Eleccion_Backend.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class AspiranteController(AppContext context) : Controller
    {
        private readonly AppContext _context = context;

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Cargos()
        {
            var cargosList = await _context.Cargo.Include
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
