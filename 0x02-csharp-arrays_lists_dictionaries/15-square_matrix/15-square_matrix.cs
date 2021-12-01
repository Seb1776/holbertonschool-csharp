using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] retMatrix = myMatrix;

        for (int i = 0; i < retMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < retMatrix.GetLength(1); j++)
            {
                double sqrtR = Convert.ToDouble(retMatrix[i, j]);
                int reAssgn = Convert.ToInt16(Math.Pow(sqrtR, 2));
                retMatrix[i, j] = reAssgn;
            }
        }

        return retMatrix;
    }
}
