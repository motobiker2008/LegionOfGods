using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegionOfGods
{
    /// <summary>
    /// Класс, определяющий логику для дополнительных способностей в игре
    /// </summary>
 
    class Ability
    {

        private NameAbility _name; // имя божества, соответствующего способности
        private String _description; // строка с описанием способности
        private bool _isUsed; // флажок, определяющий, доступна ли для использования в игре способность 

        public Ability(NameAbility name)
        {
            _name = name;
            _isUsed = true;
            DetermineDescription();
        }

        public NameAbility GetName()
        {
            return _name;
        }

        public static NameAbility? GetName(int number)
        {
            switch (number)
            {
                case 1:
                    return NameAbility.VESTA;
                case 2:
                    return NameAbility.MERCURY;
                case 3:
                    return NameAbility.ESCULAPIUS;
                case 4:
                    return NameAbility.TRIVIA;
                default:
                    break;
            }   
            return null;
        }

        public String GetDescription()
        {
            return _description;
        }

        private void DetermineDescription() // определяет описание способности
        {
            switch (_name)
            {
                case NameAbility.VESTA:
                    // _description = "...";
                    break;
                case NameAbility.MERCURY:
                    // _description = "...";
                    break;
                case NameAbility.ESCULAPIUS:
                    // _description = "...";
                    break;
                case NameAbility.TRIVIA:
                    // _description = "...";
                    break;
                default:
                    break;
            }    
        }

        public bool IsAvailable() // возвращет булево значение, определяющее доступна ли способность для использования
        {
            return _isUsed;
        }

        public void ChangeAvailability() // изменения статуса доступности способности
        {
            _isUsed = !_isUsed;
        }

        public void MakeNotAvailable() // сделать способность недоступной для использования
        {
            _isUsed = false;
        }

    }
}
