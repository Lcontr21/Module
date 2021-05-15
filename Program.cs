using System;
using Module.Models;
using Module.DTOS;

namespace Module
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfThreeVariables(10, 5, 6));
        }

        static int SumOfThreeVariables(int value1, int value2, int value3)
        {
            int result = 0;

            result = value1 + value2 - value3;

            return result; 

                
        }
         
    }
}
