using System;

public class Post
{
    public int PostId {get;set;}
    public DateTime Created { get; set; }
    public int? ThreadId { get; set; }
    public string Content { get; set; }
    public string Owner { get; set; }
}
