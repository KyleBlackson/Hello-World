using System;
using System.IO.Compression;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
    //     int x = 20;
    //     int y = 30;
    //     int z = 40;

    //     if (x == 10 && y ==30 || z ==40)
    //     {
    //         Console.WriteLine("X is 10");
    //         Console.WriteLine("Y is fun");
    //     }
    //     else if (x == 20)
    //     {
    //         Console.WriteLine("X is 20");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Default output");
    //     }

    // bool done = false;

    // do
    //     {
    //         Console.Write("Are we done (y/n)? ");
    //         done = Console.ReadLine().ToLower() == "y";
    //     }while (! done);

    for(int i = 100000; i >= -100000; i-=100000)
        {
            Console.WriteLine(i);
        }

    List <string> myFriends = new List<string> {"Bob", {"Betty"},"Bubba"};

    myFriends.Add("Doug");
    foreach(string friend in myFriends)
        {
            Console.WriteLine(friend);
        }
    }
}