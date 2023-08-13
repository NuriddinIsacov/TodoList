using System;

namespace MyTodoList.Services.UserInterfaces
{

    public class UserInterfaceService : IUserInterfaceService
    {
        public void MainInterfases() 
        {
            Console.Write(@"
-----------Todo List-----------
1.
    SIGN UP.
2.
    SIGN IN.
3.
    EXIT.

 Enter number: ");


        }


        public void SignUpInterfases()
        {
            Console.WriteLine(@"
---------- SIGN UP ----------

");

        }

        public void SignInInterfases()
        {
            Console.WriteLine(@"
---------- SIGN IN ----------

");
        }
    
    
    
    }


}
