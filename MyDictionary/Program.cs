using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> mydict = new MyDictionary<int, string>();
            mydict.Add(455,"Salih Kamaş");
            mydict.Add(456,"Hasan M");
            mydict.Add(457,"İbrahim M");
            for (int i = 0; i < mydict.Length; i++)
            {
                Console.WriteLine("No: {0} Name: {1}",mydict.Keys[i],mydict.Values[i]);
            }
        }
    }
}
