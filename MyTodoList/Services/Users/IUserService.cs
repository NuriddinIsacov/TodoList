using MyTodoList.Models.Users;

namespace MyTodoList.Services.Users
{
    public interface IUserService
    {
        void CreateUser(User user);
        User GetUser(string username);
        void UpdateUser(User user);
    }
}
