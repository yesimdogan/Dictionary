using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> monthNo = new MyDictionary<int, string>();
            monthNo.Add(1, "January");
            monthNo.Add(2, "February");
            monthNo.Add(3, "March");
            monthNo.Add(4, "April");
            monthNo.Add(5, "May");
            monthNo.Add(6, "June");
            monthNo.Add(7, "July");
            monthNo.Add(8, "August");
            monthNo.Add(9, "September");
            monthNo.Add(10, "October");
            monthNo.Add(11, "November");
            monthNo.Add(12, "December");

            monthNo.List();

            Console.ReadKey();
        }
    }
}
