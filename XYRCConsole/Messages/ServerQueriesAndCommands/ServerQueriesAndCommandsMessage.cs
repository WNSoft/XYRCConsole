using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to return information about any server which is connected to the network.
    /// </summary>
    class ServerQueriesAndCommandsMessage : Message
    {
        public ServerQueriesAndCommandsMessage(String message) : base(message) { }
    }
}
