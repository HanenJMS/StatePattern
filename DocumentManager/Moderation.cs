using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.DocumentManager
{
    internal class Moderation : DocumentState
    {
        public override void Publish(User user)
        {
            if (user.IsAdmin())
            {
                Console.WriteLine("Admin is publishing document: ");
                document.ChangeState(new Published());
            }
            else
            {
                Console.WriteLine("User does not have permission to publish");
            }
        }

        public override void Render()
        {
            
        }
    }
}
