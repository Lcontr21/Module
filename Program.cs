using System;
using Module.Models;
using Module.DTOS;
using System.Collections.Generic;
using System.Linq;

namespace Module
{
    class Program
    {

        static void Main()
        {
            RegularClass myNewClass = new RegularClass();

            myNewClass.PrintsSomethingToTheConsole<string>(345678, "This is the 1st string", "This is the 2nd string");
        }
    }
}

public class RegularClass
{
    public void PrintsSomethingToTheConsole<T>(int parameter1, string parameter2, T parameter3)
    {
        Console.WriteLine("The values of the parameters are the following:");
        Console.WriteLine(parameter1);
        Console.WriteLine(parameter2);
        Console.WriteLine(parameter3);
    }
}
