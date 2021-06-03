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
            try
            {
                List<User> myList = new List<User>();

                User UserLeonardo = new User();
                UserLeonardo.UserID = "1";
                UserLeonardo.Usermail = "LC12@mail.com";
                UserLeonardo.Userpassword = "1234567890";

                myList.Add(UserLeonardo);


                User UserMcKain = new User();
                UserMcKain.UserID = "02";
                UserMcKain.Usermail = "MK34@mail.com";
                UserMcKain.Userpassword = "45678434";

                myList.Add(UserMcKain);

                User UserLuca = new User();
                UserLuca.UserID = "03";
                UserLuca.Usermail = "LA67@mail.com";
                UserLuca.Userpassword = "189302";

                myList.Add(UserLuca);

                User UserAnna = new User();
                UserAnna.UserID = "04";
                UserAnna.Usermail = "AA34@mail.com";
                UserAnna.Userpassword = "19013";

                myList.Add(UserAnna);

                User UserJhon = new User();
                UserJhon.UserID = "05";
                UserJhon.Usermail = "JN90@mail.com";
                UserJhon.Userpassword = "045823";

                myList.Add(UserJhon);

                User UserAlex = new User();
                UserAlex.UserID = "06";
                UserAlex.Usermail = "AX54@mail.com";
                UserAlex.Userpassword = "78941234";

                myList.Add(UserAlex);

                User UserAthena = new User();
                UserAthena.UserID = "07";
                UserAthena.Usermail = "AE@mail.com";
                UserAthena.Userpassword = "09814534";

                myList.Add(UserAthena);

                User UserThomas = new User();
                UserThomas.UserID = "08";
                UserThomas.Usermail = "TH33@mail.com";
                UserThomas.Userpassword = "444023";

                myList.Add(UserThomas);

                User UserDiana = new User();
                UserDiana.UserID = "09";
                UserDiana.Usermail = "DN@mail.com";
                UserDiana.Userpassword = "80459234";

                myList.Add(UserDiana);

                User UserEva = new User();
                UserEva.UserID = "10";
                UserEva.Usermail = "EV@mail.com";
                UserEva.Userpassword = "895019451";

                myList.Add(UserEva);

                List<User> result = myList.Where(user => user.UserID == "01").ToList();

                if(result.Count == 0)
                {
                    throw new Exception("Nothing was found");
                }
                else
                {
                    foreach (var user in result)
                    {
                        Console.WriteLine(user.UserID);
                        Console.WriteLine(user.Usermail);
                        Console.WriteLine(user.Userpassword);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
                    
