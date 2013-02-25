using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to force a server to try to establish
    /// a new connection to another server immediately.
    /// </summary>
    class ConnectMessage : ServerQueriesAndCommandsMessage
    {
        public ConnectMessage(String message) : base(message) { }
    }
}
