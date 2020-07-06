namespace System
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                //Console.WriteLine(i);
                if (i%3 == 0 && i%5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%3 != 0 && i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}