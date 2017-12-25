using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebController.Entities
{
    public class Artist
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a user name ")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a country origine")]
        public string Country { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter a provence")]
        public string Provence { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a site")]
        public string WebSite { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Created")]
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ArtistSkill> ArtistSkills { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }

    public class Review
    {
        public int Id { get; set; }
        [Required, Range(1,10)]
        public int Rating { get; set; }
        public string Body { get; set; }
        public string ReviewName { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }

    public class ArtistSkill
    {
        public int Id { get; set; }
        [Display(Name = "Talent Name")]
        [Required(ErrorMessage = "Please enter a name")]
        public string TalentName { get; set; }
        [Display(Name = "Skill Level")]
        [Required(ErrorMessage = "Please enter a skills Level")]
        public int SkillLevel { get; set; }
        public string Details { get; set; }
        public string Styles { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}

