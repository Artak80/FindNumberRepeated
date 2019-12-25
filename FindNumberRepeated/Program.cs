using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumberRepeated
{
    public class Program
    {
        // сортировка пузырьком.
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int buf = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = buf;
                    }
                }
            }
        }
        // метод, который сравнивает соседние цифры.
        public static int FindRepeatedNumber(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array[i + 1])
                {
                    return array[i];
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] array = new int[100];
            // заполнение массива
            for (int i = 0; i < array.Length - 20; i++)
            {
                array[i] = i;
            }
            array[80] = 5;
            for (int i = 81; i < array.Length; i++)
            {
                array[i] = i;
            }

            BubbleSort(array);

            int x = FindRepeatedNumber(array);

            Console.WriteLine($"Повторяющая цифра: {x}");
            Console.ReadKey();
        }
    }
}
