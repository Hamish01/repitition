using System;

namespace Repition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do you want to print that name.");
            string num = Console.ReadLine();
            int intnum = int.Parse(num);

            int counter = 0;
            
            while (counter < intnum) 
            {
                Console.WriteLine("please enter your name");
                string name = Console.ReadLine();
                Console.WriteLine(name);
                //counter = counter + 1;
                counter++;
            }
            Console.WriteLine("Goodbye");
        }
    }
}
