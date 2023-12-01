using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq_test
{
    class Question11
    {
        public static void Method()
        {
            List<int> list1 = new List<int>() { 3, 4, 5, 5, 1 };
            List<int> list2 = new List<int>() { 1, 5, 7, 8, 2, 3, 2 };
            var result = list1.Union(list2);
             
            foreach( var str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
