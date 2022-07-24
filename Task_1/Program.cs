// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Исходный массив");
            double[,] array = FillArray();
            PrintArray(array);

            Console.WriteLine();
            Console.Write("Отсортированный массив");
            Console.WriteLine();

            SortRowArray(array);
            PrintArray(array);
        }

        public static double[,] FillArray()
        {
            int row = new Random().Next(2, 10),
                columns = new Random().Next(2, 10);
            
            double[,] arr = new double[row, columns];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            return arr;
        }

        public static void PrintArray(double[,] arr)
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

        public static void SortRowArray(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {   
                    int minCol = j;

                    for (int k = j + 1; k < arr.GetLength(1); k++)
                    {
                        if (arr[i, k] < arr[i, minCol])
                        {
                            minCol = k;
                        }
                    }
                    double temporary = arr[i, j];
                    arr[i, j] = arr[i, minCol];
                    arr[i, minCol] = temporary;
                }
            }
        }
    }
}     


