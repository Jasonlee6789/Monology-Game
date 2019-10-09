using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using static System.Console;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace MolopolyGame
{// 3.1-Load game initial set up from file. 
    class WirteRead
    {
        // method for write
        public void Write(string m)
        {
            FileStream outFile = new FileStream("InitialMoney.txt", FileMode.Create, FileAccess.Write);

            //shows an application in which a FileStream object named outFile is created, 
            //then associated with a StreamWriter named writer in the following line

            StreamWriter writer = new StreamWriter(outFile);

            writer.WriteLine(m);
            //Data can be written to a StreamWriter object using the WriteLine() method

            writer.Close();
            outFile.Close();

        }

        // method for read

        public string Read()
        {
            FileStream inFile = new FileStream("InitialMoney.txt", FileMode.Open, FileAccess.Read);

            //Whether you are writing data to a file or reading data from one, you create a FileStream object

            StreamReader reader = new StreamReader(inFile);
        
            string recordIn = reader.ReadLine();
            //Data can be read from a StreamReader object using the ReadLine() method

            reader.Close();
            inFile.Close();

            return recordIn;

        }


    }
}
