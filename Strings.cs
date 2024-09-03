// See https://aka.ms/new-console-template for more information
namespace Muki
{
    class strings
    {
        static void Main(string[] args)
        {
            string phrase = "Muki is smart";
            Console.WriteLine("Muki\nRajkumar");
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("muki"));
            Console.WriteLine(phrase.Contains("Muki")); //this method is case sensitive
            Console.WriteLine(phrase[3]); // indexing
            Console.WriteLine(phrase.IndexOf("i")); //whether it contains this and at what index which is also case-sensitive
            Console.WriteLine(phrase.Substring(3,3));
            Console.ReadLine();
        }
    }
}
