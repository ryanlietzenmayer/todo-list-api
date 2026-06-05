public class ToDoItem
{
    public int id { get; set; }
    public string taskDescription { get; set; }      
    public DateTime createdDate { get; set; }
    public DateTime dueDate { get; set; }
    public bool completed { get; set; }  
}