using ProjectJokenpo.Model;

namespace ProjectJokenpo.Services
{
    public interface IPlayerService
    {
        long AddPlayer(Player player);
        Player GetPlayer(long id);
        void RemovePlayer(long id);
        Player UpdatePlayer(long id, Player player);
    }
}