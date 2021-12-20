using System;

///<summary>Shape class</summary>
public class Shape
{
    ///<summary>Method that throws a new exception</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
