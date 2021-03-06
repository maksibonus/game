﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GameTests
{
    /// <summary>
    /// Колекція відповідей.
    /// </summary>
    public class AnswerCollection : IEnumerable, IEnumerator
    {
        #region Поля класу

        /// <summary>
        /// Список відповідей.
        /// </summary>
        List<Answer> answers;

        /// <summary>
        /// Кількість правильних відповідей.
        /// </summary>
        int rightCount;

        /// <summary>
        /// Індекс, що використовується інтерфейсом IEnumerator.
        /// </summary>
        int index;

        #endregion Поля класу

        #region Реалізація інтерфейсів

        // Реалізуємо інтерфейс IEnumerable.
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // Реалізуємо інтерфейс IEnumerator.
        public bool MoveNext()
        {
            if (index == answers.Count - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return answers[index];
            }
        }

        #endregion Реалізація інтерфейсів

        #region Конструктори

        /// <summary>
        /// Ініціалізує поля класу початковими значеннями за замовчуванням.
        /// </summary>
        public AnswerCollection()
        {
            answers = new List<Answer>();
            rightCount = 0;
            index = -1;
        }

        #endregion Конструктори

        #region Індексатори

        /// <summary>
        /// Повертає відповідь за вказаним номером.
        /// </summary>
        /// <param name="i">Номер відповіді.</param>
        /// <returns>Відповідь за вказаним номером.</returns>
        public Answer this[int i]
        {
            get
            {
                return answers[i];
            }
        }

        /// <summary>
        /// Повертає відповідь за вказаним текстом.
        /// </summary>
        /// <param name="text">Текст відповіді.</param>
        /// <returns>Відповідь за вказаним текстом.</returns>
        public Answer this[string text]
        {
            get
            {
                foreach (Answer answer in answers)
                    if (answer.Text == text)
                        return answer;
                return null;
            }
        }

        #endregion Індексатори

        #region Властивості

        /// <summary>
        /// Повертає кількість відповідей у колекції.
        /// </summary>
        public int Count
        {
            get
            {
                return answers.Count;
            }
        }

        /// <summary>
        /// Повертає кількість правильних відповідей у колекції.
        /// </summary>
        public int RightCount
        {
            get
            {
                return rightCount;
            }
        }

        #endregion Властивості

        #region Методи

        /// <summary>
        /// Додає відповідь до колекції.
        /// </summary>
        /// <param name="answer">Відповідь, яку необхідно додати до колекції.</param>
        internal void Add(Answer answer)
        {
            answers.Add(answer);
            if (answer.IsRight)
                rightCount++;
        }

        /// <summary>
        /// Повертає індекс відповіді у колекції.
        /// </summary>
        /// <param name="answer">Відповідь, індекс у колекції якої необхідно отримати.</param>
        /// <returns>Індекс відповіді у колекції.</returns>
        public int IndexOf(Answer answer)
        {
            return answers.IndexOf(answer);
        }

        /// <summary>
        /// Повертає індекс відповіді у колекції.
        /// </summary>
        /// <param name="answerText">Текст відповіді, індекс у колекції якої необхідно отримати.</param>
        /// <returns>Індекс відповіді у колекції.</returns>
        public int IndexOf(string answerText)
        {
            return answers.IndexOf(this[answerText]);
        }

        #endregion Методи
    }
}
