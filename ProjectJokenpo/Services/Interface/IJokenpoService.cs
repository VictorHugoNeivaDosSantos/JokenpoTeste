using ProjectJokenpo.Model;
using System.Collections.Generic;

namespace ProjectJokenpo.Services.Interface
{
    public interface IJokenpoService
    {
        Player GetPlayerWinner(List<Move> moves);
    }
}