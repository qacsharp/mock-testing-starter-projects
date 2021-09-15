using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureViewingApp
{
    class RealUserIdentifier : IUserIdentifier
    {
        public string GetLoggedOnUsername()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }
    }
}
