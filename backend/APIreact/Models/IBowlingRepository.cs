namespace APIreact.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> GetBowlersForMarlinAndSharks();
    }
}
