// inheritance

using System;

namespace ConsoleProjectInheritance{

    class MainClass {
        class Animal
        {
       public string name;

        public int age;

        public float happiness;

        public void printBase(){
            Console.WriteLine("Name " + name);
            Console.WriteLine("Age " + age);
            Console.WriteLine("Happiness " + happiness);
            //Console.WriteLine("");
        }
    }

    class Dog : Animal {
        public int spotCount;

         public void Bark () {
            Console.WriteLine("WUF!");
        }
    }



    class Cat : Animal {
        public float cuteness;

        public void Meow() {
            Console.WriteLine("MEOW!");
        }

       
    }

    public static void Main(string[] args)
    {

        Dog spotyy = new Dog();
        spotyy.name = "Spooty";
        spotyy.age = 4;
        spotyy.happiness = 0.8f;
        spotyy.spotCount = 25;
        spotyy.printBase();
        spotyy.Bark();

         }
    }

}