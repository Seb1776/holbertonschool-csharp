using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size >= 0)
        {
            int[] retArray = new int[size];

            if (size == 0)
                Console.Write("\n");

            else
            {
                for (int i = 0; i < size; i++)
                {   
                    if (i != size - 1)
                    {
                        retArray[i] = i;
                        Console.Write("{0} ", i);
                    }

                    else if (i == size - 1)
                    {
                        retArray[size - 1] = size - 1;
                        Console.WriteLine("{0}", retArray[size - 1]);
                    }
                }
            }

            return retArray;
        }

        Console.WriteLine("Size cannot be negative");
        return null;    
    }
}
