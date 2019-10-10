using System;

namespace Open_Lab_01._3
{
    class Program
    {
        public static int Addition(int num)

        {
            return (num + 1);
        }

        static void Main(String[] args)
        {
            int num;
            int addition; 

            Console.WriteLine("Zadajte svoje číslo:");
            num = int.Parse(Console.ReadLine());

            addition = Addition(num);
            Console.WriteLine(num);
        }
    }
}
