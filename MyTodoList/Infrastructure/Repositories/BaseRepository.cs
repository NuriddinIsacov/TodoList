using System.Collections.Generic;
using MyTodoList.Models.Users;

namespace MyTodoList.Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        public List<User> Users { get; set; } = new List<User>();
    }
}
