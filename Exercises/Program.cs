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
            int middle = Middle(3, 4, 5);
            Console.WriteLine(middle);
            Console.ReadKey();
        }

        public int Middle(int x, int y, int z)
        {
            if (x > y && x < z || x < y && x > z)
                return x;
            if (y > x && y < z || y < x && y > z)
                return y;
            if (z > x && z < y || z < x && z > y)
                return z;
            return 0;
        }
    }
}
