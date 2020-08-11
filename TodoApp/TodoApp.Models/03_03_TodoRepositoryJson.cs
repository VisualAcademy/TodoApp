using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json; 

namespace TodoApp.Models
{
    public class TodoRepositoryJson : ITodoRepository
    {
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();

        public TodoRepositoryJson(string filePath = @"C:\temp\Todos.json")
        {
            this._filePath = filePath; 
            var todos = File.ReadAllText(filePath, Encoding.Default);
            _todos = JsonConvert.DeserializeObject<List<Todo>>(todos); 
        }

        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);

            // JSON 파일 저장
            string json = JsonConvert.SerializeObject(_todos, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
}
