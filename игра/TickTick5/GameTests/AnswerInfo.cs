using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTests
{
    // Структура, що містить інформацію про кількість правильних та неправильних відповідей.
    public struct AnswerInfo
    {
        #region Поля структури

        int rightAnswersCount;      // кількість неправильних відповідей
        int wrongAnswersCount;      // кількість правильних відповідей

        #endregion Поля структури

        #region Конструктори

        // Ініціалізує поля структури переданими значеннями.
        public AnswerInfo(int _rightCount, int _wrongCount)
        {
            rightAnswersCount = _rightCount;
            wrongAnswersCount = _wrongCount;
        }

        #endregion Конструктори

        #region Властивості

        // Повертає чи задає кількість правильних відповідей.
        public int RightAnswersCount
        {
            internal set
            {
                rightAnswersCount = value;
            }
            get
            {
                return rightAnswersCount;
            }
        }

        // Повертає чи задає кількість неправильних відповідей.
        public int WrongAnswersCount
        {
            internal set
            {
                wrongAnswersCount = value;
            }
            get
            {
                return wrongAnswersCount;
            }
        }

        // Повертає загальну кількість відповідей.
        public int AnswersCount
        {
            get
            {
                return rightAnswersCount + wrongAnswersCount;
            }
        }

        #endregion Властивості
    }
}
