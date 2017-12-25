using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebController.Entities
{
    public class ArtistViewModel
    {
        public int ArtistId { get; set; }
        public string UserName { get; set; }
        public string Provence { get; set; }
        public string City { get; set; }
        public string WebSite { get; set; }
        public DateTime CreatedDate { get; set; }

        public int Rating { get; set; }
        public string Body { get; set; }
        public int ReviewCount { get; set; }

        public string TalentName { get; set; }
        public int SkillLevel { get; set; }
        public string Details { get; set; }
        public string Styles { get; set; }
    }  
}
