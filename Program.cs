using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            while (counter < 100) {
                if (counter % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else {
                    Console.WriteLine(counter);
                }
                counter++;
            }
        }
    }
}
