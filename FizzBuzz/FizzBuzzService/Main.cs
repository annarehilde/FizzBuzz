using System;
using FizzBuzz.Service;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();

            foreach(var result in fizzBuzzService.GetFizzBuzz(100))
            {
                Console.WriteLine(result);
            }
            
            Console.ReadLine();
        }
    }
}


