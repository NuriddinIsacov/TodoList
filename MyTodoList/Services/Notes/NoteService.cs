using MyTodoList.Models.Users;
using MyTodoList.Models.Notes;
using System;

namespace MyTodoList.Services.Notes
{
    
    public class NoteService: INoteService
    {
        
        private string textNote = string.Empty;
        private int choiceSaveOrNo = default;
        bool askUser = default;
        
        public void AddNote(User userServise)
        {
            Note note = new Note();
            List<Note> userServiseNote = userServise.Notes;
            do
            {
                Console.WriteLine("Please enter text.");
                textNote = Console.ReadLine();
                
                Console.WriteLine("Do you want save text ?\n1.Yes\n2.No");
                choiceSaveOrNo = int.Parse(Console.ReadLine());
                if (choiceSaveOrNo == 1)
                {
                    note.Title = textNote;
                    userServise.Notes.Add(note);
                }
                else if (choiceSaveOrNo == 2)
                {
                    textNote = string.Empty;
                }
                Console.WriteLine("Do you want add new todo list\n1.Yes\n2.No");
                choiceSaveOrNo = int.Parse(Console.ReadLine()); 
                askUser = (choiceSaveOrNo == 1) ? true : false;

            } while (askUser);
            



        }

        public void CheckNote(User userNote) 
        {
            if (userNote.Notes == null)
                Console.WriteLine("There isn't to-do list");

            Console.WriteLine($"There is to-do list {userNote.Notes.Count}");
        }



        public void AllTasks(User usersNote)
        {
            CheckNote(usersNote);
        }
        
        public void PendingTasks(User userNote)
        {
            Console.WriteLine("All Nots");

        }
        
        
        public void CompletedTasks(User userNote)
        {
            Console.WriteLine("All Nots");

        }
    }
}
