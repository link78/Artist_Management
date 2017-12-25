using System;
using System.Collections.Generic;
using System.Text;

namespace WebDataAccess.Entities
{
   public class Artist
    {
        public int ArtistId { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Provence { get; set; }

        public string City { get; set; }
        public string WebSite { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ArtistSkill> ArtistSkills { get; set; }
    }



    public class ArtistSkill
    {
        public int ArtistSkillId { get; set; }
        public string TalentName { get; set; }
        public int SkillLevel { get; set; }
        public string Details { get; set; }
        public string Styles { get; set; }


        public virtual Artist Artist { get; set; }
    }
}
