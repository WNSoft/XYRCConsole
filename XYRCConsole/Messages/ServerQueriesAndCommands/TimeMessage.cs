using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to query local time from the specified server.
    /// </summary>
    class TimeMessage : ServerQueriesAndCommandsMessage
    {
        public TimeMessage(String message) : base(message) { }
    }
}
