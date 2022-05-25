using System;
using System.Collections.Generic;

namespace ConsoleGenericThree{

    class Program {

        public static void Main(string[] args){

            Console.WriteLine("");
            Console.WriteLine(Utility.CompareValues("c#", "csharp"));
            Console.WriteLine(Utility.CompareTypes("c#", "csharp"));
        }
    }

    class Utility{
        public static bool CompareValues<T01, T02> (T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }

        public static bool CompareTypes<T01, T02> (T01 type01, T02 type02)
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }
}