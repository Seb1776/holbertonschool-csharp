using System;

///<summary>Generic Queue class</summary>
class Queue<T>
{
    ///<summary>Returns the passed generic type</summary>
        ///<return>The string of the generic type</return>
    public Type CheckType()
    {
        return typeof(T);
    }
}
