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

        // Повертає інформацію про кількість правильних і неправильних відповідей.
        public AnswerInfo AreRightAnswers(int[] answersIndexes)
        {
            AnswerInfo answerInfo = new AnswerInfo();

            answerInfo.RightAnswersCount = 0;
            answerInfo.WrongAnswersCount = 0;

            foreach (int answerIndex in answersIndexes)
            {
                if (this.answers[answerIndex].IsRight)
                    answerInfo.RightAnswersCount++;
                else
                    answerInfo.WrongAnswersCount++;
            }

            return answerInfo;
        }

        // Повертає інформацію про кількість правильних і неправильних відповідей.
        public AnswerInfo AreRightAnswers(string[] answersTextStrings)
        {
            AnswerInfo answerInfo = new AnswerInfo();

            answerInfo.RightAnswersCount = 0;
            answerInfo.WrongAnswersCount = 0;

            foreach (string answerText in answersTextStrings)
            {
                if (this.answers[answerText].IsRight)
                    answerInfo.RightAnswersCount++;
                else
                    answerInfo.WrongAnswersCount++;
            }

            return answerInfo;
        }

        // Повертає інформацію про кількість правильних і неправильних відповідей.
        public AnswerInfo AreRightAnswers(Answer[] answerArray)
        {
            AnswerInfo answerInfo = new AnswerInfo();

            answerInfo.RightAnswersCount = 0;
            answerInfo.WrongAnswersCount = 0;

            foreach (Answer answer in answerArray)
            {
                if (answer.IsRight)
                    answerInfo.RightAnswersCount++;
                else
                    answerInfo.WrongAnswersCount++;
            }

            return answerInfo;
        }

        #endregion Методи
    }
}
