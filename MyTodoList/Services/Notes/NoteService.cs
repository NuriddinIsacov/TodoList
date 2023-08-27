using MyTodoList.Models.Notes;
using MyTodoList.Models.Users;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MyTodoList.Services.Notes
{

    public class NoteService : INoteService
    {

        private string textNote = string.Empty;
        private int choiceSaveOrNo = default;
        bool askUser = default;

        public void AddNote(User user)
        {
            Note note = new Note();
            Console.Clear();
            do
            {
                Console.WriteLine("Please enter text.");
                textNote = Console.ReadLine();
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Do you want save text ?\n1.Yes\n2.No");

                do
                {
                    Console.Clear();
                    Console.WriteLine("Do you want save text ?\n1.Yes\n2.No");
                    askUser = int.TryParse(Console.ReadLine(), out choiceSaveOrNo);

                } while (!askUser || choiceSaveOrNo > 2 || choiceSaveOrNo < 1);




                if (choiceSaveOrNo == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sucsess!");
                    note.Title = textNote;
                    user.Notes.Add(note);
                    Console.ResetColor();
                }
                else if (choiceSaveOrNo == 2)
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    textNote = string.Empty;
                }
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Do you want add new todo list\n1.Yes\n2.No");
                do
                {
                    Console.Clear();
                    Console.WriteLine("Do you want add new todo list\n1.Yes\n2.No");
                    askUser = int.TryParse(Console.ReadLine(), out choiceSaveOrNo);

                } while (!askUser || choiceSaveOrNo > 2 || choiceSaveOrNo < 1);

                askUser = (choiceSaveOrNo == 1) ? true : false;
            } while (askUser);





        }

        public bool CheckNote(User userNote)
        {
            if (userNote.Notes != null)
            {
                return true;
            }
            else
            {
                Console.WriteLine("There isn't to-do list");
                return false;
            }

        }



        public void AllTasks(User usersNote)
        {

            if (CheckNote(usersNote))
            {
                List<Note> notes = usersNote.Notes;

                for (int index = 0; index < notes.Count; index++)
                {
                    Console.WriteLine("__________________________________");
                    Console.WriteLine($"{index + 1}. {notes[index].Title}");
                    Console.WriteLine("__________________________________");
                }


            }
            else
            {
                Console.WriteLine("User not found!");
            }
        }


    }
}
