using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodCountDouble
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<double> box = new();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                double item = double.Parse(Console.ReadLine());

                box.Add(item);
            }
            double itemToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(itemToCompare));
        }
    
    }
}
