using System;

class MainClass{
    public static void Main(string[] args)
    {
        Random numberGenerator = new Random();

        int n1 = numberGenerator.Next(1,11);
        int n2 = numberGenerator.Next(1,11);

        Console.WriteLine("What is " + n1 + " times " + n2 + " ? ");
        int answer = Convert.ToInt32(Console.ReadLine());

        if(answer == n1 * n2) {
            Console.WriteLine("Well done! Your answer is correct.");

        }else {
            int responseIndex = numberGenerator.Next(1,4);

            switch(responseIndex){
                case 1:
                Console.WriteLine("Are you even trying?");
                break;

                case 2:
                Console.WriteLine("The answer was incorrect.");
                break;

                default:
                Console.WriteLine("You can do better than that.");
                break;



            }
        }

        Console.ReadKey();

    }
}