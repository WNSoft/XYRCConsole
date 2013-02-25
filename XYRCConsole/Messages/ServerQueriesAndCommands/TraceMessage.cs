using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Is used to find the route to a specific server
    /// </summary>
    class TraceMessage : ServerQueriesAndCommandsMessage
    {
        public TraceMessage(String message) : base(message) { }
    }
}
