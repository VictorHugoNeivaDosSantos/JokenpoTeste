using ProjectJokenpo.Model;
using ProjectJokenpo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectJokenpo.Services
{
    public class JokenpoService : IJokenpoService
    {
        private readonly IPlayerService _playerService;
        public JokenpoService(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public Player GetPlayerWinner(List<Move> moves)
        {
            Player playerWinner = new Player();
            if (moves.Count == 3)
            {

                int choice = (int)moves[0].PecaJogada;

                switch (choice)
                {
                    case 1:
                        if ((int)moves[1].PecaJogada != 2 && (int)moves[2].PecaJogada != 2)
                        {
                            playerWinner = _playerService.GetPlayer(moves[0].PlayerId);
                        }
                        break;
                    case 2:
                        if ((int)moves[1].PecaJogada != 3 && (int)moves[2].PecaJogada != 3)
                        {
                            playerWinner = _playerService.GetPlayer(moves[0].PlayerId);
                        }
                        break;
                    case 3:
                        if ((int)moves[1].PecaJogada != 1 && (int)moves[2].PecaJogada != 1)
                        {
                            playerWinner = _playerService.GetPlayer(moves[0].PlayerId);
                        }
                        break;
                }

                return playerWinner;
            }
            else
            {
                throw new Exception("Quantidade de jogadas incorreta");
            }
        }
    }
}
