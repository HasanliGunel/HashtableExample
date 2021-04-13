using System;
using System.Collections;

namespace Hashtable_update
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

            string Lanof2 = (string)languages[2];
            string Lanof3 = (string)languages[3];

            Console.WriteLine(Lanof2);
            Console.WriteLine(Lanof3);

            languages[2] = "Python";
            languages[3] = "Java";

            if (!languages.ContainsKey(4))
                languages[4] = "Delphi";
            Console.WriteLine("---Yenilenmeden sonra----");

            foreach (DictionaryEntry lan in languages)
                Console.WriteLine("Key:{0}, Value:{1}", lan.Key, lan.Value);
        }
    }
}
