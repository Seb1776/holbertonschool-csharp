using System;

///<summary>Base class</summary>
public abstract class Base
{
    ///<summary>name property</summary>
    public string name;

    ///<summary>Override of ToString method</summary>
    public override string ToString()
    {
        string _ret = this.name + " is a " + this.GetType();
        return _ret;
    }
}

///<summary>TestObject class</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>Durability property</summary>
    public int durability {get; set;}
    ///<summary>IsCollectable property</summary>
    public bool isCollectable {get; set;}

    ///<summary>Interact method</summary>
    public void Interact()
    {

    }

    ///<summary>Break method</summary>
    public void Break()
    {

    }

    ///<summary>Collect Method</summary>
    public void Collect()
    {

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
