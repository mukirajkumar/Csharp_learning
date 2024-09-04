// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Calculator
    {
        public Calculator() { }
        static void Main(string[] args) {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //can also do conversion to double
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();

        }
    }
}
