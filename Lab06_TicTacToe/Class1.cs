using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_TicTacToe
{
    public class TicTacToe
    {
        char[,] playerBoard;
        int j = 0;
       // int i = 0;
        char[] player = new char[2];
        char currentPlayer;
            public TicTacToe()
        {
            player[0] = 'x';
            player[1] = 'o';
            currentPlayer = player[0];
            CreateBoard();
        }
        public int CreateBoard()
        {
             playerBoard = new char[3, 3];//creates a 3d character array
            j = playerBoard.Length;
            return j;
        }
        public char CurrentPlayer()
        {
            return currentPlayer;
        }
        public char ChangePlayer()
        {
            if (currentPlayer == 'x')
            {
                currentPlayer = player[1];
                return currentPlayer;
            }
            else
            {
                currentPlayer = player[0];
                return currentPlayer;
            }
        }
        public void MakeMove(int a, int b)
        {
            
            playerBoard[a, b] = currentPlayer;
        }
        public Boolean SpaceInUse(int a,int b)
        {
            char c = playerBoard[a,b];
            if (c == 'x')
            {
                return true;
            }
            else if (c == 'o')
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
}
