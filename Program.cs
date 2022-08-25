using StatePattern.AudioPlayer;
using StatePattern.Structure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new Player(new ReadyState());
            //testing ready state transitions
            context.CurrentStateRead();
            context.clickNext();
            context.clickPrevious();
            //ready ---> locked
            context.clickLock();
            context.CurrentStateRead();
            //testing locked state transitions
            context.clickNext();
            context.clickPrevious();
            context.clickPlay();
            //locked ---> ready
            context.clickLock();
            context.CurrentStateRead();
            context.clickNext();
            context.clickPrevious();
            //ready ---> playing
            context.clickPlay();
            context.CurrentStateRead();
            //testing PlayingState
            context.clickNext();
            context.clickPrevious();
            //testing playing ---> locked ---> playing transition
            context.clickLock();
            context.CurrentStateRead();
            context.clickPlay();
            context.clickNext();
            context.clickPrevious();
            //state ---> playing
            context.clickLock();
            context.CurrentStateRead();
            context.clickNext();
            context.clickPrevious();
            Console.ReadLine();
        }
    }
}
