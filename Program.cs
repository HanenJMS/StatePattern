using StatePattern.AudioPlayer;
using StatePattern.DocumentManager;
using StatePattern.StateMachine;
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
            //TestingAudioPlayer();
            //TestingDocumentManager();
            TEstingStateMachine();
        }

        private static void TEstingStateMachine()
        {
            Console.Clear();
            FSM character = new FSM();
            character.Attack();
            character.Attack();
            character.Follow();
            character.Cancel();
            character.Follow();
            character.Follow();
            character.Cancel();
            character.Cancel();
            Console.ReadLine();
        }

        private static void TestingDocumentManager()
        {
            User admin = new User(true);
            User user = new User(false);
            Document document = new Document();
            document.Publish(user);
            document.Publish(user);
            document.Publish(user);
            document.Publish(admin);
            document.Publish(user);
            document.Publish(admin);
            Console.ReadLine();
        }
        private static void TestingAudioPlayer()
        {
            var context = new Player();
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
