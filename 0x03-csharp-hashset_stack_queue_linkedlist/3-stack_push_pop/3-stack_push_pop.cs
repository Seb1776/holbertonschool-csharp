using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack.Count > 0)
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
            Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));

            if (aStack.Contains(search))
            {
                int numToDelete = 0;

                foreach (String str in aStack)
                {
                    if (str != search)
                        numToDelete++;
                    
                    if (str == search)
                    {
                        numToDelete++;
                        break;
                    }
                }

                for (int i = 0; i < numToDelete; i++)
                    aStack.Pop();
            }

            aStack.Push(newItem);
        }

        else
        {
            Console.WriteLine("Stack is empty");
        }

        return aStack;
    }
}
