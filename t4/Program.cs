using System;

namespace FirstConsoleProject {
    class MainClass {
        public static void Main (string[] args)
        {
           Random numberGen = new Random();

           int numberOfAttemps = 0;
           int attempt = 0;


           while(attempt!=6){
               attempt = numberGen.Next(1,7);
               Console.WriteLine("Tom rolled:" + attempt + ".");
               numberOfAttemps ++;
           }

           Console.WriteLine("It took Tom" + numberOfAttemps + " attemps to roll a six");

           Console.ReadKey();
        }
    }
}