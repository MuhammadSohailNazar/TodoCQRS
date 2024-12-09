using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TodoCQRS.Commands;
using TodoCQRS.Handlers.Commands;
using TodoCQRS.Handlers.Queries;
using TodoCQRS.Models;

namespace TodoCQRS.Controllers
{
    public class TodoController : Controller
    {
        private readonly ILogger<TodoController> _logger;
        private readonly AddTodoCommandHandler _addTodoCommandHandler;
        private readonly GetTodosQueryHandler _getTodosQueryHandler;
        public TodoController(ILogger<TodoController> logger, AddTodoCommandHandler addTodoCommandHandler, GetTodosQueryHandler getTodosQueryHandler)
        {
            _logger = logger;
            _addTodoCommandHandler = addTodoCommandHandler;
            _getTodosQueryHandler = getTodosQueryHandler;
        }
        [HttpPost]
        public async Task<ActionResult> todos([FromBody]AddTodoCommand command)
        {
            await _addTodoCommandHandler.Handle(command);
            return Ok("Todo Item added successfully");
        }
        [HttpGet]
        public async Task<ActionResult> todos(bool? isCompleted)
        {
            var query = new GetTodosQuery { IsCompleted = isCompleted};
            var todos = await _getTodosQueryHandler.Handle(query);
            return Ok(todos);
        }

    }
}
