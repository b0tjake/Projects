using System;
using System.Collections.Generic;

public class Comments
{
    public User author;
    public string content;
    public List<User> likes;

    public Comments( User author, string content, Post post)
    {
        this.author = author;
        this.content = content;
        this.likes = new List<User>();
        post.comments.Add(this);
    }
    public static void add_like(Comments self, User user)
    {
        self.likes.Add(user);
    }
}