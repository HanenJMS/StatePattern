using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AudioPlayer
{
    public class PlayingState : State
    {
        public PlayingState(Player player) : base(player)
        {
        }

        public override void clickLock()
        {
            Console.WriteLine("Lock Player");
            player.ChangeState(new LockedState(player));
        }

        public override void clickNext()
        {
            Console.WriteLine("Player skipping: ");
            player.fastForward(5);
        }

        public override void clickPlay()
        {
            Console.WriteLine("Pausing");
            player.StopPlayback();
            player.ChangeState(new ReadyState(player));
        }

        public override void clickPrevious()
        {
            Console.WriteLine("Player rewinding: ");
            player.fastForward(5);
        }
    }
}
