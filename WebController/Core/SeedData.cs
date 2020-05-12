using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using WebController.Entities;
using Microsoft.AspNetCore.Builder;

namespace WebController.Core
{
    public static class SeedData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            

            ArtistContext context = app.ApplicationServices.GetRequiredService<ArtistContext>();


          //  if (context.Database == null)
          //  {
           //     throw new Exception("DB is null");
           // }

            if (!context.Artists.Any())
            {

                context.Artists.AddRange(
                new Artist
                {
                    UserName = "Joe",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "Harlem",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 5 , Body="Great story,i like how you play", ReviewName="Alain"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        },
                         new Review
                        {
                            Rating= 6 , Body="Great story,i like how you play", ReviewName="Alain"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        },
                         new Review
                        {
                            Rating= 10 , Body="Great story,i like how you play", ReviewName="Alain"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joeline",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=4, Body="Where did you learn how to play, super hot"
                        },
                         new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play", ReviewName="Alain"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        },
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=4, Body="Where did you learn how to play, super hot"
                        }

                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Jack",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/12/2015"),
                    City = "Paris",
                    Provence = "Lyon",
                    Country = "France",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating= 6 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=8, Body="Where did you learn how to play, super hot"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        },
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play", ReviewName="Karen"
                        }



                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                        Styles="classic Rock", TalentName="Jackson JeanPierre", SkillLevel=9, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Philip",
                    WebSite = "www.openmind.org",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "Paris",
                    Provence = "Mrashail",
                    Country = "France",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 5 , Body="Great story,i like how you play", ReviewName="Ali"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        },
                        new Review
                        {
                            Rating= 6 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=8, Body="Where did you learn how to play, super hot"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Philip Toy Jr", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                  new Artist
                  {
                      UserName = "Helen_Yang",
                      WebSite = "none",
                      CreatedDate = DateTime.Parse("6/15/2015"),
                      City = "Paris",
                      Provence = "Alexandrie",
                      Country = "France",
                      Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        },
                        new Review
                        {
                            Rating= 7 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=4, Body="Where did you learn how to play, super hot"
                        }
                    },
                      ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Helen Wando", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                  },
                // next
                new Artist
                {
                    UserName = "Loraine_#Rocker",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "Seatle",
                    Provence = "Rainny City",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        },
                        new Review
                        {
                            Rating= 8 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=8, Body="Where did you learn how to play, super hot"
                        },
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=4, Body="Where did you learn how to play, super hot"
                        }

                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Loraine Fry", SkillLevel=10, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Sandy_TheSolfter",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "Seatle",
                    Provence = "Lincoln",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        },
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=4, Body="Where did you learn how to play, super hot"
                        },
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play", ReviewName="Karen"
                        },
                        new Review
                        {
                            Rating=4, Body="Where did you learn how to play, super hot"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="Jazz Blue", TalentName="Sandy Jackson", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "TheBig",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="Jazz Blue", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                 new Artist
                 {
                     UserName = "Sunny_Rocker",
                     WebSite = "none",
                     CreatedDate = DateTime.Parse("6/15/2015"),
                     City = "QueenCity",
                     Provence = "New York",
                     Country = "England",
                     Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                     ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="Metal Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                 },
                // next
                new Artist
                {
                    UserName = "Mad_Jazzer",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "France",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Franckie",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2013"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "England",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Shy_#PlayHard",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "Harlem",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                  new Artist
                  {
                      UserName = "Ashkey_HighNote",
                      WebSite = "none",
                      CreatedDate = DateTime.Parse("6/15/2015"),
                      City = "River Lake",
                      Provence = "Michigan",
                      Country = "USA",
                      Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                      ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="RnB", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                  },
                // next
                new Artist
                {
                    UserName = "Karen_T",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "Madril",
                    Provence = "Lyon",
                    Country = "Itali",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="Opera", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Carrie",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "Orlando",
                    Provence = "New York",
                    Country = "England",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "TheSinger",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "Denver",
                    Provence = "Colorado",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                       new Artist
                       {
                           UserName = "Rani",
                           WebSite = "none",
                           CreatedDate = DateTime.Parse("6/15/2015"),
                           City = "Miami",
                           Provence = "Forida",
                           Country = "USA",
                           Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                           ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                       },
                // next
                new Artist
                {
                    UserName = "Biggie",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "Booklyne",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Jeanne",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joshua",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                  new Artist
                  {
                      UserName = "Erin",
                      WebSite = "none",
                      CreatedDate = DateTime.Parse("6/15/2015"),
                      City = "Rode Iland",
                      Provence = "New York",
                      Country = "USA",
                      Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                      ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                  },
                // next
                new Artist
                {
                    UserName = "Kanny",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Korie",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                 new Artist
                 {
                     UserName = "Joe_The_Big",
                     WebSite = "none",
                     CreatedDate = DateTime.Parse("6/15/2015"),
                     City = "New York City",
                     Provence = "New York",
                     Country = "USA",
                     Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                     ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                 },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                  new Artist
                  {
                      UserName = "Joe_The_Big",
                      WebSite = "none",
                      CreatedDate = DateTime.Parse("6/15/2015"),
                      City = "New York City",
                      Provence = "New York",
                      Country = "USA",
                      Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                      ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                  },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                 new Artist
                 {
                     UserName = "Joe_The_Big",
                     WebSite = "none",
                     CreatedDate = DateTime.Parse("6/15/2015"),
                     City = "New York City",
                     Provence = "New York",
                     Country = "USA",
                     Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                     ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                 },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                  new Artist
                  {
                      UserName = "Biggie",
                      WebSite = "none",
                      CreatedDate = DateTime.Parse("6/15/2015"),
                      City = "New York City",
                      Provence = "New York",
                      Country = "USA",
                      Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                      ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                  },
                // next
                new Artist
                {
                    UserName = "Shiner",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Moon light",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Mignight_classic",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                 new Artist
                 {
                     UserName = "Joe_The_Big",
                     WebSite = "none",
                     CreatedDate = DateTime.Parse("6/15/2015"),
                     City = "New York City",
                     Provence = "New York",
                     Country = "USA",
                     Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                     ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                 },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 6 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 8 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                  new Artist
                  {
                      UserName = "Joe_The_Big",
                      WebSite = "none",
                      CreatedDate = DateTime.Parse("6/15/2015"),
                      City = "New York City",
                      Provence = "New York",
                      Country = "USA",
                      Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                      ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                  },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                       new Artist
                       {
                           UserName = "Joe_The_Big",
                           WebSite = "none",
                           CreatedDate = DateTime.Parse("6/15/2015"),
                           City = "New York City",
                           Provence = "New York",
                           Country = "USA",
                           Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                           ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                       },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                  new Artist
                  {
                      UserName = "Joe_The_Big",
                      WebSite = "none",
                      CreatedDate = DateTime.Parse("6/15/2015"),
                      City = "New York City",
                      Provence = "New York",
                      Country = "USA",
                      Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                      ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                  },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                 new Artist
                 {
                     UserName = "Joe_The_Big",
                     WebSite = "none",
                     CreatedDate = DateTime.Parse("6/15/2015"),
                     City = "New York City",
                     Provence = "New York",
                     Country = "USA",
                     Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                     ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                 },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2015"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },

                  new Artist
                  {
                      UserName = "Joe_The_Big",
                      WebSite = "none",
                      CreatedDate = DateTime.Parse("6/15/2015"),
                      City = "New York City",
                      Provence = "New York",
                      Country = "USA",
                      Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                      ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                  },
                // next
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2013"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Joe Wolgreen", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                new Artist
                {
                    UserName = "Joe_The_Big",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2014"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 9 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="Heavy Rock", TalentName="Joe Rice", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                },
                // next
                new Artist
                {
                    UserName = "Adam_Classic",
                    WebSite = "none",
                    CreatedDate = DateTime.Parse("6/15/2016"),
                    City = "New York City",
                    Provence = "New York",
                    Country = "USA",
                    Reviews = new List<Review>
                    {
                        new Review
                        {
                            Rating= 7 , Body="Great story,i like how you play"
                        },
                        new Review
                        {
                            Rating=6, Body="Where did you learn hoe to play"
                        }
                    },
                    ArtistSkills = new List<ArtistSkill>
                    {
                        new ArtistSkill
                        {
                            Styles="classic Rock", TalentName="Lee Wolf", SkillLevel=8, Details="I have been playing for the last two years"
                        }
                    }

                }




                );


            }


            context.SaveChanges();
        }
    } 
}
