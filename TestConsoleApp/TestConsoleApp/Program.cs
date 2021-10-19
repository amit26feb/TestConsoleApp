using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using System.Windows.Media;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dept[] depts = new Dept[] { new Dept() { Name = "acct" } };
            var schools = new[] {
            new School(){ Students = new [] { new Student(){ Name="Bob", Dept = depts }, new Student(){ Name="Jack", Dept= depts } }},
            new School(){ Students = new [] { new Student(){ Name="Jim", Dept= depts }, new Student(){ Name="John", Dept= depts } }}
        };

            var allStudents = new List<School>(); //schools.SelectMany(s => s.Students);
            Console.WriteLine("first or default");
            var x = allStudents.FirstOrDefault();
            Console.WriteLine(allStudents.FirstOrDefault());
            foreach (var student in allStudents)
            {
                //Console.WriteLine(student.Name);
            }

            MemoryCacher mem = new MemoryCacher();
            Console.WriteLine( mem.Add("1", "1234"));
            Console.WriteLine(mem.Add("2", "1fdssd234"));
            Console.WriteLine(mem.Add("3", "123jjkjk4"));
            Console.WriteLine(mem.Add("4", "hghkjkj1234"));

            var b = mem.GetAllCachedItems();
            while (b.MoveNext())
            {
                Console.WriteLine(b.Current.Key + " "+b.Current.Value);
            }
            

            // GridColWidth();
            //dtoGen();
            //List<TestList> t1 = new List<TestList>();
            //t1.Add(new TestList { col1 = null, col2 = null });

            //IEnumerable<string> a = t1.Select(x => { if (!string.IsNullOrEmpty(x.col1))});

            //Console.WriteLine(a.FirstOrDefault());
            Hashtable my_hashtable = new Hashtable();

            // Adding key/value pair in the hashtable
            // Using Add() method
            //my_hashtable.Add("A1", "Welcome");
            //my_hashtable.Add("A2", "to");
            //my_hashtable.Add("A3", 3);

            //foreach (DictionaryEntry element in my_hashtable)
            //{
            //    Console.WriteLine("Key:- {0} and Value:- {1} ",
            //                       element.Key, element.Value);
            //}
            //decimal value = -144.64m;
            //Console.WriteLine("Your account balance is {0:C2}.", value);

            //DateTime chotaDt = DateTime.Now;
            //DateTime badaDt = DateTime.Now.AddHours(1);

            //Console.WriteLine(chotaDt.TimeOfDay.CompareTo(badaDt.TimeOfDay));
            //Console.WriteLine(badaDt.Subtract(chotaDt));

            //Console.WriteLine(string.Format("{0:pn}","20"));
            //string a = File.ReadAllText(@"./BETA.Translations.json");

            //var b = JsonConvert.DeserializeObject<Class1[]>(a);

            //var c = b;
            //Decimal.TryParse("56.09", out decimal d);
            //Rootobject a = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(@"C:\Amit\Docs\Reng_B.json"));

            //List<Behaviorterm[]> i = a.data.behaviorQualifier.Select(x=>x.behaviorTerms).ToList();

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

            //  Console.WriteLine(a);

            Console.ReadLine();
        }

        private static void dtoGen()
        {
            List<string> l = new List<string>() { "qty_ind",
"offset_type",
"offset_account",
"broker_no",
"apr_actionuser",
"Apr_firstname",
"apr_Lastname",
"user_timestamp",

};
            foreach (string item in l)
            {
                Console.WriteLine("[HostField(\"" + item.ToUpper() + "\")]");
                Console.WriteLine("[JsonProperty(PropertyName = \"" + item.ToLower() + "\")]");
                Console.WriteLine("public string " + item.ToUpper() + " { get; set; }");


                Console.WriteLine();
            }
        }

        private static void GridColWidth()
        {
            List<string> l = new List<string>() { "groupType",
"addTimestamp",
"adduserid",
"firstName",
"lastName",
"queue",
"addDepartment",
"groupAid",
"accountNumber",
"accountType",
"loc",
"qtyInd",
"quantity",
"secno",
"offsetAccountNumber",
"offsetAccountType",
"sourceCode",
"brokerNumber",
"status",
"aprAction",
"aprActionTime",
"aprActionUser",
"aprFirstName",
"aprLastName",
"aprActionNote",
"finalPend",
"userTimestamp"
};
            List<string> r = new List<string>();

            foreach (string str in l)
            {
                r.Add(Char.ToUpperInvariant(str[0]) + str.Substring(1).Trim());
            }
            foreach (string str in r)
            {
                Console.WriteLine("\"" + str + "\"");
            }
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

    class School
    {
        public Student[] Students { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public Dept[] Dept { get; set; }
    }

    class Dept
    {
        public string Name { get; set; }
    }
}
