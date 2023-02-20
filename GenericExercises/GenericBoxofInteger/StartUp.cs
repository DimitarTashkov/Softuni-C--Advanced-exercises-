using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using GenericBoxofInteger;

namespace GenericBoxofInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<int> box = new();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int item = int.Parse(Console.ReadLine());

                box.Add(item);
            }
            Console.WriteLine(box.ToString());

        }


    }
}
