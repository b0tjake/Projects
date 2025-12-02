using System;
using System.Collections.Generic;

public class Post
{
    public User author;
    public string content;
    public List<Comments> comments;
    public List<User> likes;

    public Post(User author, string content)
    {
        this.author = author;
        this.content = content;
        this.comments = new List<Comments>();
        this.likes = new List<User>();
        author.posts.Add(this);
    }
       public static void add_comment(Post post, Comments comment )
    {
        post.comments.Add(comment);
    }
    public static void add_like(Post post, User user)
    {
        post.likes.Add(user);
    }
}