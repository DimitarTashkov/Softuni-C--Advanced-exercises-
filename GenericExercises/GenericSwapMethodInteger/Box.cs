using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodInteger
{
    public class Box<T>
    {
        private List<T> items;
        public Box()
        {
            items= new List<T>(); 
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            (items[secondIndex], items[firstIndex]) = (items[firstIndex], items[secondIndex]);
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in items) 
            {
                sb.AppendLine($"{typeof(T)}: {item}");

            }
            return sb.ToString().TrimEnd();
        }
    }
}
