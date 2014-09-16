using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    public abstract class Card
    {
        God god;

        public God God
        {
            get { return god; }
            set { god = value; }
        }

        int pover;

        public int Pover
        {
            get { return pover; }
            set { pover = value; }
        }
        
    }

    public class Jupiter : Card
    {
        public Jupiter()
        {
            this.God = new God("Юпитер", "Jupiter.png", "Много букав про Юпитреа");
            this.Pover = 0;
        }
    }

    public class Juno : Card
    {
        public Juno()
        {
            this.God = new God("Юнона", "Juno.png", "Много букав про Юнону");
            this.Pover = 7;
        }
    }

    public class Neptune : Card
    {
        public Neptune()
        {
            this.God = new God("Нептун", "Neptune.png", "Много букав про Нептуна");
            this.Pover = 5;
        }
    }

    public class Pluto : Card
    {
        public Pluto()
        {
            this.God = new God("Плутон", "Pluto.png", "Много букав про Плутона");
            this.Pover = 6;
        }
    }

    public class Venus : Card
    {
        public Venus()
        {
            this.God = new God("Венера", "Venus.png", "Много букав про Венеру");
            this.Pover = 2;
        }
    }

    public class Vulcan : Card
    {
        public Vulcan()
        {
            this.God = new God("Вулкан", "Vulcan.png", "Много букав про Вулкана");
            this.Pover = 4;
        }
    }

    public class Diana : Card
    {
        public Diana()
        {
            this.God = new God("Диана", "Diana.png", "Много букав про Диану");
            this.Pover = 1;
        }
    }

    public class Mars : Card
    {
        public Mars()
        {
            this.God = new God("Марс", "Mars.png", "Много букав про Марса");
            this.Pover = 3;
        }
    }

    public class Feb : Card
    {
        Card jokerRole; // В этом поле хранится карта, которую для него выберет игрок 

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
    }
}
