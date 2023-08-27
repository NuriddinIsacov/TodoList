using MyTodoList.Models.Notes;
using System.Collections.Generic;

namespace MyTodoList.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Note> Notes { get; set; } = new List<Note>();

    }
}
