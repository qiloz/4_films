
using System.Runtime.CompilerServices;

namespace Program
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int width;
            int height;

            Console.WriteLine("Введите длину матрицы: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину матрицы: ");
            height = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[width, height];
            int[] answerMatrix = new int[height];


            for (int i = 0; i < matrix.GetLength(0); i++) // random values
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(100);
                }
            }
            Console.WriteLine();

            int maxValue = -1;
            int minValue = 101;
            
            for (int i = 0; i < matrix.GetLength(0); i++) // print
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                    }
                    if (matrix[i,j] < minValue)
                    {
                        minValue = matrix[i, j];
                    }
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            Console.WriteLine("Максимальное значение: {0}, Минимальное значение: {1}, Сумма: {2}\n", maxValue, minValue, maxValue+minValue);
        }
    }
}
