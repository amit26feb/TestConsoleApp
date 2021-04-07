using System;
using System.Collections.Generic;
using System.Linq;
//using System.Windows.Media;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // GridColWidth();
            //dtoGen();
            List<TestList> t1 = new List<TestList>();
            t1.Add(new TestList { col1 = null, col2 = null });

            IEnumerable<string> a = t1.Select(x => { if (!string.IsNullOrEmpty(x.col1))});

            Console.WriteLine(a.FirstOrDefault());
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
}
