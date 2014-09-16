using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    public class Player
    {
        List<Card> cards;
        List<SpecialAbility> specialAbilityes;
        int score;
        bool isActive;
        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

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
            isActive = false;
            name = "Gamer";
        }

        public void getCard(Card card)
        {
        }

        public void playCard(Card card)
        {
        }

        public void useSpecialAbilityes(SpecialAbility ability)
        {
        }
    }
}
