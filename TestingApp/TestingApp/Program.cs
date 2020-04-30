using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestingApp;

//namespace TestingApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //Decimal.TryParse("76.6", out decimal qty);

//            List<string> l = CreateRequestSequenceEx("1");
//            foreach (string item in l)
//            {
//                Console.WriteLine(item);
//            }


//            Console.Read();
//        }
//        public static List<string> CreateRequestSequenceEx(string id)
//        {
//            List<string> input = Getstring();
//            List<string> output = new List<string>();
//            if (!string.IsNullOrEmpty(id))
//            {

//                int i = 0;
//                foreach (string item in input)
//                {
//                    string sequenceCountMulti = id;
//                    i += 1;
//                    sequenceCountMulti = string.Format("{0}.{1}", sequenceCountMulti, i);
//                    output.Add(sequenceCountMulti);
//                }
//            }
//            return output;
//        }

//        private static List<string> Getstring()
//        {
//            return new List<string>() { "dfd", "fdsf", "dfd", "fdsf", "dfd", "fdsf", "dfd", "fdsf", "dfd", "fdsf", "dfd", "fdsf" };
//        }
//    }
//}
namespace Monitor_Lock
{

    class Program
    {
        static readonly object _object = new object();

        static void TestLock()
        {

            lock (_object)
            {
                Thread.Sleep(1000);
                Console.WriteLine(Environment.TickCount);
            }
        }

        static void Main(string[] args)
        {
            // HostFieldCreation();
            // StartFactoryPattern();
            #region Sorting
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "A1", AdmissionDate = DateTime.Now.AddSeconds(10), Comments = "ADMITTED" });
            students.Add(new Student { Id = 2, Name = "A2", AdmissionDate = DateTime.Now.AddSeconds(20), Comments = "ADMITTED" });
            students.Add(new Student { Id = 3, Name = "A3", AdmissionDate = DateTime.Now.AddSeconds(30), Comments = "ADMITTED" });
            students.Add(new Student { Id = 4, Name = "A4", AdmissionDate = DateTime.Now.AddSeconds(40), Comments = "ADMITTED" });


            students.Sort(new SortClass());

