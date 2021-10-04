using ProjectJokenpo.Context;
using ProjectJokenpo.Model;
using ProjectJokenpo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectJokenpo.Repositories
{
    public class RepositoryMove : IRepositoryMove
    {
        private readonly ContextJokenpo _context;

        public RepositoryMove(ContextJokenpo context)
        {
            _context = context;
        }

        public long AddMove(Move move)
        {
            _context.MoveDB.Add(move);
            return move.Id;
        }

        public void RemoveMove(long id)
        {
            var move = _context.MoveDB.Find(f => f.Id == id);
            _context.MoveDB.Remove(move);
        }

        public Move GetMove(long id)
        {
            var move = _context.MoveDB.Find(f => f.Id == id);
            return move;
        }
        public Move UpdatePlayer(long id, Move move)
        {
            var getMove = _context.MoveDB.Find(f => f.Id == id);
            getMove.PecaJogada = move.PecaJogada;
            return getMove;
        }

        public List<Move> GetMovesList()
        {
            return _context.MoveDB.ToList();
        } 
    }
}
