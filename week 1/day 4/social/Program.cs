
using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {

        

        User alice = new User("Alice", 25);
        User bob = new User("Bob", 30);
        User carol = new User("Carol", 22);

        User.addFriend(alice, "bob");
        User.addFriend(bob, "carol");

        Post post1 = new Post(alice, "Hello world!");

        Comments comment1 = new Comments(bob, "Nice post!", post1);
        Post.add_comment(post1, comment1);

        Post.add_like(post1, bob);
        Comments.add_like(comment1, carol);
        User.showPosts(alice);

    }
}