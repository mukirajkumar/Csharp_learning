using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__learning
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int num = 6;
            num++;//increment decrement also can with --
            Console.WriteLine(5 / 8); //can also use brackets to implement order of operations, also when you do operation with two integers you are gonna get an integer back but if it is btw integer and double, it is gonna return as double
            Console.WriteLine(7 % 2); //mod operator
            Console.WriteLine(num);
            //can use Math methods to do Math operations such as cosine 
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(2, num));
            Console.WriteLine(Math.Max(0, num)); // also have Min, Round which does rounding to integers
            Console.ReadLine();
        }
    }
}
