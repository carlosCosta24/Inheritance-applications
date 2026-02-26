using System;

public partial class MyClass
{
    public void MethodTwo() 
    {
        Console.WriteLine("Printing from the second part of the class");
        PrintId();
    }
    partial void PrintId() 
    {
        Console.WriteLine($"Id is : {Id}");
    }
}