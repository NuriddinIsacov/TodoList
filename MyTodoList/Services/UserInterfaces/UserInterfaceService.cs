using MyTodoList.Models.Users;
using MyTodoList.Services.Notes;
using MyTodoList.Services.Users;
using System;
using System.Threading;

namespace MyTodoList.Services.UserInterfaces
{
    public class UserInterfaceService : IUserInterfaceService
    {
        private bool sucsess;
        private byte mainFlag;
        private int zerohNumber = 0;
        private int firstNumber = 1;
        private int secondNumber = 2;
        private int thirdNumber = 3;
        private NoteService noteService = new NoteService();



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

                if (!sucsess || mainFlag > thirdNumber || mainFlag < firstNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pleas enter correct number!!");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    Console.Clear();

                }
                else
                {
                    if (mainFlag != thirdNumber)
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



            } while (!sucsess || mainFlag > thirdNumber || mainFlag < firstNumber);

            return mainFlag;
        }



        public void SignUp(IUserService userServise)
        {
            User user = new User();
            int signUpFlag = zerohNumber;
            bool signUpCheck = default;
            string firstName = string.Empty;
            string lastName = string.Empty;
            string nickName = string.Empty;
            string password = string.Empty;


            Console.WriteLine("----------{ SIGN UP }----------");
            Console.Write("First name: "); firstName = Console.ReadLine();
            Console.Write("Last name: "); lastName = Console.ReadLine();
            Console.Write("Nick name: "); nickName = Console.ReadLine();
            Console.Write("Password: "); password = Console.ReadLine();


            Console.Write(@"
1.
    Save.
2.
    Exit.
");
            Console.Clear();
            do
            {
                Console.Write(@"
1.
    Save.
2.
    Exit.
");
                Console.Write(" Enter number: ");
                signUpCheck = int.TryParse(Console.ReadLine(), out signUpFlag);


                if (!signUpCheck || signUpFlag > secondNumber || zerohNumber >= signUpFlag)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pleas enter correct number!!");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    Console.Clear();

                }
                else
                {
                    if (signUpFlag != secondNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct number!!");
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                    Thread.Sleep(1000);
                    Console.ResetColor();
                }

            } while (!signUpCheck || signUpFlag > secondNumber || signUpFlag < firstNumber);

            if (signUpFlag == firstNumber)
            {
                user.FirstName = firstName;
                user.LastName = lastName;
                user.UserName = nickName;
                user.Password = password;

                userServise.CreateUser(user);

            }
            else if (signUpFlag == secondNumber)
            {
                return;
            }




        }



        public void SignIn(IUserService userServise)
        {

            int choice = default;
            string equalName = string.Empty;
            string equalPassword = string.Empty;


            do
            {
                Console.Write("Enter User name: ");
                equalName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(equalName));

            do
            {
                Console.Write("Enter Password: ");
                equalPassword = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(equalPassword));

            var user = userServise.GetUser(equalName, equalPassword);



            if (user != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("<{----USER FOUND----}>");
                Thread.Sleep(500);
                Console.ResetColor();
                Console.Clear();

                Console.WriteLine(@$"
<----{user.FirstName}---->

1.
    Add to-do list.
2.
    All the Task.
3.
    Pending Tasks.
4.
    Completed Tasks.
5.
    EXIT.
");
                Console.Write("Enter number: ");
                choice = int.Parse(Console.ReadLine());


                if (choice == firstNumber)
                {
                    noteService.AddNote(user);

                }
                else if (choice == firstNumber)
                {
                    noteService.AllTasks(user);
                }




                Thread.Sleep(5000);
            }




        }

    }

}
