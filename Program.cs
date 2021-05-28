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
            //UserDTO newDTOUser = new UserDTO();
            //newDTOUser.username = "Totally_Cool_Dude";
            //newDTOUser.password = "1234567890";

            //Console.WriteLine(newDTOUser.username);
            //Console.WriteLine(newDTOUser.password);


            DateTime myDateTimeVariable = new DateTime(2003, 06, 17, 15, 1, 0);
            DateTime myDateTimeVariable2 = new DateTime(1980, 04, 21, 9, 0, 53);

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);

            if (myDateTimeVariable > myDateTimeVariable2)
            {
                Console.WriteLine(myDateTimeVariable);
            }
            else
            {
                Console.WriteLine(myDateTimeVariable2);
            }

            //for (int x=0;x<210;x++)
            //{
            //    Console.WriteLine("Line:" + x);
            //}

            //int[] myArray = new int[5];

            //myArray[0] = 1;
            //myArray[1] = 2;
            //myArray[2] = 3;
            //myArray[3] = 4;
            //myArray[4] = 5;

            //foreach (var item in myArray)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> myList = new List<int>();

            //myList.Add(10);
            //myList.Add(11); ;
            //myList.Add(12);
            //myList.Add(13);
            //myList.Add(14);
            //myList.Add(15);
            //myList.Add(16);
            //myList.Add(17);
            //myList.Add(18);
            //myList.Add(19);

            //foreach(var item in myList)
            //{
            //    Console.Write(item + ",");
            //}

            //    User myUser = new User();
            //    myUser.username1 = "Leonardo Contreras";
            //    myUser.username2 = "McKain";
            //    myUser.username3 = "Frank";

            //    Comments myComments = new Comments();
            //    myComments.positive = "This picture is really pretty, good job";
            //    myComments.negative = "Eww, I hate it, you are bad at taking good photos";
            //    myComments.crucial = "Try to keep a steady hand when taking a picture";


            //    List<string> myUsers = new List<string>();

            //    myUsers.Add("Leonardo Contreras");
            //    myUsers.Add("McKain");
            //    myUsers.Add("Frank");

            //    List<string> myCommments = new List<string>();

            //    myComments.Add("This picture is really pretty, good job");
            //    myComments.Add("Eww, I hate it, you are bad at taking good photos");
            //    myComments.Add("Try to keep a steady hand when taking a picture");
            //}

        }
    }
}
