using System;
using System.Collections.Generic;

namespace Todo.Models.ViewModels
{
    public class TodoViewModel
    {
        public List<ToDoItem> TodoList { get; set; }
        public ToDoItem Todo { get; set; }
    }
}

namespace Todo.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
    }
}