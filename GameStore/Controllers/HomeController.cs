using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<GameModel> gameList = new List<GameModel>();
            gameList.Add(new GameModel(1, "NHL 14", new DateTime(2013, 9, 10), "Sports", "nhl14.jpg",
                                        "Hit the ice and show off your puck skills with NHL 14. This latest iteration of the most popular hockey franchise in modern gaming is packed with gameplay improvements, enhanced graphics, and new ways to guide your team to the ultimate championship.",
                                        "EA Sports"));
            gameList.Add(new GameModel(2, "Grand Theft Auto V", new DateTime(2013, 9, 17), "Action-adventure", "gta5.jpg",
                                        "Live large or die trying in Grand Theft Auto V Xbox 360. Welcome to the chaotic, decadent sprawl of Los Santos by the sea. Meet Franklin, Michael, and Trevor - three small time thugs living desperate lives in Blaine County. They decide that the only way to achieve their dreams is to join forces, doing whatever it takes to succeed - by any means necessary. Are you ready for the carnage and chaos?",
                                        "Rockstar"));
            gameList.Add(new GameModel(3, "Diablo III: Reaper of Souls", new DateTime(2014, 3, 25), "Action role-playing", "diablo.jpg",
                                        "Diablo III: Reaper of Souls is the first major expansion pack for Blizzard's blockbuster dungeon crawling RPG. The Prime Evil rages within the Black Soulstone, its essence screaming for vengeance and release. Before the artifact can be sealed away forever, Malthael -- Angel of Death -- manifests in the mortal realms with a deadly new purpose: to steal the Black Soulstone and bend its infernal power to his will. So begins the end of all things...",
                                        "Blizzard"));
            gameList.Add(new GameModel(4, "The Stick of Truth", new DateTime(2014, 3, 4), "Role-playing", "southpark.jpg",
                                        "From the perilous battlefields of the fourth-grade playground, a young hero will rise, destined to be South Park's savior. From the creators of South Park, Trey Parker and Matt Stone, comes an epic quest to become… cool. Introducing South Park: The Stick of Truth.",
                                        "Ubisoft"));

            List<GameModel> newReleaseList = new List<GameModel>();
            List<GameModel> comingSoonList = new List<GameModel>();

            // Seperate games into new releases / coming soon
            foreach (GameModel game in gameList)
            {
                if (game.ReleaseDate < DateTime.Now)
                    newReleaseList.Add(game);
                else
                    comingSoonList.Add(game);

            }

            /* Store both lists into view model.  
             * New releases are ordered by newest games first.
             * Coming soon are by ordered by games closest to release date.
             */
            GameViewModel gameViewList = new GameViewModel(newReleaseList.OrderByDescending(d => d.ReleaseDate).ToList(),
                                                           comingSoonList.OrderBy(d => d.ReleaseDate).ToList());

            return View(gameViewList);
        }

    }
}