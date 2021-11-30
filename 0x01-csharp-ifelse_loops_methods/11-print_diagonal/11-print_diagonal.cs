using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.Write("\n");
        
        else
        {
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                    if (j == i)
                        Console.Write(((char)92).ToString());
                    else
                        Console.Write(" ");
            
                Console.Write("\n");
            }

            Console.Write("\n");
        }
    }
}
