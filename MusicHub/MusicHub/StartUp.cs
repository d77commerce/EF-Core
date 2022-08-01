using MusicHub.Data;
using System;

namespace MusicHub
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            MusicHubDbContext context =
               new MusicHubDbContext();
            initializer.ResetDatabase(context);

            Console.WriteLine("one");
        }
    }
}
