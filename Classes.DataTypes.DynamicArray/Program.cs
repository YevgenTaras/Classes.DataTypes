using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.DataTypes.DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {

            DynamicArray dynamicArray = new DynamicArray(1);

            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            dynamicArray.Add(4);
            dynamicArray.Add(5);
            dynamicArray.Add(6);
            dynamicArray.Add(7);
            dynamicArray.Add(8);
            dynamicArray.PrintContent();

            dynamicArray.RemoveAt(2);
            dynamicArray.PrintContent();

            dynamicArray.Remove(7);
            dynamicArray.PrintContent();

            dynamicArray.Add("hello");
            dynamicArray.Insert(5, 3.14);
            dynamicArray.PrintContent();


            Console.WriteLine("Item: {0}; contains in array: {1}; by index {2}", 4, dynamicArray.Contains(4), dynamicArray.IndexOf(4));
            Console.WriteLine("Item: {0}; contains in array: {1}; by index {2}", 12, dynamicArray.Contains(12), dynamicArray.IndexOf(12));

            dynamicArray.Add(new DynamicArray(2));
            dynamicArray.PrintContent();

            dynamicArray.Clear();
            dynamicArray.PrintContent();

            Console.ReadKey();

        }
    }
}
