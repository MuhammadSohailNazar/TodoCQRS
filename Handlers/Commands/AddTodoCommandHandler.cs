using TodoCQRS.Commands;
using TodoCQRS.Data;
using TodoCQRS.Models;

namespace TodoCQRS.Handlers.Commands
{
    public class AddTodoCommandHandler
    {
        private readonly ApplicationDbContext _dbContext;
        public AddTodoCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Handle(AddTodoCommand command)
        {
            var todoItem = new TodoItem
            {
                Title = command.Title,
                IsCompleted = false
            };

            _dbContext.TodoItems.Add(todoItem);
            await _dbContext.SaveChangesAsync();
        }
    }
}
