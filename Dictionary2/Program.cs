using System;

namespace Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary2<int, string> myDictionary2 = new MyDictionary2<int, string>();
            myDictionary2.Add(1, "Yeşim");
            myDictionary2.Add(2, "Berkin");
            myDictionary2.Add(3, "Vera");
            myDictionary2.Add(4, "Yeliz");

            myDictionary2.List();
            myDictionary2.Count();

            Console.ReadKey();
           
        }
    }
}
