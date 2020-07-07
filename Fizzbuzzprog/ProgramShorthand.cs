using System.Collections.Generic;
using System.Linq;

namespace System
{
    internal class ProgramShorthand
    {
        public static void Main(string[] args)
        {
            foreach (var i in Enumerable.Range(1, 100).Select(x => x%105 == 0 ? "FizzBuzzBang" : x%35 == 0 ? "BuzzBang" : x%21 == 0 ? "FizzBang": x%15 == 0 ? "FizzBuzz": x%7 == 0 ? "Bang": x%5 == 0 ? "Buzz": x%3 == 0 ? "Fizz" : x.ToString())) Console.WriteLine(i);
        }
    }
}
