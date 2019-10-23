using Microsoft.VisualStudio.TestTools.UnitTesting;
using MolopolyGame;
using System.Collections;

namespace UnitTestProject
{//2.8 Conduct unit tests on all classes I add
    [TestClass]
    public class UnitTestWriteRead
    {
        [TestMethod]
        public void TestsavePlayerToBinary()
        {
            WriteRead writeRead = new WriteRead();

            Player Kobe = new Player("kobe", true);
            Player Allen = new Player("allen", false);


            ArrayList players = new ArrayList();
            players.Add(Kobe);
            players.Add(Allen);


            bool r = writeRead.savePlayerToBinary(players);

            Assert.IsTrue(r);
        }

        [TestMethod]

        public void TestsavePropertyToBinary()
        {
            WriteRead writeRead = new WriteRead();

            Property Kobe = new Property("kobe");
            Property Allen = new Property("allen");

            ArrayList properties = new ArrayList();

            properties.Add(Kobe);
            properties.Add(Allen);

            bool r = writeRead.savePropertyToBinary(properties);

            Assert.IsTrue(r);

        }


        [TestMethod]

        public void TestopenPropertyBinaryFile()
        {
            //the excepted Arraylist
            ArrayList Exceptedproperties = new ArrayList();
            Property Kobe = new Property("kobe");
            Property Allen = new Property("allen");

            Exceptedproperties.Add(Kobe);
            Exceptedproperties.Add(Allen);

            //Actualproperities is the actrual  Arraylist
            WriteRead writeRead = new WriteRead();
           
            ArrayList Actualproperities = new ArrayList();

            Actualproperities = writeRead.openPropertyBinaryFile();

            //compare
            CollectionAssert.AreEqual(Exceptedproperties, Actualproperities);
        }

        [TestMethod]

        public void TestopenPlayerBinaryFile()
        {
            //the excepted Arraylist
            ArrayList Exceptedplayers = new ArrayList();
            Player Kobe = new Player("kobe", true);
            Player Allen = new Player("allen", false);
            
            Exceptedplayers.Add(Kobe);
            Exceptedplayers.Add(Allen);

            ////Actualplayers is the actrual  Arraylist
            WriteRead writeRead = new WriteRead();
            ArrayList Actualplayers = new ArrayList();

            Actualplayers = writeRead.openPlayerBinaryFile();

            //compare

            CollectionAssert.AreEqual(Exceptedplayers,Actualplayers);

        }


        [TestMethod]

        public void TestRead()
        {
            string exceptedMoney = "666";
            WriteRead writeRead = new WriteRead();
            string actualMoney = writeRead.Read();
            Assert.AreEqual(exceptedMoney, actualMoney);
        }

    }
}
