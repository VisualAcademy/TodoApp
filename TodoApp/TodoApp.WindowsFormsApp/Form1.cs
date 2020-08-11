using System;
using System.Windows.Forms;
using TodoApp.Models;

namespace TodoApp.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly ITodoRepository _repository;

        public Form1()
        {
            InitializeComponent();
            _repository = new TodoRepositoryJson("C:\\temp\\Todos.json");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            this.dataGridView1.DataSource = _repository.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            bool isDone = blnIsDone.Checked;

            var todo = new Todo { Title = title, IsDone = isDone };
            _repository.Add(todo);

            DisplayData();
        }
    }
}
