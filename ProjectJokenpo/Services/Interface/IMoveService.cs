using ProjectJokenpo.Model;

namespace ProjectJokenpo.Services.Interface
{
    public interface IMoveService
    {
        long AddMove(Move move);
        Move GetMove(long id);
        void RemoveMove(long id);
        Move UpdatePlayer(long id, Move move);
    }
}