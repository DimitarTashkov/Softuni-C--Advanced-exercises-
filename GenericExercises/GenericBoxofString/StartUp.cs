using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
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
            Console.WriteLine(box.ToString());

        }


    }
}
