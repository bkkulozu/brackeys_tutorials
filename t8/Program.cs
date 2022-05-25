using System;

namespace Program{
    class Animal {

        public string name = "Spotty";
        public int age = 6;

        public float happiness = 0.5f;
    }

    class MainClass{
        public static void Main(string[] args){
            Animal dog = new Animal();
            Console.WriteLine(dog.name);
            dog.name = "Broody";
            Console.WriteLine(dog.name);

            Console.ReadKey();

        }
    }
}