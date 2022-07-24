// Задача 58: Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Массив №1");
            int[,] array1 = FillArray();
            PrintArray(array1);
            Console.WriteLine();

            Console.WriteLine("Массив №2");
            int[,] array2 = FillArray();
            PrintArray(array2);
            Console.WriteLine();

            Console.WriteLine("Массив произведений элементов двух предыдущих массивов");
            int[,] array3 = Multiplication(array1, array2);
            PrintArray(array3);

        }

        public static int[,] FillArray()
        {
            int row = 4,
                columns = 4;
            
            int[,] arr = new int[row, columns];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            return arr;
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

        public static int[,] Multiplication(int[,] arr1, int[,] arr2)
        {
            int[,] mult = new int[arr1.GetLength(0), arr1.GetLength(1)];
            
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {   
                    mult[i, j] = arr1[i, j] * arr2[i, j];
                }
            }
            return mult;
        }
    }
}     



