using System.Text.Json; // Required for JSON

public class ToDoItem
{
    public int id { get; set; }
    public string taskDescription { get; set; }      
    public DateTime createdDate { get; set; }
    public DateTime dueDate { get; set; }
    public bool completed { get; set; }  
}


class Program
{
    // runs the app
    static void Main(string[] args)
    {
    }
}

// GET
// GET ALL
// POST
// PUT
// DELETE