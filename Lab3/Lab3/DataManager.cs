using System;
using System.IO;
using System.Linq;

namespace Lab3
{
    class DataManager
    {
        private const string FILE_NAME_1 = @".\data\Random1.txt";
        private const string FILE_NAME_2 = @".\data\Random2.txt";
        private const string FILE_NAME_3 = @".\data\Random3.txt";

        private int[] ReadNumbers(string fileName)
        {
            return File.ReadAllText(fileName)
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();
        }

        public int[] GetRandom1Values()
        {
            return ReadNumbers(FILE_NAME_1);
        }

        public int[] GetRandom2Values()
        {
            return ReadNumbers(FILE_NAME_2);
        }

        public int[] GetRandom3Values()
        {
            return ReadNumbers(FILE_NAME_3);
        }
    }
}
