using System;
using System.Collections.Generic;

namespace TodoApi.Models;
    public class TodoItem
    {
        public long Id { get; set; }
        public required string TaskDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
    }