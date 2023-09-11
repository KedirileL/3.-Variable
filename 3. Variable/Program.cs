using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaration
            string name;
            int age;
            name = "Andani";
            age= 10;

            //printing to consule using + for concatenation

            Console.WriteLine("Hi " + name);
            Console.WriteLine("You are " + age);

            //Change the values of the variables

            name = "Lekgale";
            age = 19;

            Console.WriteLine("He never like his name, at age " + age + " he changed to " + name);
        }
    }
}
