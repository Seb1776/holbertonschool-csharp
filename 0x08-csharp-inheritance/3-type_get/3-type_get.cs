using System;
using System.Reflection;

///<summary>Obj class</summary>
class Obj
{
    ///<summary>Method that prints all properties of an object</summary>
        ///<param name="myObj">Object to print properties</param>
    public static void Print(object myObj)
    {
        PropertyInfo[] props = myObj.GetType().GetProperties();
        MethodInfo[] methods = myObj.GetType().GetMethods();
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);

        foreach (PropertyInfo prop in props)
            Console.WriteLine(prop.Name);

        Console.WriteLine("{0} Methods:", myObj.GetType().Name);

        foreach (MethodInfo method in methods)
            Console.WriteLine(method.Name);
    }
}
