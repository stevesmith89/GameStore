using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class GameViewModel
    {
        public List<GameModel> NewReleases;
        public List<GameModel> ComingSoon;

        public GameViewModel(List<GameModel> newReleases, List<GameModel> comingSoon)
        {
            NewReleases = newReleases;
            ComingSoon = comingSoon;
        }
    }
}