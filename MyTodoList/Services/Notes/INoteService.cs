using MyTodoList.Models.Users;

namespace MyTodoList.Services.Notes
{
    public interface INoteService
    {
        void AddNote(User userServise);
        bool CheckNote(User userNote);
        void AllTasks(User usersNote);




    }
}
