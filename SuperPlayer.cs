using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolopolyGame
{// 2.1-Demonstrate use of inheritance in various forms

    //2.3-Extend use of Interface classes in the project   
    class SuperPlayer : Player, SuperPlayerInterface
    {
        public SuperPlayer() : base("LiJing", 10000)
        {

        }
  
        public void showMeTheMoney()
        {
            this.receive(10000);
        }
    }

    internal interface SuperPlayerInterface
    {
        void showMeTheMoney();
    }
}
