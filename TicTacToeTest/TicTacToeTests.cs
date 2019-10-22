using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab06_TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_TicTacToe.Tests
{
    [TestClass()]
    public class TicTacToeTests
    {
        TicTacToe tt = new TicTacToe();
        [TestMethod()]
        public void CreateBoardTest()
        {
            int j = tt.CreateBoard();
            Assert.AreEqual(9, j);
        }

        [TestMethod()]
        public void CurrentPlayerTest()
        {
            char j = tt.CurrentPlayer();

        }

        [TestMethod()]
        public void ChangePlayerTest()
        {
            char j = tt.ChangePlayer();
            Assert.AreEqual('o', j);
        }

        [TestMethod()]
        public void MakeMoveTest()
        {
            tt.MakeMove(0, 0);
            Boolean j = tt.SpaceInUse(0, 0);

            Assert.IsTrue(j);
        }

        [TestMethod()]
        public void SpaceInUseTest()
        {
            Boolean j = tt.SpaceInUse(0, 0);

            //Assert.IsTrue(j);
            Assert.IsFalse(j);
        }
    }
}