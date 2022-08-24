using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Structure
{
    internal class State1 : State
    {
        public override void Handle1()
        {
            Console.WriteLine($"State1 handling request1");
            Console.WriteLine("State now transitioning: ");
            context.TransitionTo(new State2());
        }

        public override void Handle2()
        {
            Console.WriteLine($"State1 handling request2");
        }
    }
}
