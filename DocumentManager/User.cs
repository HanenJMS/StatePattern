using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.DocumentManager
{
    public class User
    {
        bool isAdmin = false;
        public User(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }

        public bool IsAdmin()
        {
            return isAdmin;
        }
    }
}
