using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Used to return a list of users logged into the server.
    /// </summary>
    class UsersMessage : OptionalMessage
    {
        public UsersMessage(String message) : base(message) { }
    }
}
