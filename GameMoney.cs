using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolopolyGame
{
    //2.4 Demonstrate use of abstract  classes in the project
    [Serializable]
    public abstract class GameMoney
    {
        public abstract string landOn(ref Player player);

        

    }
}
