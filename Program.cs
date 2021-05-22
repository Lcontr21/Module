using System;
using Module.Models;
using Module.DTOS;
using System.Collections.Generic;

namespace Module
{
    class Program
    {
       
        static void Main()
        {
            //User myUser = new User();
            //myUser.username = "Totally_Cool_Dude";
            //myUser.password = "1234567890";


            //UserDTO newDTOUser = new UserDTO();
            //newDTOUser.username = "Totally_Cool_Dude";
            //newDTOUser.password = "1234567890";

            //Console.WriteLine(newDTOUser.username);
            //Console.WriteLine(newDTOUser.password);


            //DateTime myDateTimeVariable = new DateTime(2003, 06, 17, 15, 1, 0);
            //DateTime myDateTimeVariable2 = new DateTime(1980, 04, 21, 9, 0, 53);

            //if (myDateTimeVariable < myDateTimeVariable2) 
            //{
            //    Console.WriteLine("Its True");
            //}
            //else
            //{
            //    Console.WriteLine("Its false");
            //}


            //for (int x=0;x<210;x++)
            //{
            //    Console.WriteLine("Line:" + x);
            //}

            int[] myArray = new int[5];

            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            List<int> myList = new List<int>();

            myList.Add(10);
            myList.Add(11); ;
            myList.Add(12);
            myList.Add(13);
            myList.Add(14);
            myList.Add(15);
            myList.Add(16);
            myList.Add(17);
            myList.Add(18);
            myList.Add(19);

            foreach(var item in myList)
            {
                Console.Write(item + ",");
            }



        }

    }    
}

