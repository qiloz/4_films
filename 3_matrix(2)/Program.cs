
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

            double[,] matrix = new double[width, height];
            double[] answerMatrix = new double[height];


            for (int i = 0; i < matrix.GetLength(0); i++) // random values
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    double r = Convert.ToDouble(rnd.Next(-100, 100) / 100.0);
                    matrix[i, j] = r;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++) // print
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i,j] < 0)
                    {
                        sum += matrix[i, j];
                    }
                    answerMatrix[j] = sum;
                }

                sum = 0;
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < answerMatrix.GetLength(0); i++)
            {
                Console.Write("{0}\t", Math.Round(answerMatrix[i],2));
            }
            Console.ReadLine();
        }

    }

}
