using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebController.Entities;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebController.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArtistContext _context;

        public HomeController(ArtistContext context)
        {
            _context = context;
        }

        public IActionResult Index(string search = null)
        {

            



            var model = from m in _context.ArtistSkill.Include(a=> a.Artist) 
                        orderby m.Artist.Reviews.Average(r => r.Rating) ascending  
                         where search == null || m.Artist.UserName.StartsWith(search) || m.Artist.City.StartsWith(search)

                        select new ArtistViewModel
                        {
                            ArtistId = m.ArtistId,
                            UserName = m.Artist.UserName,
                            WebSite = m.Artist.WebSite,
                            CreatedDate = m.Artist.CreatedDate,
                            TalentName = m.TalentName,
                            City = m.Artist.City,
                            Provence = m.Artist.Provence,
                            ReviewCount = m.Artist.Reviews.Count(),
                            Styles= m.Styles,
                            Details = m.Details,
                            SkillLevel = m.SkillLevel

                        };


            return View(model.Take(12));
        }


        public IActionResult Details(int id)
        {
            var model = _context.Artists.Find(id);
            //    .Where(a => a.Id == id);

            var q = _context.ArtistSkill.Include(a => a.Artist)
                .Select(m =>  new ArtistViewModel
                {
                    ArtistId = m.ArtistId,
                    UserName = m.Artist.UserName,
                    WebSite = m.Artist.WebSite,
                    CreatedDate = m.Artist.CreatedDate,
                    TalentName = m.TalentName,
                    City = m.Artist.City,
                    Provence = m.Artist.Provence,
                    ReviewCount = m.Artist.Reviews.Count(),
                    Styles = m.Styles,
                    Details = m.Details,
                    SkillLevel = m.SkillLevel

                }).FirstOrDefault(s => s.ArtistId == id);

            return View(q);
        }



    }
}
