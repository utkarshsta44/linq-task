using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace linq_test
{
    class Question5
    {
        public static void Method() {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var nestedList = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 } };
            var flattenedList = nestedList.SelectMany(x => x); // Flattens the nested list into a single list
            var transformedList = numbers.Select(x => x * 2); // Transforms each element by doubling its value



            foreach(var str in flattenedList)
            {
                Console.WriteLine(str);
            }


            foreach (var str in transformedList)
            {
                Console.WriteLine(str);
            }

        }
    }
}
