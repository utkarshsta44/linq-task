﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq_test
{
    class Question8
    {
        public static void Method()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var count = numbers.Count();

            Console.WriteLine(count);
        }
    }
}
