using ProjectJokenpo.Model;
using ProjectJokenpo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectJokenpo.Services.Interface
{
    public class PlayerService : IPlayerService
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

        public PlayerService(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }

        public long AddPlayer(Player player)
        {
            if (player.Name != null)
            {
                return _repositoryPlayer.AddPlayer(player);
            }

            throw new Exception("O nome do jogador não pode ser vazio");
        }

        public void RemovePlayer(long id)
        {
            _repositoryPlayer.RemovePlayer(id);
        }

        public Player GetPlayer(long id)
        {
            return _repositoryPlayer.GetPlayer(id);
        }

        public Player UpdatePlayer(long id, Player player)
        {
            return _repositoryPlayer.UpdatePlayer(id, player);
        }

    }
}
