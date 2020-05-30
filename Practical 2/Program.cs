using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            String country;

            do
            {
                Console.WriteLine("Enter your name");
                name = Console.ReadLine();
            }
            while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));

            Console.WriteLine("Which country do you belong to?");
            country = Console.ReadLine();

            Console.WriteLine("Hi, " + name + " from " + country);
            Console.Read();

        }
    }
}
