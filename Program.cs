using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
     /// <summary>
    /// Main class for the program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {//2.3-Extend use of Interface classes in the project  
            GameInterface game = new Monopoly(); 
            //  I change "Game" to "GameInterface"
            game.initializeGame();
        }

     
    }
}
