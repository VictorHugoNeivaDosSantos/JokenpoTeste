using ProjectJokenpo.Model;

namespace ProjectJokenpo.Repositories.Interfaces
{
    public interface IRepositoryPlayer
    {
        long AddPlayer(Player player);
        Player GetPlayer(long id);
        void RemovePlayer(long id);
        Player UpdatePlayer(long id, Player player);
    }
}