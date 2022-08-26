using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StateMachine
{
    internal class Idle : State
    {
        public Idle()
        {
            Console.WriteLine("Going Idle");
        }
        public override void Attack()
        {
            character.TransitionState(new Attacking());
        }

        public override void Cancel()
        {
            
        }

        public override void Chase()
        {
            character.TransitionState(new Chasing());
        }

        public override void StartState()
        {
            character.TransitionState(this);
        }

    }
}
