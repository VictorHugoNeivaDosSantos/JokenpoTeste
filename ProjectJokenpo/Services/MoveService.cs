using ProjectJokenpo.Model;
using ProjectJokenpo.Repositories.Interfaces;
using ProjectJokenpo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectJokenpo.Services
{
    public class MoveService : IMoveService
    {
        private readonly IRepositoryMove _repositoryMove;

        public MoveService(IRepositoryMove repositoryMove)
        {
            _repositoryMove = repositoryMove;
        }

        public long AddMove(Move move)
        {
            return _repositoryMove.AddMove(move);
        }

        public void RemoveMove(long id)
        {
            _repositoryMove.RemoveMove(id);
        }

        public Move GetMove(long id)
        {
            return _repositoryMove.GetMove(id);
        }
        public Move UpdatePlayer(long id, Move move)
        {
            return _repositoryMove.UpdatePlayer(id, move);
        }
        public List<Move> GetMovesList()
        {
            return _repositoryMove.GetMovesList();
        }
    }
}
