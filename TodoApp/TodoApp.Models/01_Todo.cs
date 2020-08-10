namespace TodoApp.Models
{
    /// <summary>
    /// 모델 클래스
    /// </summary>
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
