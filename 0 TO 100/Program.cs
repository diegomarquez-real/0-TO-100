using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_TO_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int random_int;
            string last_name;
            Random rnd = new Random();
            Console.WriteLine("Enter your last name: ");
            last_name = Console.ReadLine();
            random_int = rnd.Next(100, 1000);
            Console.WriteLine(last_name.Substring(0, 4).ToLower() + random_int);
            Console.ReadLine();






            
            

        }
    }
}
