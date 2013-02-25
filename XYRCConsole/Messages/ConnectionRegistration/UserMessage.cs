using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used at the beginning of connection to specify the
    /// username, hostname, servername and realname of a new user.
    /// </summary>
    class UserMessage : ConnectionRegistrationMessage
    {
        public UserMessage(String message) : base(message) { }
    }
}
