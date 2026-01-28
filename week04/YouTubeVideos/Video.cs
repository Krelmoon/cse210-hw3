public class Video
{
    // attributes
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private int _commentCount = 0;
    private List<Comment> _comments = new List<Comment>();



    // constructor
    public Video(string title, string author, int lengthInSeconds,int commentCount)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _commentCount = commentCount;
    }

    // methods
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
        _commentCount++;
    }
    
    public string GetVideoInfo()
    {
        string info = $"Title: {_title}\nAuthor: {_author}\nLength: {_lengthInSeconds} seconds\nNumber of Comments: ‹‹›{_commentCount}\nComments:\n";
        foreach (Comment comment in _comments)
        {
            info += $"- {comment.GetCommentText()} (by {comment.GetCommenterName()})\n";
        }
        return info.Trim();
    }
}

    