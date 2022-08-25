using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AudioPlayer
{
    public class ReadyState : State
    {
        public ReadyState(Player player) : base(player)
        {
        }

        public override void clickLock()
        {
            Console.WriteLine("Lock Player");
            player.ChangeState(new LockedState(player));
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
            player.ChangeState(new PlayingState(player));
        }

        public override void clickPrevious()
        {
            Console.WriteLine("Previous Music");
            player.previousSong();
        }
    }
}
