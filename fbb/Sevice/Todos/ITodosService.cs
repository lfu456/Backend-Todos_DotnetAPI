using fbb.Models;

namespace fbb.Sevice.Todos
{
    public interface ITodosService
    {
        List<Todo> GetTodos();
        Boolean AddTodo(Todo todo);
        Boolean UpdateTodo(Todo todo);

        Boolean DelTodo(int id);

    }
}
