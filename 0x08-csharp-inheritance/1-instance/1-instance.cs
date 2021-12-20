using System;
using System.Collections.Generic;

///<summary>Obj class</summary>
class Obj
{
    ///<summary>Bool method that checks if obj is an instance of an array</summary>
        ///<param name="obj">Object to check</param>
        ///<returns>True if its array, false if not</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array) return true;

        return false;
    }
}
