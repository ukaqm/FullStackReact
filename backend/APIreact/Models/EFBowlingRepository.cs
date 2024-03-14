
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace APIreact.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;
        public EFBowlingRepository(BowlingLeagueContext temp) {
            _bowlingContext = temp;
        }
        //public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers;
        public IEnumerable<Bowler> GetBowlersForMarlinsAndSharks()
        {
            return _bowlingContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .ToList();
        }
    }
}
