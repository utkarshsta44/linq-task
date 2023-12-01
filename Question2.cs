using System;
using System.Collections.Generic;
using System.Text;

namespace linq_test
{
    class question2
    {
   


        public static void Method() { 


            // Statement Lambda
            Func<int, int, int> statementLambda = (a, b) => {
                int result = a + b;
                return result;
            };

            // Expression Lambda
            Func<int, int, int> expressionLambda = (a, b) => a + b;

            // Using the lambdas
            int result1 = statementLambda(3, 5);
            int result2 = expressionLambda(3, 5);

            Console.WriteLine("Result of statement lambda: " + result1);
            Console.WriteLine("Result of expression lambda: " + result2);
        }
    }

}
