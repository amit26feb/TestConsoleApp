using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d;
            Decimal.TryParse("56.09", out d);

            string qty = Decimal.Truncate(d).ToString();
            Console.WriteLine(qty);
            //List<TestList> list = new List<TestList>
            //{
            //    new TestList { col1 = "B", col2 = "" },
            //    new TestList { col1 = "C", col2 = "B" },
            //    new TestList { col1 = "D", col2 = "C" },
            //    new TestList { col1 = "E", col2 = "D" },
            //    new TestList { col1 = "F", col2 = "E" }
            //};

            //var a = list.FirstOrDefault(x => !x.col2.Contains(x.col1));
            var color = (Color)ColorConverter.ConvertFromString("Red");
            Console.ReadLine();
        }
    }
    class TestList
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
    }
}
