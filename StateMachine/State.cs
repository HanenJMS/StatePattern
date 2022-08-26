using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StateMachine
{
    internal abstract class State
    {
        protected FSM character;
        public void SetCharacter(FSM character)
        {
            this.character = character;
        }
        public abstract void StartState();
        public abstract void Attack();
        public abstract void Chase();
        public abstract void Cancel();
    }
}
