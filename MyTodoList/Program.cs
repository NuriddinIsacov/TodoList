using System;
using MyTodoList.Services.Users;

namespace MyTodoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = new UserService();
        }
    }
}
