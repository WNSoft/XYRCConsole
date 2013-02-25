using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to return information which describes the server.
    /// </summary>
    class InfoMessage : ServerQueriesAndCommandsMessage
    {
        public InfoMessage(String message) : base(message) { }
    }
}
