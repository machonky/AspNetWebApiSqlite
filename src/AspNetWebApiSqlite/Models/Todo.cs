namespace AspNetWebApiSqlite.Models;

public class Todo
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }
}
