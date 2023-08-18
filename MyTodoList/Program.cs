﻿using MyTodoList.Services.UserInterfaces;
using MyTodoList.Services.Users;
using System;

namespace MyTodoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = new UserService();
            UserInterfaceService userInterface = new UserInterfaceService();

            do
            {
                switch (userInterface.EnterMain())
                {

                    case 1:
                        {
                            userInterface.SignUp(userService);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine(userService.CountUsers());
                            break;
                        }

                    case 3:
                        {
                            return;
                        }



                }






            } while (true);


        }
    }
}
