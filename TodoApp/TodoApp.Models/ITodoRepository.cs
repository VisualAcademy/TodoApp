using System.Collections.Generic;

namespace TodoApp.Models
{
    public interface ITodoRepository
    {
        void Add(Todo model); // 입력
        List<Todo> GetAll(); // 출력
    }
}
