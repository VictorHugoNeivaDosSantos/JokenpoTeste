using ProjectJokenpo.Context;
using ProjectJokenpo.Model;
using ProjectJokenpo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectJokenpo.Repositories
{
    public class RepositoryPlayer : IRepositoryPlayer
    {
        private readonly ContextJokenpo _context;

        public RepositoryPlayer(ContextJokenpo context)
        {
            _context = context;
        }

        public long AddPlayer(Player player)
        {
            _context.PlayersDB.Add(player);
            return player.Id;
        }

        public void RemovePlayer(long id)
        {
            var player = _context.PlayersDB.Find(f => f.Id == id);
            _context.PlayersDB.Remove(player);
        }

        public Player GetPlayer(long id)
        {
            var player = _context.PlayersDB.Find(f => f.Id == id);
            return player;
        }

        public Player UpdatePlayer(long id, Player player)
        {
            var getPlayer = _context.PlayersDB.Find(f => f.Id == id);
            getPlayer.Name = player.Name;
            getPlayer.Email = player.Email;
            return getPlayer;
        }
    }
}
