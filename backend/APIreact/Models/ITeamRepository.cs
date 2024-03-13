namespace APIreact.Models
{
    public interface ITeamRepository
    {
        IEnumerable<Team> Teams { get; }
    }
}