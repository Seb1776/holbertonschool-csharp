using System;

public class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

public class Rectangle : Shape
{
    int width, height;

    public int Width
    {
        get { return width; }

        set 
        { 
            if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
            else width = value;
        }
    }

    public int Height
    {
        get { return height; }

        set 
        { 
            if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
            else height = value;
        }
    }

    public new int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}

public class Square : Shape
{
    int size;

    public int Size
    {
        get { return size; }

        set 
        { 
            if (value < 0) throw new ArgumentException("Size must be greater than or equal to 0");
            else size = value;
        }
    }
}
