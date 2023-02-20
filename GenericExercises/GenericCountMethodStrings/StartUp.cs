using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodCountStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<string> box = new();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();

                box.Add(item);
            }
            string itemToCompare = Console.ReadLine();
            Console.WriteLine(box.Count(itemToCompare));
        }
    
    }
}
