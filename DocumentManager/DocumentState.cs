using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.DocumentManager
{
    public abstract class DocumentState
    {
        protected Document document;
        public void SetDocument(Document document)
        {
            this.document = document;
        }
        public abstract void Render();
        public abstract void Publish(User user);
    }
}
