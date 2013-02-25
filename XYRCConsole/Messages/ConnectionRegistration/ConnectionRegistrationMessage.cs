using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to register a connection with an IRC
    /// server as either a user or a server as well as
    /// correctly disconnect.
    /// </summary>
    class ConnectionRegistrationMessage : Message
    {
        public ConnectionRegistrationMessage(String message) : base(message) { }
    }
}
