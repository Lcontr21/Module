using System;
using Module.Models;
using Module.DTOS;

namespace Module
{
    class Program
    {
       
        static void Main(string[] args)
        {
            User myUser = new User();
            myUser.username = "Totally_Cool_Dude";
            myUser.password = "1234567890";
            


            UserDTO newDTOUser = new UserDTO();
            newDTOUser.username = "Totally_Cool_Dude";
            newDTOUser.password = "1234567890";
            

            Console.WriteLine(newDTOUser.username);
            Console.WriteLine(newDTOUser.password);
            


        }

         
    }
}
