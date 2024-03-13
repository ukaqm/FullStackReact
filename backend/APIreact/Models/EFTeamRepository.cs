
namespace APIreact.Models
{
    public class EFTeamRepository : ITeamRepository
    {
        private BowlingLeagueContext _teamContext;

        public EFTeamRepository(BowlingLeagueContext temp)
        {
            _teamContext = temp;
        }
      
        public IEnumerable<Team> Teams => _teamContext.Teams;
    }
}
