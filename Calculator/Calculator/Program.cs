// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args) {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Which operation do you want to use? Choose one of the four options:\n1. + \n2. -\n3. *\n4. /\n");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                Console.Write(num1 + num2);
            }
            else if (op == 2)
            {
                Console.Write(num1 - num2);
            }
            else if (op == 3)
            {
                Console.Write(num1 * num2);
            }
            else if (op == 4)
            {
                Console.Write(num1 / num2);
            }
            else {
                Console.Write("You did not choose correctly");
            }
            Console.ReadLine();

        }
    }
}
