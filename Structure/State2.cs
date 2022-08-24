using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Structure
{
    internal class State2 : State
    {
        public override void Handle1()
        {
            throw new NotImplementedException();
        }

        public override void Handle2()
        {
            Console.WriteLine($"State1 handling request2");
            Console.WriteLine("State now transitioning: ");
            context.TransitionTo(new State1());
        }
    }
}
