using System;
using System.Collections.Generic;

namespace reviewRoger
{
    class Program
    {
        //methods

        public static void Print()
        {
            Console.WriteLine("hello");
        }


        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //loops


            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);

            for (int j = 9; j >= 0; j--)
            {
                Console.WriteLine(numbers[j]);
            }

            bool whitLikesCandy = true;

            while (whitLikesCandy) //true
            {
                
                Console.WriteLine("Whit likes candy yes or no?");

                var reply = Console.ReadLine();

                if(reply == "yes")
                {
                    whitLikesCandy = true;
                }
                else
                {
                    whitLikesCandy = false;
                }
            }



            do
            {


            } while (true);

            var numbs = new List<int>() { 1, 2, 3, 4, 5, 6 };
            foreach (var item in numbs)
            {
                Console.WriteLine(item);
            }
        }



    }
}
