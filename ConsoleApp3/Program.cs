// See https://aka.ms/new-console-template for more information
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("all comparission operations");
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("num1 =" + num1);
            Console.WriteLine("num2 =" + num2);
            if (num1 > num2) // greater than
            {
                Console.WriteLine("num1 is greater");
            }
            else if(num1 == num2) // equal
            {
                Console.WriteLine("both are equal");
            }
            else // hdden lesser than
            {
                Console.WriteLine("num2 is greater");

            }
            Console.WriteLine("also checking boolen:"); // boolen values
            Console.WriteLine(num1>num2); 
            Console.WriteLine(num1<num2);
        }
    }
}