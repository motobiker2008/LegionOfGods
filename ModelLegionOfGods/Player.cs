using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    /// <summary>
    /// Класс Player
    /// Содержит информацию об игроке
    /// </summary>
    public class Player
    {
        List<Card> cards;
        List<SpecialAbility> specialAbilityes;
        int score;
        String name;

        /// <summary>
        /// Свойство, содержащее набор карт игрока
        /// </summary>
        public List<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }

        /// <summary>
        /// Свойство, содержащее список активных спец. способностей игрока
        /// </summary>
        public List<SpecialAbility> SpecialAbilityes
        {
            get { return specialAbilityes; }
            set { specialAbilityes = value; }
        }

        /// <summary>
        /// Свойство, содержащее имя игрока
        /// </summary>
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство, содержащее количество очков игрока
        /// </summary>
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
            name = "Gamer";
        }

        /// <summary>
        /// Метод, который перемещает карту в список карт игрока
        /// </summary>
        /// <param name="card">Объект класса Card, который нужно поместить на руку игроку</param>
        public void getCard(Card card)
        {
        }
    }
}
