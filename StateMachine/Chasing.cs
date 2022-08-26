using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StateMachine
{
    internal class Chasing : State
    {
        public Chasing()
        {

            Console.WriteLine("starts chasing");
        }

        public override void Attack()
        {
            character.TransitionState(new Attacking());
        }

        public override void Cancel()
        {
            character.TransitionState(new Idle());
        }

        public override void Chase()
        {
            Console.WriteLine("Chasing");
        }

        public override void StartState()
        {
            character.TransitionState(this);
        }
    }
}
