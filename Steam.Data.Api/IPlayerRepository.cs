namespace Steam.Data.Api
{
    using Steam.Models;

    public interface IPlayerRepository
    {
        Player Get(string steamId);
    }
}