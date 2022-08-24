using StatePattern.Structure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new State1());
            context.Request1();
            context.Request2();
            Console.ReadLine();
        }
    }
}
