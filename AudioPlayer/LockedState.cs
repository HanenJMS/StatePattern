using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AudioPlayer
{
    public class LockedState : State
    {
        public override void clickLock()
        {
            Console.WriteLine("Unlock Player");
            if(player.IsPlaying())
            {
                player.ChangeState(new PlayingState());
            }
            else
            {
                player.ChangeState(new ReadyState());
            }
        }
        //nothing should really happen in locked state
        public override void clickNext()
        {
            Console.WriteLine("No action available. Currently locked");
        }

        public override void clickPlay()
        {
            Console.WriteLine("No action available. Currently locked");
        }

        public override void clickPrevious()
        {
            Console.WriteLine("No action available. Currently locked");
        }
    }
}
