// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int row = 4,
                columns = 3;

            int[,] array = new int[row, columns];

            FillArray(array);
            PrintArray(array);
            Console.WriteLine();

            List<int> sumRows = SumRow(array);
            PrintList(sumRows);

            Console.WriteLine();
            FindMinRow(sumRows, row);
        }

        public static void FillArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
        }

        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static List<int> SumRow(int[,] arr)
        {
            List<int> list = new List<int>();
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {   
                    sum += arr[i, j];
                }
                
                list.Add(sum);
                sum = 0;
            }
            return list;
        }

        public static void PrintList(List<int> list)
        {
            foreach (int element in list)
            {
                Console.Write($"{element} ");
            }
        }

        public static void FindMinRow(List<int> list, int row)
        {
            int minRow = 0;
            for (int i = 1; i < row; i++)
            {
                if (list[i] < list[minRow])
                {
                    minRow = i;
                }
            }
            Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow + 1} строка");
        }
    }
}     



