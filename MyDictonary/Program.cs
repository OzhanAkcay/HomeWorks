using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<String> dictonary = new MyDictionary<string>();
            dictonary.Add("Kelime");

            MyDictionary<string> dictionary = new MyDictionary<string>();
            
            Console.WriteLine(dictionary);

        }
    }
}
