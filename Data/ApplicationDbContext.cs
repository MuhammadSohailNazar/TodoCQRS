using Microsoft.EntityFrameworkCore;
using TodoCQRS.Models;

namespace TodoCQRS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