            foreach (Student item in students)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Comments + " " + item.AdmissionDate);
            }
            #endregion
            // new Client().Main();
            //lst.AddRange(lst2);

            //double[] d1 = new double[] { 26392.23, 35192.23, -26392.23, -35192.23 };
            //double d2 = d1.Sum(x => x);

            //Console.WriteLine(d2);
            //Console.WriteLine(d2.ToString("F1"));
            //Console.WriteLine(d2.ToString("F"));
            //Console.WriteLine(d2.ToString("F2"));

            //Console.WriteLine("--------------------------------------------");

            //double d3 = 0.00;
            //d3 += (double)d1.Sum(x => (decimal)x);
            //bool a1 = bool.TryParse(null, out bool b1);
            //Console.WriteLine(a1);
            //Console.WriteLine(b1);
            //Console.WriteLine(d3);
            ////Console.WriteLine(d3.ToString("F1"));
            ////Console.WriteLine(d3.ToString("F"));
            ////Console.WriteLine(d3.ToString("F2"));

            //Console.WriteLine(string.IsNullOrEmpty(string.Empty + " " + string.Empty));
            Console.Read();
        }


        private static void HostFieldCreation()
        {

            #region Host file data extraction
            //for (int i = 0; i < 10; i++)
            //{
            //    ThreadStart start = new ThreadStart(TestLock);
            //    new Thread(start).Start();
            //}
            List<string> lst = new List<string>();
            lst.Add("_100");
            lst.Add("symbol");
            lst.Add("_101");
            lst.Add("cusip");
            lst.Add("_102");
            lst.Add("secno");
            lst.Add("_106");
            lst.Add("name");
            lst.Add("_107");
            lst.Add("rep");
            lst.Add("_117");
            lst.Add("firmSub");
            lst.Add("_555");
            lst.Add("confirmNote");
            lst.Add("_606");
            lst.Add("branch");
            lst.Add("_630");
            lst.Add("qtyAvail");
            lst.Add("_806");
            lst.Add("settleDate");
            lst.Add("_950");
            lst.Add("price");
            lst.Add("_968");
            lst.Add("commission");
            lst.Add("_1091");
            lst.Add("security");
            lst.Add("_2017");
            lst.Add("totalAvailableQuantity");
            lst.Add("_2121");
            lst.Add("inquiryMaintType");
            lst.Add("_2122");
            lst.Add("effectiveDateCYMD");
            lst.Add("_2279");
            lst.Add("yield");
            lst.Add("_2875");
            lst.Add("related");
            lst.Add("_3143");
            lst.Add("statusIndicator");
            lst.Add("_3625");
            lst.Add("pricingDate");
            lst.Add("_4194");
            lst.Add("totalAllotments");
            lst.Add("_4195");
            lst.Add("totalOrders");
            lst.Add("_4196");
            lst.Add("totalRequests");
            lst.Add("_4197");
            lst.Add("totalSubject");
            lst.Add("_4198");
            lst.Add("totalOrdersEntered");
            lst.Add("_4199");
            lst.Add("totalOrdersRequired");
            lst.Add("_4200");
            lst.Add("totalDVPOrders");
            lst.Add("_4201");
            lst.Add("totalRequestsAlloted");
            lst.Add("_4202");
            lst.Add("totalUnexecutedOrders");
            lst.Add("_4203");
            lst.Add("retention");
            lst.Add("_4204");
            lst.Add("inventoryAccount");
            lst.Add("_4330");
            lst.Add("allotmentIndicator");
            lst.Add("_4331");
            lst.Add("hideDisplayIndicator");
            lst.Add("_4910");
            lst.Add("interestExpressed");
            lst.Add("_5102");
            lst.Add("preliminaryProspectus");
            lst.Add("_5499");
            lst.Add("orderMinimum");
            lst.Add("_5500");
            lst.Add("orderMaximum");
            lst.Add("_5501");
            lst.Add("syndicateDescriptionNote1");
            lst.Add("_5502");
            lst.Add("syndicateDescriptionNote2");
            lst.Add("_5503");
            lst.Add("syndicateDescriptionNote3");
            lst.Add("_5504");
            lst.Add("syndicateDescriptionNote4");
            lst.Add("_5505");
            lst.Add("syndicateDescriptionNote5");
            lst.Add("_5506");
            lst.Add("syndicateDescriptionNote6");
            lst.Add("_5507");
            lst.Add("syndicateDescriptionNote7");
            lst.Add("_5508");
            lst.Add("syndicateDescriptionNote8");
            lst.Add("_5509");
            lst.Add("syndicateDescriptionNote9");
            lst.Add("_5510");
            lst.Add("syndicateDescriptionNote10");
            lst.Add("_5511");
            lst.Add("syndicateDescriptionNote11");
            lst.Add("_5512");
            lst.Add("syndicateDescriptionNote12");
            lst.Add("_5513");
            lst.Add("syndicateDescriptionNote13");
            lst.Add("_5514");
            lst.Add("syndicateDescriptionNote14");
            lst.Add("_5515");
            lst.Add("syndicateDescriptionNote15");
            lst.Add("_5516");
            lst.Add("syndicateDescriptionNote16");
            lst.Add("_20104");
            lst.Add("uniqueRowID");
            lst.Add("_21178");
            lst.Add("isBuyable");

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            int i = 0;
            foreach (string item in lst)
            {
                ++i;
                if (i % 2 == 1)
                {
                    sb.Append("{");
                    sb.Append("\"key\"");
                    sb.Append(":");
                    sb.Append("\"" + item + "\"");
                    sb.Append(",");
                }
                else
                {

                    sb.Append("\"value\"");
                    sb.Append(":");
                    sb.Append("\"" + item + "\"");
                    sb.Append("}");
                    sb.Append(",");
                }
            }
            sb.Append("]");
            string a = sb.ToString();
            Console.WriteLine(sb.ToString());

            #endregion
        }

        public static void StartFactoryPattern()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadKey();
        }
    }

}