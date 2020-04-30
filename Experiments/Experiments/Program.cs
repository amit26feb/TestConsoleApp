using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalNum = 0;

            ChangeNumber(out originalNum);

            Console.WriteLine(originalNum);
            Console.Read();
        }

        private static void ChangeNumber(out int copyOfOriginalNum)
        {
            copyOfOriginalNum = 0;
            copyOfOriginalNum = copyOfOriginalNum + 100;
          //  copyOfOriginalNum = copyOfOriginalNum * 10;
        }
    }
}
