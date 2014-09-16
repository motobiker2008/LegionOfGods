using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    /// <summary>
    /// Класс SpecialAbility
    /// Абстрактный класс предоставляющий интерфейс для работы со спец. способностями(использование, получение информации о боге, к которому она относится)
    /// </summary>
    public abstract class SpecialAbility
    {
        God god;

        /// <summary>
        /// Свойство содержащее иформацию о боге, связанном со спец. способностью
        ///</summary>
        public God God
        {
            get { return god; }
            set { god = value; }
        }

        /// <summary>
        /// Метод вызываемый, для использования спец. способности
        /// </summary>
        /// <param name="game">Объект класса Game из которого был вызван метод</param>
        public abstract void use(Game game);
    }

    /// <summary>
    /// Класс Vesta
    /// Реализация абстрактного класса SpecialAbility.
    /// Спец. способность забрать любую карту с поля на руку
    /// </summary>
    public class Vesta : SpecialAbility
    {
        public Vesta()
        {
            this.God = new God("Веста", "Vesta.png", "Много букав про Весту");
        }

        public override void use(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Mercury
    /// Реализация абстрактного класса SpecialAbility.
    /// Спец. способность поменять 2 карты на поле
    /// </summary>
    public class Mercury : SpecialAbility
    {
        public Mercury()
        {
            this.God = new God("Меркурий", "Mercury.png", "Много букав про Меркурия");
        }

        public override void use(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Aesculapius
    /// Реализация абстрактного класса SpecialAbility.
    /// Спец. способность в 2 раза увеличить силу сыгранной в этом ходу карты
    /// </summary>
    public class Aesculapius : SpecialAbility
    {
        public Aesculapius()
        {
            this.God = new God("Эскулап", "Aesculapius.png", "Много букав про Эскулапа");
        }

        public override void use(Game game)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Класс Trivia
    /// Реализация абстрактного класса SpecialAbility.
    /// Спец. способность получить дополнительную карту на руку
    /// </summary>
    public class Trivia : SpecialAbility
    {
        public Trivia()
        {
            this.God = new God("Тривия", "Trivia.png", "Много букав про Тривию");
        }

        public override void use(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
