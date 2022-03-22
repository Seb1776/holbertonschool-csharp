using System;

///<summary>Generic Queue class</summary>
class Queue<T>
{
    ///<summary>Returns the passed generic type</summary>
        ///<returns>The string of the generic type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
