using System;
using System.Collections.Generic;

namespace ConsoleProjectGenericsTwo{
    class Program{
        public static void Main(string[] args){
            Dictionary<string,int> prices = new Dictionary<string, int> (5);
            prices.Add("Watermelon", 5);
            prices.Add("Car", 10000);
            //Console.WriteLine(prices[0].ToString());
            Console.WriteLine(prices["Watermelon"]);
            Console.WriteLine(prices["Car"]);

            Console.ReadKey();


        }
    }
}