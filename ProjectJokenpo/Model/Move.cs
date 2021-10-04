using ProjectJokenpo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectJokenpo.Model
{
    public class Move
    {
        public long Id { get; set; }
        //public Player Player { get; set; }
        public long PlayerId { get; set; }
        public ObjetoJokempo PecaJogada { get; set; }

    }
}
