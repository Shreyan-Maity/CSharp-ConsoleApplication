using System;

class Program
{
    //Properties
    int age { get; set; }
    string name { get; set; }

    //Constructor
    public Program(int age ,string name)
    {
        this.name = name;
        this.age = age;
    }
    //OutPut Method
    public void Output()
    {
        Console.WriteLine($"Hi, {name}. \nSo you are {age} years old.");
    }
    //Main Method
    public static void Main()
    {
        Program New = new Program(25, "Shreyan");
        New.Output();
    }
}