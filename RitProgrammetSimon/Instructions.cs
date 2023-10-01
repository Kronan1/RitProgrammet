using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitProgrammetSimon
{
    internal class Instructions
    {
        public static void Draw()
        {
            Console.WriteLine(Convert.ToChar(24) + " - W");
            Console.WriteLine(Convert.ToChar(17) + " - A");
            Console.WriteLine(Convert.ToChar(26) + " - D");
            Console.WriteLine(Convert.ToChar(25) + " - S");
            Console.WriteLine("Select character and press Enter to paint");
            Console.WriteLine();
        }
    }
}
