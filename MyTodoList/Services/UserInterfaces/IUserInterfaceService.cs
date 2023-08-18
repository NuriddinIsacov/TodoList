using MyTodoList.Services.Users;

namespace MyTodoList.Services.UserInterfaces
{
    public interface IUserInterfaceService
    {
        int EnterMain();

        void SignIn(IUserService userServise);

        void SignUp(IUserService user);


    }

}
