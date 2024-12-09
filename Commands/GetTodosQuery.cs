namespace TodoCQRS.Commands
{
    public class GetTodosQuery
    {
        public bool? IsCompleted { get; set; } // optional filter
    }
}
