using Microsoft.EntityFrameworkCore;

namespace ToDo.Items.App.Data
{
    public class ToDoContext: DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options): base(options)
        {
            
        }
        public DbSet<Models.ToDoItem> ToDoItems { get; set; } = null!;
    }
}