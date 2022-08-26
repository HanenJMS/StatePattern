using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.DocumentManager
{
    internal class Published : DocumentState
    {
        public override void Publish(User user)
        {
            Console.WriteLine("Already published. Try Rendering");
        }

        public override void Render()
        {
            Console.WriteLine("Rendering document");
        }
    }
}
