using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Higher_Lower
{
    class Program
    {
        static void Main(string[] args)
        {
            //A random number is generated here for the user to guess.
            int RandomNumber = new Random().Next(100);

            Console.WriteLine("Welcome to the game higher or lower.");
            string[] multipleLines = { "Hello", "World" };
            Console.WriteLine(multipleLines);



            int[] numbers = { 0, 1, 2, 3, 4, 5 };
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];
            //Console.WriteLine(firstNumber, secondNumber);
        }
    }
}
