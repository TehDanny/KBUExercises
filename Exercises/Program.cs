using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            int middle = Exercise.Middle4(3, 4, 5);
            Console.WriteLine(middle);
            middle = Exercise.Middle4(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine(middle);
            Console.WriteLine(Exercise.ValueExists());
            int[] testArr = { 1, 2, 3 };
            
            Console.WriteLine(Exercise.Median(testArr));
            Console.ReadKey();
        }
    }
}
