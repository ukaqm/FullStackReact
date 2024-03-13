
namespace APIreact.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;
        public EFBowlingRepository(BowlingLeagueContext temp) {
            _bowlingContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers;
    }
}
