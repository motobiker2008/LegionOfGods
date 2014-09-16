using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    public abstract class SpecialAbility
    {
        God god;

        public God God
        {
            get { return god; }
            set { god = value; }
        }
    }

    public class Vesta : SpecialAbility
    {
        public Vesta()
        {
            this.God = new God("Веста", "Vesta.png", "Много букав про Весту");
        }
    }

    public class Mercury : SpecialAbility
    {
        public Mercury()
        {
            this.God = new God("Меркурий", "Mercury.png", "Много букав про Меркурия");
        }
    }

    public class Aesculapius : SpecialAbility
    {
        public Aesculapius()
        {
            this.God = new God("Эскулап", "Aesculapius.png", "Много букав про Эскулапа");
        }
    }

    public class Trivia : SpecialAbility
    {
        public Trivia()
        {
            this.God = new God("Тривия", "Trivia.png", "Много букав про Тривию");
        }
    }
}
