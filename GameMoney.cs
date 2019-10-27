using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolopolyGame
{
    [Serializable]
    public abstract class GameMoney
    {
        public abstract string landOn(ref Player player);

        

    }
}
