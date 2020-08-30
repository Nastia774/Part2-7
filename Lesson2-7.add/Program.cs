using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_7.add
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("NV-4", "Китай", 65.70);
            notebook1.Write();

            Console.ReadKey();
        }
    }
}
