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
            DateTime myDateTimeVariable = new DateTime(2003, 06, 17, 15, 1, 0);
            DateTime myDateTimeVariable2 = new DateTime(1980, 04, 21, 9, 0, 53);

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);

            Console.WriteLine(result);

            if(result==1)
            {
                Console.WriteLine("The first date is greater");
            }
            else
            {
                Console.WriteLine("The second date is greater");
            }
        }
    }
}

