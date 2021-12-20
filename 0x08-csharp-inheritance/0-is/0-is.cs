using System;

///<summary>Obj class</summary>
class Obj
{
    ///<summary>Bool method that checks if obj is an int</summary>
        ///<param name="obj">Object to check</param>
        ///<returns>True if its int, false if not</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int) return true;

        return false;
    }
}
