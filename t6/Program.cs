using System;
using System.Collections.Generic;


namespace Programs{

    class Program{

        public static void Main(string[] args){

            CreateGrid();
            Console.ReadKey();

        }

        public static void CreateGrid(){
            int width=5;
            int height=5;

            int[,]grid = new int[width,height];

            for(int x=0; x < width; x++)
            {
                for(int y=0; y < height; y++)
                {
                    Console.Write(grid[x,y] + "");
                }

            }
           
        }

    }
}
