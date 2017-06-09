using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            int d = 3, f = 5;    /* initializing d and f. */
            double pi = 3.14159; /* declares an approximation of pi. */
            char x = 'x';        /* the variable x has the value 'x'. */
            string firstName = "Zhang San"; /*Assign "Zhang San" to firstName*/
            string singleChar = "ysssss";

            short a;//declaration
            int b;
            double c;
            /* actual initialization */
            a = 10;
            b = 20;
            c = a + b;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();

            ////accepting user input
            //int num;
            //num = Convert.ToInt32(Console.ReadLine());

            //Escape 
            Console.WriteLine("Hello\tWorld\n\n");

        }
    }
}
