using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    /// <summary>
    /// Класс Card
    /// Абстрактный класс, представляющий сущность "Карта", которую игрок может сыграть во время своего хода
    /// </summary>
    public abstract class Card
    {
        God god;
        int pover;

        /// <summary>
        /// Свойство содержащее иформацию о боге, связанном с картой
        ///</summary>
        public God God
        {
            get { return god; }
            set { god = value; }
        }

        /// <summary>
        /// Сила карты, учитывается при подсчёте очков в конце хода
        /// </summary>
        public int Pover
        {
            get { return pover; }
            set { pover = value; }
        }

        /// <summary>
        /// Действие, которое происходит перед помещением карты на поле
        /// </summary>
        /// <param name="game">Объект класса Game из которого был вызван метод</param>
        public abstract void beforeUse(Game game);

        /// <summary>
        /// Действие, которое происходит после помещения карты на поле
        /// </summary>
        /// <param name="game">Объект класса Game из которого был вызван метод</param>
        public abstract void afterUse(Game game);
    }

    /// <summary>
    /// Класс Jupiter
    /// Реализация абстрактного класса Card.
    /// Карта, от которой начинается игра(лежит на середине поля)
    /// </summary>
    public class Jupiter : Card
    {
        public Jupiter()
        {
            this.God = new God("Юпитер", "Jupiter.png", "Много букав про Юпитера");
            this.Pover = 0;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Juno
    /// Реализация абстрактного класса Card.
    /// Просто очень сильная карта
    /// </summary>
    public class Juno : Card
    {
        public Juno()
        {
            this.God = new God("Юнона", "Juno.png", "Много букав про Юнону");
            this.Pover = 7;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Neptune
    /// Реализация абстрактного класса Card.
    /// Карта, которую можно положить как на пустое место, так и на любую другую карту
    /// </summary>
    public class Neptune : Card
    {
        Card closedCard;

        /// <summary>
        /// Свойство, в котором содержится покрытая карта
        /// </summary>
        public Card ClosedCard
        {
            get { return closedCard; }
            set { closedCard = value; }
        }

        public Neptune()
        {
            this.God = new God("Нептун", "Neptune.png", "Много букав про Нептуна");
            closedCard = null;
            this.Pover = 5;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Pluto
    /// Реализация абстрактного класса Card.
    /// Карта, рядом с которой нельзя размещать другие карты
    /// </summary>
    public class Pluto : Card
    {
        public Pluto()
        {
            this.God = new God("Плутон", "Pluto.png", "Много букав про Плутона");
            this.Pover = 6;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Venus
    /// Реализация абстрактного класса Card.
    /// Карта, которую можно положить как на свободное место, так и на другую карту(при этом покрытая карта забирается на руку)
    /// </summary>
    public class Venus : Card
    {
        public Venus()
        {
            this.God = new God("Венера", "Venus.png", "Много букав про Венеру");
            this.Pover = 2;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Vulcan
    /// Реализация абстрактного класса Card.
    /// Карта, которую можно положить как на свободное место, так и на другую карту(при этом покрытая карта перемещается на любое свободное допустимое место)
    /// </summary>
    public class Vulcan : Card
    {
        public Vulcan()
        {
            this.God = new God("Вулкан", "Vulcan.png", "Много букав про Вулкана");
            this.Pover = 4;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Diana
    /// Реализация абстрактного класса Card.
    /// Карта, после использования которой можно сыграть ещё одну карту
    /// </summary>
    public class Diana : Card
    {
        public Diana()
        {
            this.God = new God("Диана", "Diana.png", "Много букав про Диану");
            this.Pover = 1;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Mars
    /// Реализация абстрактного класса Card.
    /// Карта, после разыгрывания которой можно "забрать" линию находящуюся между двумя такими картами
    /// </summary>
    public class Mars : Card
    {
        public Mars()
        {
            this.God = new God("Марс", "Mars.png", "Много букав про Марса");
            this.Pover = 3;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Feb
    /// Реализация абстрактного класса Card.
    /// Карта, свойства которой выбираются при разыгрывании(карта, которой он станет). Методы beforeUse и afterUse используются от выбранной карты
    /// </summary>
    public class Feb : Card
    {
        Card jokerRole;

        /// <summary>
        /// Свойство, содержащее карту, которой является Феб
        /// </summary>
        public Card JokerRole
        {
            get { return jokerRole; }
            set { jokerRole = value; this.Pover = value.Pover; }
        }

        public Feb()
        {
            this.God = new God("Феб", "Feb.png", "Много букав про Феба");
            this.Pover = 0;
        }

        public override void beforeUse(Game game)
        {
            throw new NotImplementedException();
        }

        public override void afterUse(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
