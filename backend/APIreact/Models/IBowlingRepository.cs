namespace APIreact.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> GetBowlersForMarlinsAndSharks();
    }
}
