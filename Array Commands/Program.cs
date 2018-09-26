using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic array commands through Udemy training software

            var numbers = new[] {3, 7, 9, 2, 14, 6};
            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //Index
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9: " + index);

            //Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("effect of clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of sort()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of reverse()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
