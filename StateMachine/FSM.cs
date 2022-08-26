using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StateMachine
{
    internal class FSM
    {
        State currentState;
        public FSM()
        {
            if(currentState == null)
            {
                TransitionState(new Idle());
            }
        }
        public bool RunningState(State state)
        {
            return currentState == state;
        }
        public void TransitionState(State state)
        {
            if (currentState == state) return;
            
            currentState = state;
            currentState.SetCharacter(this);
        }
        //attack
        public void Attack()
        {
            Console.WriteLine("Character is: ");
            currentState.Attack();
        }
        //follow
        public void Follow()
        {
            Console.WriteLine("Character is: ");
            currentState.Chase();
        }
        //idle
        public void Cancel()
        {
            Console.WriteLine("Character is: ");
            currentState.Cancel();
        }
    }
}
