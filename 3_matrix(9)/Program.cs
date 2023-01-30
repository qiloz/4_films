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
            int maxIndex = -1;
            for (int i = 0; i < matrix.GetLength(0); i++) // print
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j && matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxIndex = j;
                    }
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (j == maxIndex)
                    {
                        answerMatrix[i] = matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальное значение: {0}, Индекс: {1}\n", maxValue, maxIndex);

            for (int i = 0; i < answerMatrix.GetLength(0); i++)
            {
                Console.Write("{0}\t", answerMatrix[i]);
            }
        }
    }
}
