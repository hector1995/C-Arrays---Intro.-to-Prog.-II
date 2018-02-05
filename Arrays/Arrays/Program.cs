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
            int[] array1 = {1,3,56,4}; //Array with 4 elements, 3 indexes (0-3) integer type

            //Foreach loop to show all integers in array1
            foreach (int swag in array1)
            {
                WriteLine(swag);
            }

            WriteLine("\n//////////////////////////////////////////// \n");

            String[] luxingburg = new String[8]; //Array of size 8, String type

            WriteLine(luxingburg.Length); //Display length of luxingburg array
            luxingburg[7] = "Hello world!"; //Fill in index 7 with data
            luxingburg[5] = "I like coding!"; //Fill in index 5 with data

            //Foreach loop to show all integers in luxingburg
            foreach (String swag in luxingburg)
            {
                WriteLine(swag);
            }
        }
    }
}
