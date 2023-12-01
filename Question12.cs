using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq_test
{
    class Question12
    {
        public static void Method()
        {

                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

                
                int firstElement = numbers.First(); 
                Console.WriteLine(firstElement);

           
                int firstOrDefaultElement = numbers.FirstOrDefault();
                Console.WriteLine( firstOrDefaultElement);

                
                try
                {
                    int singleElement = numbers.Single(x => x == 3);
                    Console.WriteLine("Single element: " + singleElement);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);
                }

                
                int singleOrDefaultElement = numbers.SingleOrDefault(x => x == 10); 
                Console.WriteLine( singleOrDefaultElement);
            }
        }





    }

