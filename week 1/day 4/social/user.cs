using System;
using System.Collections.Generic;
// 

public class User{
    public string name;
    public int age;

    public List<string> friends;
    public List<Post> posts;

    public User(string name, int age)
    {
        this.name=name;
        this.age=age;
        this.friends=new List<string>();
        this.posts=new List<Post>();
    }
   public static void addFriend(User user, string friendName)
    {
        if (user.friends.Contains(friendName))
        {
            Console.WriteLine($"{friendName} is already a friend.");
        }
        else if(friendName==user.name)
        {
            Console.WriteLine("You cannot add yourself as a friend.");
        }
        else
        {
            user.friends.Add(friendName);
        }
    }
    static void removeFriend(User user, string friendName)
    {
        user.friends.Remove(friendName);
    }
    public static void showPosts(User user)
    {
    foreach(Post post in user.posts)
    {
        Console.WriteLine($"Post by {post.author.name}: {post.content}");

        if (post.comments.Count > 0)
        {
            Console.WriteLine("  Comments:");
            foreach (Comments comment in post.comments)
            {
                Console.WriteLine($"    {comment.author.name}: {comment.content}");
            }
        }

        if (post.likes.Count > 0)
        {
            Console.WriteLine($"  Likes: {post.likes.Count}");
        }

    }

    }

}