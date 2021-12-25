using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "Apex Legends", "Ghost Runner", "Streets of Rogue", "Minecraft", "Lego Worlds", "SplitGate" };
            var sorted = games.OrderBy(x => x.Count());
            sorted.ToList().ForEach(x => Console.WriteLine(x));
            

        }
    }
}
