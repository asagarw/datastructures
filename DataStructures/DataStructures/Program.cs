using System;

namespace DataStructures
{
    class Program
    {
        public int indexOf(int[] array, int numberToFind)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numberToFind)
                    return i + 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] array = { 2, 7, 35, 12, 54, 11, 86, 23, 1 };

            int index = new Program().indexOf(array, 35);

            Console.WriteLine("Index of {0} is {1}", 35, index);
        }
    }
}
