using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using static System.Console;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;

namespace MolopolyGame
{// 3.1-Load game initial set up from file. 
 //3.2-Serialisation
    [Serializable]
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

        //public bool savePositionToBinary(Board position)
        //{
        //    FileStream outPositionFile = new FileStream("PositionStore.txt", FileMode.Create, FileAccess.Write);
        //    BinaryFormatter nzBinFile = new BinaryFormatter();
           
        //    nzBinFile.Serialize(outPositionFile, position);
        //    outPositionFile.Close();
        //    return true;
        //}


        //3.2-Serialisation
        public bool savePropertyToBinary(ArrayList properties)
        {
            FileStream outPropertyFile = new FileStream("PropertyStore.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter nzBinFile = new BinaryFormatter();

            foreach (Property property in properties)
                nzBinFile.Serialize(outPropertyFile, property);
            outPropertyFile.Close();
            return true;
        }

        //3.2-Serialisation
        public bool savePlayerToBinary(ArrayList players)
        {
            FileStream outPlayersFile = new FileStream("PlayersStore.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter nzBinFile = new BinaryFormatter();

            
            foreach(Player player in players)
                nzBinFile.Serialize(outPlayersFile, player);
            outPlayersFile.Close();
            return true;
        }

        // add a method to open Binary File and deserialize to object

        public ArrayList openPropertyBinaryFile()
        {
            //1.find the binaryFile



            //2. use method to open it 
            FileStream inFile = new FileStream("PropertyStore.txt", FileMode.Open, FileAccess.Read);

            //3. read 
            ArrayList properties = new ArrayList();
            Property property = new Property();
            BinaryFormatter binData = new BinaryFormatter();

            while (inFile.Position < inFile.Length)
            {
                property = (Property)binData.Deserialize(inFile);
                properties.Add(property);
            }
            inFile.Close();
            return properties;
        }


    }
}
