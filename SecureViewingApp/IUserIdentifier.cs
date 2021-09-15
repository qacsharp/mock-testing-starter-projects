using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureViewingApp
{
    public interface IUserIdentifier
    {
        string GetLoggedOnUsername();
    }
}
