using System;
using Module.Models;

namespace Module
{
    class Program
    {
       
        static void Main(string[] args)
        {
            User myUser = new User();
            myUser.username = "Totally_Cool_Dude";
            myUser.password = "1234567890";
            myUser.email = "T0tallyC00l@yahoo.com";

            Console.WriteLine(myUser.username);
            Console.WriteLine(myUser.password);
            Console.WriteLine(myUser.email);
        }

         
    }
}
