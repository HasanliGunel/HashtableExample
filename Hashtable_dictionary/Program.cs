using System;
using System.Collections;
using System.Collections.Generic;

namespace Hashtable_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "C#");
            dict.Add(2, "C++");
            dict.Add(3, "C");
            dict.Add(4, "python");
            Hashtable Ht = new Hashtable(dict);
            Console.WriteLine("Total element:{0}", Ht.Count);
        }
    }
}
