using MolopolyGame;
using NUnit.Framework;
using System;
using System.Collections;
using System.IO;

namespace UnitTestProject
{//2.8 Conduct unit tests on all classes I add
    [TestFixture]
    public class UnitTestWriteRead
    {
        [Test]
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

        [Test]
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


        [Test]
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

        [Test]
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

            CollectionAssert.AreEqual(Exceptedplayers, Actualplayers);

        }


        [Test]
        public void TestRead()
        {
            string exceptedMoney = "666";
            WriteRead writeRead = new WriteRead();
            string actualMoney = writeRead.Read();
            Assert.AreEqual(exceptedMoney, actualMoney);
        }

    }

    [SetUpFixture]
    public class MySetUpClass
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
            // or identically under the hoods
            Directory.SetCurrentDirectory(TestContext.CurrentContext.TestDirectory);
        }
    }
}
