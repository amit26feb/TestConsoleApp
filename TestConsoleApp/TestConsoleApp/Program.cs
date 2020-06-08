using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Windows.Media;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal.TryParse("56.09", out decimal d);
            Rootobject a = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(@"C:\Amit\Docs\Reng_B.json"));

            List<Behaviorterm[]> i = a.data.behaviorQualifier.Select(x=>x.behaviorTerms).ToList();

            //string qty = Decimal.Truncate(d).ToString();
            //Console.WriteLine(qty);
            //string name = null;
            //switch (name)
            //{
            //    default:
            //        name = "default";
            //        break;
            //}
            //Console.WriteLine(name);
            //List<TestList> list = new List<TestList>
            //{
            //    new TestList { col1 = "B", col2 = "" },
            //    new TestList { col1 = "C", col2 = "B" },
            //    new TestList { col1 = "D", col2 = "C" },
            //    new TestList { col1 = "E", col2 = "D" },
            //    new TestList { col1 = "F", col2 = "E" }
            //};

            //var a = list.FirstOrDefault(x => !x.col2.Contains(x.col1));
            //var color = (Color)ColorConverter.ConvertFromString("Red");

            //TestList t = new TestList();
            //try
            //{

            //    t.col1 = "'huh";
            //    t.col1.AssignError("mera err");
            //    Console.WriteLine(t.col1);
            //    Console.WriteLine(t.col2);
            //    throw new ArgumentNullException();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("exception");
            //    Console.WriteLine(t.col1);
            //}

            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
    class TestList
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
    }
    public static class Extensions
    {
        public static void AssignError(this String field, string errorMessage)
        {
            if (!string.IsNullOrEmpty(field))
            {
                field = string.Concat(field, "\n", errorMessage);

            }
            else
            {
                field = errorMessage;

            }
        }
    }
}
