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


            //DateTime myDateTimeVariable = new DateTime(2003, 06, 17, 15, 1, 0);
            //DateTime myDateTimeVariable2 = new DateTime(1980, 04, 21, 9, 0, 53);

            //int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);

            ////if (myDateTimeVariable > myDateTimeVariable2)
            //{
            //    Console.WriteLine(myDateTimeVariable);
            //}
            //else
            //{
            //    Console.WriteLine(myDateTimeVariable2);
            //}

            //int sum = 0;

            //for (int x=1;x<=20;x++)
            //{
            //    sum += x;
            //}

            //Console.WriteLine("The result is:+ "  + sum);

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

            ////List<int> myList = new List<int>();

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

            string response = "";

            List<User> myUser = new List<User>();
            List<Comments> myComments = new List<Comments>();

            while (response != "5")
            {
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Option 1");
                Console.WriteLine("4. Option 2");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");

                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User newUser = new User();
                        newUser.username1 = "Leonardo Contreras";
                        newUser.username2 = "McKain";
                        newUser.username3 = "Frank";

                        myUser.Add(newUser);

                        Console.WriteLine("The User you created is:");
                                        
                        break;

                    case "2":
                        Comments newComment = new Comments();
                        newComment.positive = "This picture is pretty, I like the vibrant colors";
                        newComment.negative = "I hate how you took the pictuer its all blurry";
                        newComment.crucial = "It seems that you don't have a steady hand, try to buy a stand to take pictures more clearly";

                        myComments.Add(newComment);

                        Console.WriteLine("The comment you created is:");
                                       
                        break;

                    case "3":
                        Console.WriteLine("These is the list of users created:");

                        foreach(var insideuser in myUser)
                        {
                            Console.WriteLine("The name of the user1 is:" + insideuser.username1);
                            Console.WriteLine("The name of the user2 is:" + insideuser.username2);
                            Console.WriteLine("The name of the user3 is:" + insideuser.username3);
                        }
                        break;

                    case "4":
                        Console.WriteLine("These is the list of comments created:");

                        foreach (var insidecomment in myComments)
                        {
                            Console.WriteLine("Comment1 says: " + insidecomment.positive);
                            Console.WriteLine("Comment2 says: " + insidecomment.negative);
                            Console.WriteLine("Comment3 says: " + insidecomment.crucial);
                        }
                        break;
                      
                }
            }
        }
    }
}
                    
