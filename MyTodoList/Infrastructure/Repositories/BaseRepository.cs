using MyTodoList.Models.Users;
using System.Collections.Generic;

namespace MyTodoList.Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        public List<User> Users { get; set; } = new List<User>();

    }
}
