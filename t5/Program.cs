using System;

namespace FirstConsoleProject{
    class MainClass {
        public static void Main(string[] args)
        {
                int result = Add(1,8);
                if (result > 10)
                {
                    Console.WriteLine("Result is larger than 10.");

                }

                else {
                    Console.WriteLine("Result is smaller than or equal to 10.");

                }

        }

        public static int Add(int n1, int n2){
            return n1 + n2;
        }
    }
}