using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
    
    /// <summary>
    /// Class that loads the intials values from file
    /// </summary>
   
     public class InitialValuesAccessor
    {


        static public decimal getBankerStartingBalance()
        {
            return 10000;
        }


        //3.1-Load game initial set up from file.
        static public decimal getPlayerStartingBalance(bool setD)
        {

            if (setD == true)
            {
                
                return 2000;
            }
            else
            {
                //read money from the "InitialMoney.txt" File 
                WriteRead reader = new WriteRead();
                decimal InMoney = decimal.Parse(reader.Read());
                return InMoney;
            }
            
        }


    }
}

