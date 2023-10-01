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
            Console.WriteLine("Up    - " + Convert.ToChar(24));
            Console.WriteLine("Left  - " + Convert.ToChar(17));
            Console.WriteLine("Right - " + Convert.ToChar(26));
            Console.WriteLine("Down  - " + Convert.ToChar(25));
            Console.WriteLine("Select character and press Enter to paint");
            Console.WriteLine();
        }
    }
}
