using System;
using System.Collections;

namespace Hashtable_remove
{
    class Program
    {
        static void Main(string[] args)
        {
            var languages = new Hashtable()
            {
                {1, "C#" },
                {2, "C++" },
                {3, "C" }
            };

            Console.WriteLine("Umumi element:{0}", languages.Count);
            Console.WriteLine('\n');

            languages.Remove(3);

            Console.WriteLine("Umumi element:{0}", languages.Count);
            Console.WriteLine('\n');

            if (languages.ContainsKey(4))
                languages.Remove(4);

            languages.Clear();

            Console.WriteLine("Clear-den sonra umumi element:{0}", languages.Count);
        }
    }
}
