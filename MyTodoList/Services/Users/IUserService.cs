using MyTodoList.Models.Users;

namespace MyTodoList.Services.Users
{
    public interface IUserService
    {
        void CreateUser(User user);
        User GetUser(string username, string password);
        void UpdateUser(User user);

        int CountUsers();
    }
}
