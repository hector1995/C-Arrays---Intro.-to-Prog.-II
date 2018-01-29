using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {1,3,56,4}; //Array with 4 elements, 3 indexes (0-3)

            //Foreach loop to show all integers in array1
            foreach (int swag in array1)
            {
                WriteLine(swag);
            }
        }
    }
}
