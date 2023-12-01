using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq_test
{
    class Question4
    {
        public static void Method()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var number2 = new List<int>();
            var character = new List<string> { "utkarh", "prince", "ajay", "govind", "yash" };

            var firstElement = numbers.First();
            Console.WriteLine(firstElement);


            var firstOrDefaultElement = number2.FirstOrDefault();
            Console.WriteLine(firstOrDefaultElement);

        }
    }
}
