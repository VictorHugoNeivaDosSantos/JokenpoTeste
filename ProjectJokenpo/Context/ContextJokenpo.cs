using ProjectJokenpo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectJokenpo.Context
{
    public class ContextJokenpo : IContextJokenpo
    {
        public static readonly List<Move> playerMoves = new List<Move>();

        public static readonly List<Player> players = new List<Player>();

        public List<Player> Players()
        {
            return players;
        }
    }
}
