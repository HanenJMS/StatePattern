using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AudioPlayer
{
    public abstract class State
    {
        protected Player player;
        public State(Player player)
        {
            this.player = player;
        }
        public abstract void clickLock();
        public abstract void clickPlay();
        public abstract void clickNext();
        public abstract void clickPrevious();
    }
}
