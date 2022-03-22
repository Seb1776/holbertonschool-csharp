using System;

///<summary>Generic Queue class</summary>
public class Queue<T>
{
    ///<summary>Returns the passed generic type</summary>
    public string CheckType()
    {
        return (typeof(T)).ToString();
    }
}
