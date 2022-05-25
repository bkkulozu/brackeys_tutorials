using System;
using System.Collections.Generic;

namespace ConsoleProjectSeven {
    class MainClass{

        public static void Main(string[] args){

            List<int> numbers = new List<int> ();

            numbers.Add(13);
            numbers.Add(4);
            numbers.Add(8);


            Console.WriteLine(numbers[1]);

            Console.ReadKey();


        }
    }
}