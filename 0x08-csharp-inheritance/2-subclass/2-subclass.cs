using System;

///<summary>Obj class</summary>
class Obj
{
    ///<summary>Bool method that checks if obj is a subclass</summary>
        ///<param name="derivedType">Subclass of</param>
        ///<param name="baseType">Main class</param>
        ///<returns>True if its a subclass, false if not</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType)) return true;

        return false;
    }
}
