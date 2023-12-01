using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq_test
{
    class Question14
    {
        public static void Method()
        {
            var numbers = new List<int> { 1, 2, 2,2,2, 6, 7, 8, 9 };
            var distinctItems = numbers.Distinct();

            foreach(var str in distinctItems)
                Console.WriteLine(str);

        }
    }
}
