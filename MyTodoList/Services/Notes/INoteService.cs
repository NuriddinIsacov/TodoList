using MyTodoList.Models.Users;

namespace MyTodoList.Services.Notes
{
    public interface INoteService
    {
        void AddNote(User userServise);
        void CheckNote(User userNote);
        void AllTasks(User usersNote);
        void PendingTasks(User userNote);
        void CompletedTasks(User userNote);



    }
}
