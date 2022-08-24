using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Structure
{
    public class Context
    {
        State currentState;
        public Context(State newState)
        {
            TransitionTo(newState);
        }

        public void TransitionTo(State newState)
        {
            Console.WriteLine("Transition to new state");
            currentState = newState;
            currentState.SetContext(this);
        }
        public void Request1()
        {
            currentState.Handle1();
        }
        public void Request2()
        {
            currentState.Handle2();
        }
    }
}
