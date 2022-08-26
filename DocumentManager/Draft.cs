using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.DocumentManager
{
    public class Draft : DocumentState
    {
        public override void Publish(User user)
        {
            Console.WriteLine("User is requesting publishing. Sending to Moderation");
            document.ChangeState(new Moderation());
        }

        public override void Render()
        {
            
        }
    }
}
