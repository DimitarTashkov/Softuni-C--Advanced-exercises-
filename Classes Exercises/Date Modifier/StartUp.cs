using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Modifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            int differenceInDays = DateModifier.GetDifferenceInDays(start,end);

            Console.WriteLine(differenceInDays);
        }
    }
}
