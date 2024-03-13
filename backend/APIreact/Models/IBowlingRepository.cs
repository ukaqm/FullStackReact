namespace APIreact.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
    }
}
