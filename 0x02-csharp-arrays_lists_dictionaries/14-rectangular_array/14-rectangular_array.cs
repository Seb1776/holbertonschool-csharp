using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] multiArray = new int[5, 5];
            
            for (int i = 0; i < multiArray.GetLength(0); i++)
                for (int j = 0; j < multiArray.GetLength(1); j++)
                    multiArray[i, j] = 0;

            multiArray[2, 2] = 1;

            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                    if (j != multiArray.GetLength(1) - 1)
                        Console.Write(string.Format("{0} ", multiArray[i, j]));
                    else if (j == multiArray.GetLength(1) - 1)
                        Console.Write(string.Format("{0}", multiArray[i, j]));

                Console.Write("\n");
            }
        }
    }
}
