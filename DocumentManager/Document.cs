using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.DocumentManager
{
    public class Document
    {
        DocumentState currentState;
        public Document()
        {
            ChangeState(new Draft());
        }
        public void ChangeState(DocumentState state)
        {
            currentState = state;
            currentState.SetDocument(this);
        }
        public void Publish(User currentUser)
        {
            currentState.Publish(currentUser);
        }
    }
}
