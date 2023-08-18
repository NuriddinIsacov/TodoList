using MyTodoList.Services.Users;
using System;
using System.Threading;

namespace MyTodoList.Services.UserInterfaces
{
    public class UserInterfaceService : IUserInterfaceService
    {
        private bool sucsess;
        private byte mainFlag;

        public int EnterMain()
        {
            Console.Write(@"---------------Main---------------

    1.
        SignUp.
    2.
        SignIn.
    3.
        Exit.

");
            Thread.Sleep(500);
            Console.Clear();
            do
            {
                Console.Write(@$"---------------Main---------------

    1.
        SignUp.
    2.
        SignIn.
    3.
        Exit.

");

                Console.Write("  Enter number: ");
                sucsess = byte.TryParse(Console.ReadLine(), out mainFlag);

                if (!sucsess || mainFlag > 3 || mainFlag < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pleas enter correct number!!");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    Console.Clear();

                }
                else
                {
                    if (mainFlag != 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct number!!");
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\tThank you by!\n\t\t\tSee you later.\n\n\n");
                    }

                    Thread.Sleep(500);
                    Console.ResetColor();

                }



            } while (!sucsess || mainFlag > 3 || mainFlag < 1);

            return mainFlag;
        }




        public void SignIn(IUserService user)
        {
            throw new System.NotImplementedException();
        }

        public void SignUp(IUserService user)
        {
            throw new System.NotImplementedException();
        }
    }

}
