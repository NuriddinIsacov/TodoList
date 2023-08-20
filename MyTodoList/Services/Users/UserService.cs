using MyTodoList.Infrastructure.Repositories;
using MyTodoList.Models.Users;
using System;
using System.Linq;

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

        public User GetUser(string username, string password)
        {
            try
            {
                foreach (var user in this.Users)
                {
                    if (user.UserName == username && user.Password == password)
                    {
                        return user;
                    }
                }
                //this.Users.FirstOrDefault(user => user.UserName == username);
                return null;
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

        public int CountUsers()
        {
            return this.Users.Count;
        }

    }
}
