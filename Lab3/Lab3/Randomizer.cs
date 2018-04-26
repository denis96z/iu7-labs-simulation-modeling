using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /// <summary>
    /// Датчик случайных чисел.
    /// </summary>
    interface IRandomizer
    {
        int RandomOneDigit();
        int RandomTwoDigit();
        int RandomThreeDigit();
    }

    /// <summary>
    /// Датчик случайных чисел на основе табличных значений.
    /// </summary>
    class TableRandomizer : IRandomizer
    {
        class RandomArray
        {
            public int[] Values;
            public int Index;
        }

        private RandomArray random1, random2, random3;

        public TableRandomizer()
        {
            var dataManager = new DataManager();

            random1 = new RandomArray()
            {
                Values = dataManager.GetRandom1Values(),
                Index = 0
            };

            random2 = new RandomArray()
            {
                Values = dataManager.GetRandom2Values(),
                Index = 0
            };

            random3 = new RandomArray()
            {
                Values = dataManager.GetRandom3Values(),
                Index = 0
            };
        }

        private int GetNext(RandomArray random)
        {
            int value = random.Values[random.Index++];
            if (random.Index == random.Values.Length)
            {
                random.Index = 0;
            }
            return value;
        }

        public int RandomOneDigit()
        {
            return GetNext(random1);
        }

        public int RandomTwoDigit()
        {
            return GetNext(random2);
        }

        public int RandomThreeDigit()
        {
            return GetNext(random3);
        }
    }

    /// <summary>
    /// Датчик случайных чисел на основе конгруэнтного метода.
    /// </summary>
    class MathRandomizer : IRandomizer
    {
        private int prevValue1, prevValue2, prevValue3;

        public MathRandomizer(int initValue1 = 1,
            int initValue2 = 1, int initValue3 = 1)
        {
            prevValue1 = initValue1;
            prevValue2 = initValue2;
            prevValue3 = initValue3;
        }

        private int NextValue(ref int prevValue, int a, int c, int min, int m)
        {
            int value = min + ((a * prevValue + c) % m);
            prevValue = value;
            return value;
        }

        public int RandomOneDigit()
        {
            return NextValue(ref prevValue1, 1, 3, 0, 10);
        }

        public int RandomTwoDigit()
        {
            return NextValue(ref prevValue2, 31, 11, 10, 90);
        }

        public int RandomThreeDigit()
        {
            return NextValue(ref prevValue3, 121, 117, 100, 900);
        }
    }
}
