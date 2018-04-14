using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebController.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebController.Controllers.Api
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ArtistsController : Controller
    {
        private readonly ArtistContext _context;

        public ArtistsController(ArtistContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetArtists()
        {
            var model = _context.Artists.ToList();

            return Ok(model);
        }
    }
}
