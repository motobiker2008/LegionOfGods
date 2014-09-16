using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    class Player
    {
        List<Card> cards;
        List<SpecialAbility> specialAbilityes;
        int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public Player()
        {
            List<Card> cards = new List<Card>(7);
            List<SpecialAbility> specialAbilityes = new List<SpecialAbility>(4);
            score = 0;
        }


    }
}
