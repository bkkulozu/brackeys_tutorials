using System;
//properties


namespace ConsoleProjectProperties{

    class MainClass{

        class Player{
            private int _health = 100;
            public int health
            {
                get {
                    return _health;
                }
            }

            public void Damage(int _dmg){
                _health -= _dmg;
            }
        }

        public static void Main(string[] args){

            Player tom = new Player();
            tom.Damage(30);
           // tom.health=20;
           // Console.WriteLine(tom.health);

            Console.WriteLine("Tom health level : " + tom.health);

            Console.ReadKey();
        }
    }
}