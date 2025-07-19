class Comment
{
    public string _commentor;
    public string _comment;

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"Name: {_commentor}");
        Console.WriteLine($"Comment: {_comment}.");
    }
}