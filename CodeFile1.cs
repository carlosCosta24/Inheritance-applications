using System;

public partial class MyClass {

    public int Id = 325;
    public void MethodOne() 
    {
        Console.WriteLine("First Part of the Class");
    }
    partial void PrintId();
}