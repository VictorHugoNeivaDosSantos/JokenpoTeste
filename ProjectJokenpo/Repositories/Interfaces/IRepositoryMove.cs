using ProjectJokenpo.Model;
using System.Collections.Generic;

namespace ProjectJokenpo.Repositories.Interfaces
{
    public interface IRepositoryMove
    {
        long AddMove(Move move);
        Move GetMove(long id);
        void RemoveMove(long id);
        Move UpdatePlayer(long id, Move move);
        List<Move> GetMovesList();
    }
}