using System;

///<summary>Generic Queue class</summary>
public class Queue<T>
{
    ///<summary>Returns the passed generic type</summary>
        ///<returns>The string of the generic type</returns>
    public string CheckType()
    {
        return (typeof(T)).ToString();
    }
}
