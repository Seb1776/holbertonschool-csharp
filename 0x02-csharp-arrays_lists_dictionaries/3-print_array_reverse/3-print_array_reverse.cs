using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null && array.Length > 0)
        {
            for (int i = array.Length - 1; i >= 1; i--)
                Console.Write("{0} ", array[i]);

            Console.WriteLine("{0}", array[0]);
        }

        else
            Console.Write("\n");
    }
}
