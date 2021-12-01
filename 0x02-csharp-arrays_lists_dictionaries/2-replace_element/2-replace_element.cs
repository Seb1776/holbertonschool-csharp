using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        int[] newArray = array;

        if (index >= array.Length || index < 0)
        {
            Console.WriteLine("Index out of range");
            return array;
        }

        newArray[index] = n;
        return newArray;
    }
}
