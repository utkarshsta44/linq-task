using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace linq_test
{
    class Question15
    {
        public static void Method()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            var allPositive = numbers.All(x => x > 0);
            var anyGreaterThanTen = numbers.Any(x => x > 10);

            Console.WriteLine(allPositive);
            Console.WriteLine(anyGreaterThanTen);

        }
    }
}
