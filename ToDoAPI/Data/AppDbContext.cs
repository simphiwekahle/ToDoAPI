using Microsoft.EntityFrameworkCore;
using ToDoAPI.Models;

namespace ToDoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<DbContext> options) :base(options)
        {
            
        }

        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}
