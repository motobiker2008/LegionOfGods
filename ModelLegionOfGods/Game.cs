using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLegionOfGods
{
    /// <summary>
    /// Класс Game
    /// Содержит всю информацию об игре и предоставляет интерфейся для взаимодействия с GUI
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Двумерный массив, хранязий поле 9х9
        /// </summary>
        Card[][] Board;

        /// <summary>
        /// Список игроков
        /// </summary>
        List<Player> players;

        /// <summary>
        /// Колода свободных карт
        /// </summary>
        List<Card> descCards;

        bool isStart;
        bool isPause;
        Player activePlayer;

        /// <summary>
        /// Свойстов, содержащее информацию идёт игра или нет
        /// </summary>
        public bool IsStart
        {
            get { return isStart; }
            set { isStart = value; }
        }

        /// <summary>
        /// Свойство, обозначающее поставлена игра на паузу или нет
        /// </summary>
        public bool IsPause
        {
            get { return isPause; }
            set { isPause = value; }
        }

        /// <summary>
        /// Свойство, в котором содержится активный игрок
        /// </summary>
        public Player ActivePlayer
        {
            get { return activePlayer; }
        }

        public Game()
        {
            Board = new Card[9][];
            for (int i = 0; i < 9; i++)
            {
                Board[i] = new Card[9];
                for (int j = 0; j < 9; j++)
                    Board[i][j] = null;
            }
            isStart = false;
            isPause = false;
            activePlayer = null;
            List<Player> players = new List<Player>(2);
            List<Card> descCards = new List<Card>(50);
        }

        /// <summary>
        /// Метод, возвращающий содержание клетки поля
        /// </summary>
        /// <param name="i">Номер клетки по вертикали(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j">Номер клетки по горизонали(нумерация начинается из верхнего левого угла с {0,0}</param>
        /// <returns>Карта, которая находится в клетке или null, если она пустая</returns>
        public Card getCell(int i, int j)
        {
            return Board[i][j];
        }

        /// <summary>
        /// Метод, который начинает новую игру(сбрасывает все состояния игры к начальным)
        /// </summary>
        /// <returns>True в случае нормального завершения</returns>
        public bool newGame()
        {
            return true;
        }

        /// <summary>
        /// Метод, который вызывается при завершении игры
        /// </summary>
        /// <returns>True в случае нормального завершения</returns>
        public bool endGame()
        {
            return true;
        }

        /// <summary>
        /// Использование специальной способноси
        /// </summary>
        /// <param name="ability">Объект SpecialAbility способность которого нужно выполнить</param>
        /// <returns>True в случае нормального завершения</returns>
        public bool useSpecialAbilityes(SpecialAbility ability)
        {
            ability.use(this);
            return true;
        }

        /// <summary>
        /// Метод, вызываемый при ходе игрока
        /// </summary>
        /// <param name="i">Номер клетки по вертикали(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j">Номер клетки по горизонали(нумерация начинается из верхнего левого угла с {0,0}</param>
        /// <param name="card">Карта, которую желает использовать игрок</param>
        /// <returns>True в случае нормального завершения</returns>
        public bool move(int i, int j, Card card)
        {
            if (this.checkMove(i, j, card))
            {
                card.beforeUse(this);
                Board[i][j] = card;
                card.afterUse(this);
                this.scoring(i, j);
                if (this.checkEnd())
                    this.endGame();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Применение спец. способности Венеры(забирает на руку карту с позици i j)
        /// </summary>
        /// <param name="i">Номер клетки по вертикали(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j">Номер клетки по горизонали(нумерация начинается из верхнего левого угла с {0,0}</param>
        /// <returns>True в случае нормального завершения</returns>
        public bool venusChange(int i, int j)
        {
            return true;
        }

        /// <summary>
        /// Применение спец. способности Вулкана(перемещает карту с позиции i,j на позицию new_i,new_j)
        /// </summary>
        /// <param name="i">Номер клетки по вертикали старого положения карты(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j">Номер клетки по горизонали старого положения карты(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="new_i">Номер клетки по вертикали нового положения карты(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="new_j">Номер клетки по горизонали нового положения карты(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <returns>True в случае нормального завершения</returns>
        public bool vulcanCast(int i, int j, int new_i, int new_j)
        {
            return true;
        }

        /// <summary>
        /// Применение спец. способности Дианы(даёт возможность сыграть ещё одну карту)
        /// </summary>
        /// <param name="i">Номер клетки по вертикали, куда играется карта(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j">Номер клетки по горизонали, куда играется карта(нумерация начинается из верхнего левого угла с {0,0}</param>
        /// <param name="card">Ещё одна карта</param>
        /// <returns>True в случае нормального завершения</returns>
        public bool dianaAddMove(int i, int j, Card card)
        {
            return true;
        }

        /// <summary>
        /// Применение спец. способности Феба(выбор карты, которой он теперь является)
        /// </summary>
        /// <param name="joker">Карта, которой станет Феб</param>
        /// <returns>True в случае нормального завершения</returns>
        public bool febChooseJoker(Card joker)
        {
            return true;
        }

        /// <summary>
        /// Применение спец. способности Весты(забирает на руку карту с позици i j)
        /// </summary>
        /// <param name="i">Номер клетки по вертикали(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j">Номер клетки по горизонали(нумерация начинается из верхнего левого угла с {0,0}</param>
        /// <returns>True в случае нормального завершения</returns>
        public bool vestaGetCard(int i, int j)
        {
            return true;
        }

        /// <summary>
        /// Применение спец. способности Меркурия(меняет местами 2 карты на поле)
        /// </summary>
        /// <param name="i1">Номер клетки по вертикали первой карты(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j1">Номер клетки по горизонали первой карты(нумерация начинается из верхнего левого угла с {0,0}</param>
        /// <param name="i2">Номер клетки по вертикали второй карты(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j2">Номер клетки по горизонали второй карты(нумерация начинается из верхнего левого угла с {0,0}</param>
        /// <returns>True в случае нормального завершения</returns>
        public bool mercuryChangeCard(int i1, int j1, int i2, int j2)
        {
            return true;
        }

        /// <summary>
        /// Применение спец. способности Эскулапа(увеличивает в 2 раза силу карты, сыгранной в этом ходу)
        /// </summary>
        /// <returns>True в случае нормального завершения</returns>
        public bool aesculapiusPower()
        {
            return true;
        }

        /// <summary>
        /// Применение спец. способности Тривии(активный игрок получает ещё дополнительную карту из колоды)
        /// </summary>
        /// <returns>True в случае нормального завершения</returns>
        public bool triviaAddCard()
        {
            return true;
        }

        /// <summary>
        /// Метод, проверяющий возможность сыграть карту card на клетку i,j
        /// </summary>
        /// <param name="i">Номер клетки по вертикали(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j">Номер клетки по горизонали(нумерация начинается из верхнего левого угла с {0,0}</param>
        /// <param name="card">карта, которую играют</param>
        /// <returns>True в случае нормального завершения</returns>
        private bool checkMove(int i, int j, Card card)
        {
            return true;
        }

        /// <summary>
        /// Подсчёт очков, полученных игроком после его хода
        /// </summary>
        /// <param name="i">Номер клетки по вертикали, где была сыграна карта(нумерация начинается из верхнего левого угла с {0,0})</param>
        /// <param name="j">Номер клетки по горизонали. где была сыграна карта(нумерация начинается из верхнего левого угла с {0,0}</param>
        private void scoring(int i, int j)
        {

        }

        /// <summary>
        /// Проверка, не закончилась ли игра после хода игрока
        /// </summary>
        /// <returns>True, если игра закончена, false иначе</returns>
        private bool checkEnd()
        {
            return true;
        }
    }
}
