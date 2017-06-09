using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double e = 3.14;           
            int a, b, c, d;//declaration
            a = b = c = d = 0;//initialization
            b = a + 5; //Assignment Statement 5
            a = b; //
            //e = 3.14;  error here. lvalue has to be variable.
            a += 3;
            a = a + 3; //11
            string dayOfWeek = "Saturday";

            //if (dayOfWeek == "Thursday")
            //{
            //    Console.WriteLine("Throwback Thursday");
            //}
            //if (dayOfWeek == "Friday")
            //{
            //    Console.WriteLine("Flashback Friday");
            //}

            //switch (dayOfWeek)
            //{
            //    case "Tuesday":
            //    case "Thurday":
            //    case "Saturday":
            //    case "Sunday":
            //        Console.WriteLine("Class Day");
            //        break;
            //    default:
            //        Console.WriteLine("NO Class Today");
            //        break;
            //}


            //if (a > 10)
            //{
            //    //if (b < 10)
            //    //{
            //    //    Console.WriteLine("A > 10 && B < 10");
            //    //}
            //    a -= 10;
            //    Console.WriteLine("A is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine("A is less than 10");
            //}
            
            //Trinary Operator Operant?Operant:Operant;
            Console.WriteLine(a>10?"A is greater than 10":"A is less than 10");
            Console.WriteLine(DateTime.Now);
            if(DateTime.Now.Hour>18)
            {
                Console.WriteLine("Good Evening");
            }
        }
    }
}
