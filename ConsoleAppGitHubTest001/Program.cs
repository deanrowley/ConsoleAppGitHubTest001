using System;

namespace ConsoleAppGitHubTest001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just a hello world
            // Added in GitHub via webbrowser
            // 2024-02-20 Changed to test Visual Studio
            Console.WriteLine("Hello, World!");

            Hello h = new Hello("Bob");

            h.SayHello();

            Console.Write("Press a key to end");
            Console.ReadKey();
        }
    }
}
