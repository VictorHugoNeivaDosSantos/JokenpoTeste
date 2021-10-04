using ProjectJokenpo.Model;
using System.Collections.Generic;

namespace ProjectJokenpo.Context.Interfaces
{
    public interface IContextJokenpo
    {
        List<Player> Players();
    }
}