using PROLab.DAIF2020.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROLab.DAIF2020.Models.ViewModels
{
    public class DAIF2020ViewModel
    {
        public List<Arena> Arenas { get; internal set; }

        public List<ArenaStatus> ArenaStatuses { get; internal set; }

        public List<Club> Clubs { get; internal set; }

        public List<ClubStatus> ClubStatuses { get; internal set; }

        public List<District> Districts { get; internal set; }

        public List<Game> Games { get; internal set; }

        public List<GameCategory> GameCategories { get; internal set; }

        public List<GameStatus> GameStatuses { get; internal set; }

        public List<GameType> GameTypes { get; internal set; }

        public List<Series> Series { get; internal set; }

        public List<SeriesStatus> SeriesStatuses { get; internal set; }

        public List<ZoneGame> ZoneGames { get; internal set; }

        public List<Zone> Zones { get; internal set; }

    }
}
