using Microsoft.EntityFrameworkCore;
using TodoCQRS.Commands;
using TodoCQRS.Data;
using TodoCQRS.Models;

namespace TodoCQRS.Handlers.Queries
{
    public class GetTodosQueryHandler
    {
        private readonly ApplicationDbContext _dbContext;
        public GetTodosQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TodoItem>> Handle(GetTodosQuery query)
        {
            var items = _dbContext.TodoItems.AsQueryable();

            if (query.IsCompleted.HasValue)
            {
                items = items.Where(t => t.IsCompleted == query.IsCompleted.Value);
            }

            return await items.ToListAsync();
        }
    }
}
