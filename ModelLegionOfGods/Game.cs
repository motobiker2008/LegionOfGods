using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    public class Game
    {
        Card[][] Board;
        bool isStart;
        bool isPause;
        List<Player> players;
        List<Card> descCards;

        public Game()
        {
            Board = new Card[10][];
            for (int i = 0; i < 10; i++)
            {
                Board[i] = new Card[10];
                for (int j = 0; j < 10; j++)
                    Board[i][j] = null;
            }
            isStart = false;
            isPause = false;
            List<Player> players = new List<Player>(2);
            List<Card> descCards = new List<Card>(50);
        }

        public void newGame()
        {

        }

        private bool checkEnd()
        {
            return true;
        }

        public void move()
        {
        }

        private void checkMove()
        {
        }

        private void setActivePlayer()
        {
        }

        private void scoring()
        {
        }

        public void endGame()
        {
        }
    }
}
