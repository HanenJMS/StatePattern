using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AudioPlayer
{
    public class ReadyState : State
    {
        public override void clickLock()
        {
            Console.WriteLine("Lock Player");
            player.ChangeState(new LockedState());
        }

        public override void clickNext()
        {
            Console.WriteLine("Next Music");
            player.nextSong();
        }

        public override void clickPlay()
        {
            Console.WriteLine("Playing Music");
            player.StartPlayback();
            player.ChangeState(new PlayingState());
        }

        public override void clickPrevious()
        {
            Console.WriteLine("Previous Music");
            player.previousSong();
        }
    }
}
