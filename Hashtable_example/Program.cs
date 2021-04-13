using System;
using System.Collections;


namespace Hashtable_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, 15);
            HT.Add(2, 25);
            HT.Add(3, 35);
            
            foreach (DictionaryEntry ht in HT)
                Console.WriteLine("Key:{0}, Value: {1}", ht.Key, ht.Value);

            Console.WriteLine('\n');

            var languages = new Hashtable()
            {
                {1, "C#" },
                {2, "C++" },
                {3, "C" }
            };

            foreach (DictionaryEntry lan in languages)
                Console.WriteLine("Key:{0}, Value:{1}", lan.Key, lan.Value);
        }
    }
}
