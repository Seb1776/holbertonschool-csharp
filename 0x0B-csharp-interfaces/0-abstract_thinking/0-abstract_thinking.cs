using System;

///<summary>name property</summary>
public abstract class Base
{
    ///<summary>name property</summary>
    public string name;

    ///<summary>Override of ToString method</summary>
    public override string ToString()
    {
        string _ret = name + " is " + GetType();
        return _ret;
    }
}
