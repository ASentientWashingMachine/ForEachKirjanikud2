using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "Anton Tammsaare", "Lydia Koidula", "August Gailit", "Betti Alver" };
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Vajuta 'Enter' et lahkuda..");
        }
    }
}
