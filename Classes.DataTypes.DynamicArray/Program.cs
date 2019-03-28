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

            dynamicArray.Insert(4,10);

            dynamicArray.Add(9);
            dynamicArray.PrintContent();
            dynamicArray.Add(new DynamicArray(2));
            dynamicArray.PrintContent();

            Console.ReadKey();

        }
    }
}
