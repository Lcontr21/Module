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
            newDTOUser.username = "RadicalGal";
            newDTOUser.password = "213054532";
            newDTOUser.email = "R4DG4L@yahoo.com";



            Console.WriteLine(newDTOUser.username);
            Console.WriteLine(newDTOUser.password);
            Console.WriteLine(newDTOUser.email);






        }
    }

    
    
}