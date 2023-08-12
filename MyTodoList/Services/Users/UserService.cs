using System;
using System.Linq;
using MyTodoList.Infrastructure.Repositories;
using MyTodoList.Models.Users;

namespace MyTodoList.Services.Users
{
    public class UserService : BaseRepository, IUserService
    {
        public void CreateUser(User user)
        {
            try
            {
                this.Users.Add(user);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Vujudaga kelgan xatolik:  {exception.Message}");
            }
        }

        public User GetUser(string username)
        {
            try
            {
                return this.Users.FirstOrDefault(user => user.UserName == username);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Vujudaga kelgan xatolik:  {exception.Message}");

                return null;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                User storageUser = this.Users.FirstOrDefault(item => item.UserName == user.UserName);
                this.Users.Remove(storageUser);
                this.Users.Add(user);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Vujudaga kelgan xatolik:  {exception.Message}");
            }
        }
    }
}
