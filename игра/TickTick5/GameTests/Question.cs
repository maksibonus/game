using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTests
{
    // Клас, що зберігає в собі запитання та відповіді на нього.
    public class Question
    {
        #region Поля класу

        string text;                // текст запитання
        QuestionType type;          // тип запитання
        AnswerCollection answers;   // колекція відповідей на запитання

        #endregion Поля класу

        #region Конструктори

        // Ініціалізує клас початковими значеннями за замовчуванням.
        public Question()
        {
#warning Додати реалізацію!
        }

        #endregion Конструктори

        #region Властивості

        // Повертає текст запитання.
        public string Text
        {
            get
            {
                return text;
            }
        }

        // Повертає тип запитання.
        public QuestionType Type
        {
            get
            {
                return type;
            }
        }

        // Повертає колекцію відповідей на запитання.
        public AnswerCollection Answers
        {
            get
            {
                return answers;
            }
        }

        #endregion Властивості

        #region Методи

        // Повертає true, якщо відповідь за вказаним номером є вірною.
        public bool IsRightAnswer(int answerIndex)
        {
            return answers[answerIndex].IsRight;
        }

        // Повертає true, якщо відповідь за вказаним текстом є вірною.
        public bool IsRightAnswer(string answerText)
        {
            return answers[answerText].IsRight;
        }

        #endregion Методи
    }
}
