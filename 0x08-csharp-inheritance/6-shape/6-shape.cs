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

///<summary>Rectangle class, inherits from Shape</summary>
public class Rectangle : Shape
{
    int width, height;

    ///<summary>Width constructor</summary>
    public int Width
    {
        get { return width; }

        set 
        { 
            if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
            else width = value;
        }
    }

    ///<summary>Height constructor</summary>
    public int Height
    {
        get { return height; }

        set 
        {
            if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
            else height = value;
        }
    }
}
