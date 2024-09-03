using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ustaTickets.Data;

namespace ustaTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService _service;

        private readonly ApplicationDbContext _context;

        public CinemaController(ICinemaService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.Cinema.ToListAsync();
            return View(data);
        }
    }
}
