using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    ///  Used to tell a server that the other end of a new connection is a server.
    /// </summary>
    class ServerMessage : ConnectionRegistrationMessage
    {
        public ServerMessage(String message) : base(message) { }
    }
}
