using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebController.Entities;

namespace WebController.Components
{
    public class ArtistCart:ViewComponent 
    {
        private  ArtistContext context;

      
        public ArtistCart(ArtistContext _context)
        {
            context = _context;
        }


        public string Invoke()
        {
         


            return $"{context.Artists.Count()}";
        }
    }


    
}
