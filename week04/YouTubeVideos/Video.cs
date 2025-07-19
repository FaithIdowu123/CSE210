class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _comments = new List<Comment>();

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine("");
        Console.WriteLine($"Comment Section ({_comments.Count()})");
        Console.WriteLine("");
        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentDetails();
            Console.WriteLine("");
        }
    }
}