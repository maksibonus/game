using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GameTests
{
    // Колекція відповідей.
    public class AnswerCollection : IEnumerable, IEnumerator
    {
        #region Поля класу

        List<Answer> answers;       // список відповідей
        int rightCount;             // кількість правильних відповідей
        int index;                  // індекс, що використовується інтерфейсом IEnumerator

        #endregion Поля класу

        #region Реалізація інтерфейсів

        // Реалізуємо інтерфейс IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // Реалізуємо інтерфейс IEnumerator
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

        // Ініціалізує клас початковими значеннями за замовчуванням.
        public AnswerCollection()
        {
#warning Додати реалізацію!
            index = -1;
        }

        #endregion Конструктори

        #region Індексатори

        // Повертає відповідь за вказаним номером.
        public Answer this[int i]
        {
            get
            {
                return answers[i];
            }
        }

        // Повертає відповідь за вказаним текстом.
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

        // Повертає кількість відповідей у колекції.
        public int Count
        {
            get
            {
                return answers.Count;
            }
        }

        // Повертає кількість правильних відповідей у колекції.
        public int RightCount
        {
            get
            {
                return rightCount;
            }
        }

        #endregion Властивості

        #region Методи

        // Повертає індекс відповіді у колекції.
        public int IndexOf(Answer answer)
        {
            return answers.IndexOf(answer);
        }

        // Повертає індекс відповіді у колекції.
        public int IndexOf(string answerText)
        {
            return answers.IndexOf(this[answerText]);
        }

        #endregion Методи
    }
}
