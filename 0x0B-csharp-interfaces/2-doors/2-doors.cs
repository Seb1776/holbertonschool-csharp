using System;

///<summary>Base class</summary>
public abstract class Base
{
    ///<summary>name property</summary>
    public string name;

    ///<summary>Override of ToString method</summary>
    public override string ToString()
    {
        string _ret = name + " is a " + GetType();
        return _ret;
  
    }
}

///<summary>TestObject class</summary>
public class Door : Base, IInteractive
{
    ///<summary>Door constructor</summary>
    public Door(string name)
    {
        if (name == string.Empty)
            this.name = "Door";
        
        else
            this.name = name;
    }

    ///<summary>Interact method</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the " + name + ". It's locked.");
    }
}

///<summary>Interactive interface</summary>
interface IInteractive
{
    void Interact();
}

///<summary>Breakable interface</summary>
interface IBreakable
{
    int durability {get; set;}

    void Break();
}

///<summary>Collectable interface</summary>
interface ICollectable
{
    bool isCollectable {get; set;}

    void Collect();
}
