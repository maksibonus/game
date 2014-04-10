using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTests
{
    // Клас відповіді на запитання.
    public class Answer
    {
        #region Поля класу

        string text;                // текст відповіді
        bool isRight;               // прапорець, що вказує, чи є відповідь вірною
        Question question;          // класс запитання, якому належить відповідь

        #endregion Поля класу

        #region Конструктори

        // Ініціалізує клас початковими значеннями за замовчуванням.
        public Answer()
        {
#warning Додати реалізацію!
            question = null;
        }

        #endregion Конструктори

        #region Властивості

        // Повертає текст відповіді.
        public string Text
        {
            get
            {
                return text;
            }
        }

        // Вказує, чи є відповідь вірною.
        public bool IsRight
        {
            get
            {
                return isRight;
            }
        }

        // Повертає або задає класс запитання, якому належить відповідь.
        public Question Question
        {
            internal set
            {
                question = value;
            }
            get
            {
                return question;
            }
        }

        #endregion Властивості
    }
}
