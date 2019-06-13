using System;

namespace ConsoleAppGitHubTest001
{
    class Hello
    {
        string name;

        public Hello(string name)
        {
            this.name = name;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
