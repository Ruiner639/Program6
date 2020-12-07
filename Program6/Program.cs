using System;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height: ");
            string height = Console.ReadLine();
            Int32.TryParse(height, out int height_int);
            if (height_int >= 190)
            {
                Console.WriteLine("You could be a good basketball player");
            }
            else if(height_int < 175)
            {
                Console.WriteLine("You could be a good horseman");
            }
            else
            {
                Console.WriteLine("You could be a good athlete");

            }
            
        }
    }
}
