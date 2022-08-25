using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.AudioPlayer
{
    public class Player
    {
        State state;
        bool isPlaying = false;
        public Player(State state)
        {
            ChangeState(state);
        }

        public void ChangeState(State state)
        {
            this.state = state;
            state.SetPlayer(this);
        }
        public void clickLock()
        {
            state.clickLock();
        }
        public void clickPlay()
        {
            state.clickPlay();
        }
        public void clickNext()
        {
            state.clickNext();
        }
        public void clickPrevious()
        {
            state.clickPrevious();
        }
        public bool IsPlaying()
        {
            return isPlaying;
        }
        public void CurrentStateRead()
        {
            Console.WriteLine($"Current State : {state}");
        }
        public void StartPlayback()
        {
            isPlaying = true;
        }
        public void StopPlayback()
        {
            isPlaying = false;
        }
        public void nextSong()
        {

        }
        public void previousSong()
        {

        }
        public void fastForward(int seconds)
        {
            Console.WriteLine($"{seconds} seconds");
        }
        public void rewind(int seconds)
        {
            Console.WriteLine($"{seconds} seconds");
        }
    }
}
