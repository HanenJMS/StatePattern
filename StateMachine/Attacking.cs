using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StateMachine
{
    internal class Attacking : State
    {
        Chasing chaser = new Chasing();
        public Attacking()
        {
            Console.WriteLine("starting attack");
        }
        public override void Attack()
        {
            Console.WriteLine("Attacking");
        }

        public override void Cancel()
        {
            character.TransitionState(new Idle());
        }

        public override void Chase()
        {
            Console.WriteLine("Attacker is: ");
            chaser.Chase();
        }

        public override void StartState()
        {
            character.TransitionState(this);
        }
    }
}
