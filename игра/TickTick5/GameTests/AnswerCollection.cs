using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTests
{
    // Колекція відповідей.
    public class AnswerCollection
    {
        #region Поля класу

        List<Answer> answers;       // список відповідей
        int rightCount;             // кількість правильних відповідей

        #endregion Поля класу

#warning Реалізувати інтерфейси IEnumerable, IEnumerator!

        #region Конструктори

        // Ініціалізує клас початковими значеннями за замовчуванням.
        public AnswerCollection()
        {
#warning Додати реалізацію!
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
    }
}
